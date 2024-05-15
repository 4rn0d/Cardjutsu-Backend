using Microsoft.AspNetCore.SignalR;
using Super_Cartes_Infinies.Hubs;
using Super_Cartes_Infinies.Models.Dtos;

namespace Super_Cartes_Infinies.Services
{
    public class PlayerInfo
    {
        public string userID { get; set; }
        public int ELO { get; set; }
        public int deckID { get; set; }
        public int Attente { get { return (DateTime.Now - HeureJoin).Seconds; } }
        public DateTime HeureJoin { get; set; }

    }

    public class PairingService: BackgroundService
    {
        public const int DELAY = 1 * 1000;


        private WaitingUserService _waitingUserService;
        private MatchesService _matchesService;

        private IHubContext<MatchHub> _hub;

        private IServiceScopeFactory _serviceScopeFactory;

        public PairingService(WaitingUserService waitingUserService, IServiceScopeFactory serviceScopeFactory, IHubContext<MatchHub> monHub)
        {
            _waitingUserService = waitingUserService;
            //_matchesService = matchesService;
            _serviceScopeFactory = serviceScopeFactory;
            _hub = monHub;

        }

        public async Task CreateELOAppropriateMatch(CancellationToken stoppingToken)
        { 
            List<PlayerInfo> copyListPI = new List<PlayerInfo>();
            copyListPI.AddRange(_waitingUserService._listPlayerInfos);

            while (copyListPI.Count > 0)
            {
                PlayerInfo pInfo = copyListPI[0];

                copyListPI.RemoveAt(0);

                int smallestELOdiff = int.MaxValue;

                int index = -1;

                for (int i = 0; i < copyListPI.Count; i++)
                {
                    PlayerInfo pi = copyListPI[i];
                    int diff = int.Abs(pi.ELO - pInfo.ELO);
                    if (diff < (pInfo.Attente * DELAY))
                    {
                        if (diff < smallestELOdiff)
                        {
                            smallestELOdiff = diff;
                            index = i;
                        }
                    }
                }

                if( index>=0 )
                {
                    PlayerInfo playerinfo2 = copyListPI[index];
                    copyListPI.RemoveAt(index);
                    UsersReadyForAMatch pair = new UsersReadyForAMatch(pInfo.userID, playerinfo2.userID, pInfo.deckID, playerinfo2.deckID, _waitingUserService._playerConnectionId);
                    // _matchesService.StartMatch(pair);


                    _waitingUserService._listPlayerInfos.Remove(pInfo);
                    _waitingUserService._listPlayerInfos.Remove(playerinfo2);
                }


            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(DELAY, stoppingToken);
                await CreateELOAppropriateMatch(stoppingToken);
            }
        }
    }
}

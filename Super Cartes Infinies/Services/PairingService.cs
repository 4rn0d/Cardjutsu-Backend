using Super_Cartes_Infinies.Models.Dtos;

namespace Super_Cartes_Infinies.Services
{
    public class PlayerInfo
    {
        public string userID { get; set; }
        public int ELO { get; set; }
        public int Attente { get; set; }

    }

    public class PairingService: BackgroundService
    {
        public const int DELAY = 1 * 1000;



        private WaitingUserService _waitingUserService;
        private MatchesService _matchesService;

        public PairingService()
        {
            
        }

        public async Task CreateELOAppropriateMatch(CancellationToken stoppingToken)
        {

            //JoiningMatchData joiningMatchData = await _matchesService.JoinMatch(CurentUser.Id, 0, Context.ConnectionId, null);

            //if (joiningMatchData != null)
            //{
            //    string matchGroup = CreateGroup(joiningMatchData.Match.Id);
            //    await Groups.AddToGroupAsync(Context.ConnectionId, matchGroup);
            //    if (joiningMatchData.OtherPlayerConnectionId != null)
            //    {
            //        await Groups.AddToGroupAsync(joiningMatchData.OtherPlayerConnectionId, matchGroup);
            //    }

            //    // TODO
            //    await Clients.Group(matchGroup).SendAsync("GetMatchData", joiningMatchData);

            //    if (!joiningMatchData.IsStarted)
            //    {
            //        // TODO
            //        var startMatchEvent = await _matchesService.StartMatch(CurentUser.Id, joiningMatchData.Match);
            //        await Clients.Group(matchGroup).SendAsync("StartMatch", startMatchEvent);
            //    }
            //    await Clients.Caller.SendAsync("IsWaiting", false);
            //}
            //else
            //{
            //    await Clients.Caller.SendAsync("IsWaiting", true);
            //}




        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Drawing;

namespace Super_Cartes_Infinies.Services
{
    public class UsersReadyForAMatch
    {
        public UsersReadyForAMatch(string userAId, string userBId, int deckAId, int deckBId, string playerConnectionId)
        {
            UserAId = userAId;
            UserBId = userBId;
            DeckAId = deckAId;
            DeckBId = deckBId;
            PlayerConnectionId = playerConnectionId;
        }

        public string UserAId { get; set; }
        public string UserBId { get; set; }
        public int DeckAId { get; set; }
        public int DeckBId { get; set; }
        public string PlayerConnectionId { get; set; }
    }

	public class WaitingUserService
    {
        private string? _waitingUserId = null;
        private int _waitingDeckId = 0;
        public string? _playerConnectionId = null;
        private SemaphoreSlim _semaphore;
        public List<PlayerInfo> _listPlayerInfos;


        public string WaitingUserId { get { return _waitingUserId; } }

        public WaitingUserService()
        {
            _semaphore = new SemaphoreSlim(1);
            _listPlayerInfos = new List<PlayerInfo>();
        }

        public async Task<bool> StopWaitingUser(string userId)
        {
            await _semaphore.WaitAsync();
            bool stoppedWaiting = false;
            if (_waitingUserId == userId)
            {
                _waitingUserId = null;
                _waitingDeckId = 0;
                _playerConnectionId = null;
                stoppedWaiting = true;
            }
            _semaphore.Release();
            return stoppedWaiting;
        }

        public async Task AddPlayerToWaitingList(string userId, string? connectionId, int deckId, int elo)
        {

            PlayerInfo playerInfo = new PlayerInfo
            {
                userID = userId,
                ELO = elo,
                HeureJoin = DateTime.Now,
                deckID = deckId,
            };

            _listPlayerInfos.Add(playerInfo);
        }

    }
}


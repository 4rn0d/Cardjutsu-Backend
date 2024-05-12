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
        private string? _playerConnectionId = null;
        private SemaphoreSlim _semaphore;


        public string WaitingUserId { get { return _waitingUserId; } }

        public WaitingUserService()
        {
            _semaphore = new SemaphoreSlim(1);
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

        // Retourne null si il n'y a pas déjà un user qui attend pour jouer
        // Si non, on retourne la paire de Users
        public async Task<UsersReadyForAMatch?> LookForWaitingUser(string userId, int deckId, string? connectionId)
        {
            // Si c'est encore le même player qui attendait déjà, on retourne null
            if (_waitingUserId == userId)
                return null;

            await _semaphore.WaitAsync();

            // Aucun match en attente
            if (_waitingUserId == null)
            {
                _waitingUserId = userId;
                _waitingDeckId = deckId;
                _playerConnectionId = connectionId;
                _semaphore.Release();
                return null;
            }
            else
            {

                var matchCreationResult = new UsersReadyForAMatch(_waitingUserId, userId, _waitingDeckId, deckId, _playerConnectionId!);
                _waitingUserId = null;
                _waitingDeckId = 0;
                _playerConnectionId = null;
                _semaphore.Release();
                return matchCreationResult;


            }




        }

        //protected override Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    while (!stoppingToken.IsCancellationRequested)
        //    {
        //        await Task.Delay(DELAY, stoppingToken);
        //        await CreateELOAppropriateMatch(stoppingToken);
        //    }
        //}
    }
}


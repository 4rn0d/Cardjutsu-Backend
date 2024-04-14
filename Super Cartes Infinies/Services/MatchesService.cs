using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using System.Text.Json;

namespace Super_Cartes_Infinies.Services
{
	public class MatchesService : BaseService<Match>
    {
        private WaitingUserService _waitingUserService;
        private PlayersService _playersService;
        private CardsService _cardsService;
        private MatchConfigurationService _matchConfigurationService;

        public MatchesService(ApplicationDbContext context, WaitingUserService waitingUserService, PlayersService playersService, CardsService cardsService, MatchConfigurationService matchConfigurationService) : base(context)
        {
            _waitingUserService = waitingUserService;
            _playersService = playersService;
            _cardsService = cardsService;
            _matchConfigurationService = matchConfigurationService;
        }

        // Cette fonction est assez flexible car elle peut simplement être appeler lorsqu'un user veut jouer un match
        // Si le user a déjà un match en cours (Un match qui n'est pas terminé), on lui retourne l'information pour ce match
        // Sinon on utilise le WaitingUserService pour essayer de trouver un autre user ou nous mettre en attente
        public async Task<JoiningMatchData?> JoinMatch(string userId, int deckId, string? connectionId, int? specificMatchId)
        {
            // Vérifier si le match n'a pas déjà été démarré (de façon plus générale, retourner un match courrant si le joueur y participe)
            IEnumerable<Match> matches = db.Matches.Where(m => m.IsMatchCompleted == false && (m.UserAId == userId || m.UserBId == userId));

            if(matches.Count() > 1)
            {
                throw new Exception("A player should never be playing 2 matches at the same time!");
            }

            Match? match = null;
            Player? playerA = null;
            Player? playerB = null;
            string otherPlayerConnectionId = null;

            // Le joueur est dans un match en cours
            if (matches.Count() == 1)
            {
                match = matches.First();
                if(specificMatchId != null && specificMatchId != match.Id )
                {
                    match = null;
                }
                else
                {
                    playerA = _playersService.GetPlayerFromUserId(match.UserAId);
                    playerB = _playersService.GetPlayerFromUserId(match.UserBId);
                }
            }
            // Si on veut rejoindre un match en particulier, on ne se met pas en file
            else if(specificMatchId == null)
            {
                UsersReadyForAMatch? pairOfUsers = await _waitingUserService.LookForWaitingUser(userId, deckId, connectionId);

                if (pairOfUsers != null)
                {
                    playerA = _playersService.GetPlayerFromUserId(pairOfUsers.UserAId);
                    playerB = _playersService.GetPlayerFromUserId(pairOfUsers.UserBId);

                    // Création d'un nouveau match
                    IEnumerable<Card> cards = _cardsService.GetAll();
                    match = new Match(playerA, playerB, cards);
                    otherPlayerConnectionId = pairOfUsers.PlayerConnectionId;

                    Update(match);
                }
            }

            if (match != null)
            {
                return new JoiningMatchData
                {
                    Match = match,
                    PlayerA = playerA!,
                    PlayerB = playerB!,
                    OtherPlayerConnectionId = otherPlayerConnectionId,
                    // otherPlayerConnectionId est null seulement si c'est une partie qui existait deja
                    IsStarted = otherPlayerConnectionId == null
                };
            }

            return null;
        }

        public async Task<bool> StopJoiningMatch(string userId)
        {
            bool stoppedWaiting = await _waitingUserService.StopWaitingUser(userId);

            return stoppedWaiting;
        }

        // L'action retourne le json de l'event de création de match (StartMatchEvent)
        public async Task<string> StartMatch(string currentUserId, Match match)
        {
            if ((match.UserAId == currentUserId) != match.IsPlayerATurn)
                throw new Exception("Ce n'est pas le tour de ce joueur");

            MatchPlayerData currentPlayerData;
            MatchPlayerData opposingPlayerData;

            if (match.UserAId == currentUserId)
            {
                currentPlayerData = match.PlayerDataA;
                opposingPlayerData = match.PlayerDataB;
            }
            else
            {
                currentPlayerData = match.PlayerDataB;
                opposingPlayerData = match.PlayerDataA;
            }

            int nbStartingCards = _matchConfigurationService.GetNbStartingCards();
            int nbManaPerTurn = _matchConfigurationService.GetNbManaPerTurn();
            var startMatchEvent = new StartMatchEvent(match, currentPlayerData, opposingPlayerData, nbStartingCards, nbManaPerTurn);
            
            await db.SaveChangesAsync();

            return JsonSerializer.Serialize(startMatchEvent as MatchEvent);
        }

        public async Task<string> EndTurn(string userId, int matchId)
        {
            Match? match = await db.Matches.FindAsync(matchId);

            if (match == null)
                throw new Exception("Impossible de trouver le match");

            if (match.IsMatchCompleted)
                throw new Exception("Le match est déjà terminé");

            if (match.UserAId != userId && match.UserBId != userId)
                throw new Exception("Le joueur n'est pas dans ce match");

            if ((match.UserAId == userId) != match.IsPlayerATurn)
                throw new Exception("Ce n'est pas le tour de ce joueur");

            MatchPlayerData currentPlayerData;
            MatchPlayerData opposingPlayerData;

            if (match.UserAId == userId)
            {
                currentPlayerData = match.PlayerDataA;
                opposingPlayerData = match.PlayerDataB;
            }
            else
            {
                currentPlayerData = match.PlayerDataB;
                opposingPlayerData = match.PlayerDataA;
            }

            var playerTurnEvent = new PlayerEndTurnEvent(match, currentPlayerData, opposingPlayerData, _matchConfigurationService.GetNbManaPerTurn());



            await db.SaveChangesAsync();

            return JsonSerializer.Serialize(playerTurnEvent as MatchEvent);
        }

        public async Task<string> Surrender(string userId, int matchId)
        {
            Match? match = await db.Matches.FindAsync(matchId);

            if (match == null)
                throw new Exception("Impossible de trouver le match");

            if (match.IsMatchCompleted)
                throw new Exception("Le match est déjà terminé");

            if (match.UserAId != userId && match.UserBId != userId)
                throw new Exception("Le joueur n'est pas dans ce match");

            MatchPlayerData currentPlayerData;
            MatchPlayerData opposingPlayerData;

            if (match.UserAId == userId)
            {
                currentPlayerData = match.PlayerDataA;
                opposingPlayerData = match.PlayerDataB;
            }
            else
            {
                currentPlayerData = match.PlayerDataB;
                opposingPlayerData = match.PlayerDataA;
            }

            var playerTurnEvent = new SurrenderEvent(match, currentPlayerData, opposingPlayerData);

            await db.SaveChangesAsync();

            return JsonSerializer.Serialize(playerTurnEvent as MatchEvent);
        }
    }
}


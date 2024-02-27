using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerEndTurnEvent : MatchEvent
    {
        public MatchConfigurationService _matchConfigurationService;

        public int PlayerId { get; set; }
        // L'évènement lorsqu'un joueur termine son tour
        public PlayerEndTurnEvent(Match match, MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, MatchConfigurationService matchConfigurationService)
        {
            _matchConfigurationService = matchConfigurationService;
            this.PlayerId = currentPlayerData.PlayerId;
            this.Events = new List<MatchEvent>();

            match.IsPlayerATurn = !match.IsPlayerATurn;

            this.Events.Add(new PlayerStartTurnEvent(opposingPlayerData, _matchConfigurationService));
        }

    }
}

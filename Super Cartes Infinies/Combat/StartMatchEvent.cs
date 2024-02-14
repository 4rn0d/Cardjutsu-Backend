using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class StartMatchEvent : MatchEvent
    {
        public MatchConfigurationService _matchConfigurationService;

        public StartMatchEvent(Match match, MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int nbStartingCards, int nbManaPerTurn)
        {
            Events = new List<MatchEvent> { };

            for (int i = 0; i < _matchConfigurationService.GetNbStartingCards(); i++)
            {
                Events.Add(new PlayerStartTurnEvent(currentPlayerData));
            }
        }
    }
}

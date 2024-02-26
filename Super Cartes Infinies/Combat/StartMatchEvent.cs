using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class StartMatchEvent : MatchEvent
    {
        public MatchConfigurationService _matchConfigurationService;

        public StartMatchEvent(Match match, MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int nbStartingCards, int nbManaPerTurn, MatchConfigurationService matchConfigurationService)
        {
            _matchConfigurationService = matchConfigurationService;


            Events = new List<MatchEvent> { };

            for (int i = 0; i < _matchConfigurationService.GetNbStartingCards(); i++)
            {
                Events.Add(new PlayerStartTurnEvent(currentPlayerData, _matchConfigurationService));
                Events.Add(new PlayerStartTurnEvent(opposingPlayerData, _matchConfigurationService));
            }
            // Events.Add(new GainManaEvent(currentPlayerData, _matchConfigurationService.GetNbManaPerTurn()));
            // // On fait piger la carte de début de tour du premier joueur
            // Events.Add(new DrawCardEvent(currentPlayerData));
        }
    }
}

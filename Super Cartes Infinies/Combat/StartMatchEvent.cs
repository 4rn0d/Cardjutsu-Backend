using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class StartMatchEvent : MatchEvent
    {
        public StartMatchEvent(Match match, MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int nbStartingCards, int nbManaPerTurn)
        {
            Events = new List<MatchEvent> { };

            Events.Add(new PlayerStartTurnEvent(currentPlayerData));
        }
    }
}

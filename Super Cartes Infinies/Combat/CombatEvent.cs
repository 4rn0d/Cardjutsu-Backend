using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class CombatEvent : MatchEvent
    {
        public CombatEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData) 
        {
            this.Events = new List<MatchEvent> { };

            foreach(PlayableCard pc in currentPlayerData.BattleField.OrderByDescending(p => p.Id))
            {
                this.Events.Add(new CardActivationEvent(currentPlayerData, pc, opposingPlayerData));
            }

        }

    }
}

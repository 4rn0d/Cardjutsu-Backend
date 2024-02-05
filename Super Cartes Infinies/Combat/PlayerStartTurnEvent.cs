using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerStartTurnEvent : MatchEvent
    {
        public int PlayerId { get; set; }
        // L'évènement lorsqu'un joueur débutte son tour
        public PlayerStartTurnEvent(MatchPlayerData playerData)
        {
            this.PlayerId = playerData.PlayerId;
            this.Events = new List<MatchEvent>();

            // TODO: Faire piger les cartes
            // TODO: Faire gagner le Mana
        }

    }
}

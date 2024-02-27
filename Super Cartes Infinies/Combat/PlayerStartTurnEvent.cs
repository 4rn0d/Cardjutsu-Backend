using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerStartTurnEvent : MatchEvent
    {
        public int PlayerId { get; set; }
        // L'évènement lorsqu'un joueur débutte son tour
        public PlayerStartTurnEvent(MatchPlayerData playerData, int manaPerTurn)
        {
            this.PlayerId = playerData.PlayerId;
            this.Events = new List<MatchEvent>();

            // TODO: Faire piger les cartes
            Events.Add(new DrawCardEvent(playerData));
            // TODO: Faire gagner le Mana
            Events.Add(new GainManaEvent(playerData, manaPerTurn));
        }

    }
}

using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class FirstStrikeEvent : MatchEvent
    {
        public int PlayerId { get; set; }
        public int PlayableCardId { get; set; }
        public FirstStrikeEvent(MatchPlayerData playerDataAttacked, PlayableCard playableCardAttacked, PlayableCard opposingCard)
        {
            this.Events = new List<MatchEvent> { };
            this.PlayableCardId = playableCardAttacked.Id;
            this.PlayerId = playerDataAttacked.PlayerId;

            this.Events.Add(new CardDamageEvent(playerDataAttacked, playableCardAttacked, opposingCard));

        }

    }
}

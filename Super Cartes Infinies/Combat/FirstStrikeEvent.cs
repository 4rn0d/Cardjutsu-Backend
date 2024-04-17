using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class FirstStrikeEvent : MatchEvent
    {
        public FirstStrikeEvent(MatchPlayerData playerDataAttacked, PlayableCard playableCardAttacked, PlayableCard opposingCard)
        {
            this.Events = new List<MatchEvent> { };

            this.Events.Add(new CardDamageEvent(playerDataAttacked, playableCardAttacked, opposingCard));

        }

    }
}

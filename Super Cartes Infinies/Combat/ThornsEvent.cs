using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class ThornsEvent : MatchEvent
    {

        public ThornsEvent(MatchPlayerData playerData, PlayableCard playableCard, PlayableCard opposingCard)
        {
            this.Events = new List<MatchEvent> { };

            opposingCard.Attack += playableCard.GetPowerValue(Power.THORNS_ID);

            this.Events.Add(new CardDamageEvent(playerData, playableCard, opposingCard));
        }

    }
}

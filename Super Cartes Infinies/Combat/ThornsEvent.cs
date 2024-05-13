using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class ThornsEvent : MatchEvent
    {

        public int PlayerId { get; set; }
        public int PlayableCardId { get; set; }

        public ThornsEvent(MatchPlayerData playerData, PlayableCard playableCard, PlayableCard opposingCard)
        {
            this.Events = new List<MatchEvent> { };

            this.PlayerId = playerData.PlayerId;
            this.PlayableCardId = playableCard.Id;
            int damage = playableCard.GetPowerValue(Power.THORNS_ID);

            playableCard.Health -= damage;

            this.Events.Add(new CardDamageEvent(playerData, opposingCard, playableCard));
        }

    }
}

using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class CardDamageEvent : MatchEvent
    {

        public int PlayerId { get; set; }

        public int PlayableCardId { get; set; }

        public int OpposingCardId { get; set; }

        public int Damage { get; set; }

        public CardDamageEvent(MatchPlayerData playerData, PlayableCard playableCard, PlayableCard opposingCard)
        {

            this.Events = new List<MatchEvent>();
            this.PlayerId = playerData.PlayerId;
            this.PlayableCardId = playableCard.Id;
            this.Damage = opposingCard.Attack;
            this.OpposingCardId = opposingCard.Id;


            playableCard.Health -= opposingCard.Attack;

            if(playableCard.Health <= 0)
            {
                this.Events.Add(new CardDeathEvent(playerData, playableCard));
            }


        }

    }
}

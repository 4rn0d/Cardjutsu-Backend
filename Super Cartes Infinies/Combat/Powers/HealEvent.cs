using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class HealEvent : MatchEvent
    {
        public int PlayerId { get; set; }
        public int PlayableCardId { get; set; }
        public HealEvent(MatchPlayerData playerData, PlayableCard playableCard)
        {

            this.PlayerId = playerData.PlayerId;
            this.PlayableCardId = playableCard.Id;
            int healAmount = playableCard.GetPowerValue(Power.HEAL_ID);
            foreach (PlayableCard pc in playerData.BattleField)
            {
                if (pc.Health + healAmount <= pc.Card.Health)
                {
                    pc.Health += healAmount;
                }
                else
                {
                    pc.Health = pc.Card.Health;
                }
            }
        }

    }
}

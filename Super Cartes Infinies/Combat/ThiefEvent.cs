using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class ThiefEvent : MatchEvent
    {
        public int PlayerId { get; set; }
        public int PlayableCardId { get; set; }
        public ThiefEvent(MatchPlayerData playerData, PlayableCard card, MatchPlayerData enemyData) 
        {
            int stolenMana = card.GetPowerValue(Power.THIEF_ID);
            this.PlayableCardId = card.Id;
            this.PlayerId = playerData.PlayerId;

            if (enemyData.Mana < stolenMana)
            {
                stolenMana = enemyData.Mana;
                enemyData.Mana = 0;
                playerData.Mana += stolenMana;
            }
            else
            {
                enemyData.Mana -= stolenMana;
                playerData.Mana += stolenMana;
            }


        }
    }
}

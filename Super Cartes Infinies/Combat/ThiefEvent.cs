using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class ThiefEvent : MatchEvent
    {
        public ThiefEvent(MatchPlayerData playerData, PlayableCard card, MatchPlayerData enemyData) 
        {
            int stolenMana = card.GetPowerValue(Power.THIEF_ID);

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

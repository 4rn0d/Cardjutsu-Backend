using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class HealEvent : MatchEvent
    {
        public HealEvent(MatchPlayerData playerData, int healAmount) 
        {
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

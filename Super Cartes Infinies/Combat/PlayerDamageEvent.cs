using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerDamageEvent : MatchEvent
    {

        public int PlayerId { get; set; }

        public int Damage { get; set; }

        public PlayerDamageEvent(MatchPlayerData attackedPlayerData, int damage, MatchPlayerData attackingPlayerData) 
        {

            this.Events = new List<MatchEvent>();
            this.PlayerId = attackedPlayerData.PlayerId;
            this.Damage = damage;

            attackedPlayerData.Health -= damage;

            if(attackedPlayerData.Health <= 0)
            {
                this.Events.Add(new PlayerDeathEvent(attackedPlayerData, attackingPlayerData));
            }
        }

    }
}

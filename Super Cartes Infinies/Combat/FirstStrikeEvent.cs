using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class FirstStrikeEvent : MatchEvent
    {
        public FirstStrikeEvent(MatchPlayerData playerData, PlayableCard playableCard, int amountAttack) 
        {
            this.Events = new List<MatchEvent> { };

            this.Events.Add(new CardDamageEvent(playerData, playableCard, playableCard.Attack));

            if (playableCard.Health == 0) //if enemyCard is ded
            {
                this.Events.Add(new CardDeathEvent(playerData, playableCard));
            }
        }

    }
}

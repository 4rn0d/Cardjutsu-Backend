using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class ThornsEvent : MatchEvent
    {

        public ThornsEvent(MatchPlayerData playerData, PlayableCard playableCard, int attack) 
        {
            this.Events = new List<MatchEvent> { };

            this.Events.Add(new CardDamageEvent(playerData, playableCard, attack));
        }

    }
}

using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayCardEvent : MatchEvent
    {

        // TODO: Ajouter tout ce qui manque
        public PlayCardEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int playableCardId)
        {
            Events = new List<MatchEvent>();

            PlayableCard playedcard = currentPlayerData.Hand.Where(c => c.Id == playableCardId).FirstOrDefault();

            currentPlayerData.BattleField.Add(playedcard);

            currentPlayerData.Mana -= playedcard.Card.Cost;


            //if(playedcard.Health == 0)
            //{
            //    currentPlayerData.BattleField.Remove(playedcard);
            //    currentPlayerData.Graveyard.Add(playedcard);
            //}


            
            
        }
    }
}

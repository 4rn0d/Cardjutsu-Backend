using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayCardEvent : MatchEvent
    {

        // TODO: Ajouter tout ce qui manque
        public PlayCardEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int playableCardId)
        {
            PlayableCard playedcard = currentPlayerData.Hand.Where(c => c.Id == playableCardId).FirstOrDefault();

            if (currentPlayerData.Mana - playedcard.Card.Cost <0)
            {
                throw new Exception("Le joueur n'a pas assez de mana pour jouer la carte");
            }
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

using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayCardEvent : MatchEvent
    {

        // TODO: Ajouter tout ce qui manque

        public int PlayableCardId { get; set; }
        public int PlayerId { get; set; }
        public int Mana {get; set;}
        public int OrderId { get; set;}
         public PlayCardEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int playableCardId)
        {
            PlayableCard playedcard = currentPlayerData.Hand.Where(c => c.Id == playableCardId).FirstOrDefault();

            if (currentPlayerData.Mana - playedcard.Card.Cost >= 0)
            {
                currentPlayerData.AddCardToBattleField(playedcard);//pour mettre le order des index
                currentPlayerData.Hand.Remove(playedcard);
                currentPlayerData.Mana -= playedcard.Card.Cost;
                PlayerId = currentPlayerData.PlayerId;
                PlayableCardId = playedcard.Id;
                Mana = currentPlayerData.Mana;
                OrderId = playedcard.OrdreId;
               
            }
            else
            {
                throw new Exception("Le joueur n'a pas assez de mana pour jouer la carte");
            }

        }
    }
}

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
         public PlayCardEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int playableCardId)
        {
            PlayableCard playedcard = currentPlayerData.Hand.Where(c => c.Id == playableCardId).FirstOrDefault();

            if (currentPlayerData.Mana - playedcard.Card.Cost >= 0)
            {
                PlayerId = currentPlayerData.PlayerId;
                PlayableCardId = playedcard.Id;
                Mana = currentPlayerData.Mana - playedcard.Card.Cost;
                currentPlayerData.BattleField.Add(playedcard);
                currentPlayerData.Hand.Remove(playedcard);
                currentPlayerData.Mana -= playedcard.Card.Cost;
            }
            else
            {
                throw new Exception("Le joueur n'a pas assez de mana pour jouer la carte");
            }

        }
    }
}

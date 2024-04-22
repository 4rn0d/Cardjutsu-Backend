using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class CardDeathEvent : MatchEvent
    {

        public int PlayerId { get; set; }

        public int PlayableCardId { get; set; }

        public CardDeathEvent(MatchPlayerData playerData, PlayableCard playableCard) 
        {


            this.PlayerId = playerData.PlayerId;
            this.PlayableCardId = playableCard.Id;

            playerData.RemoveCardFromBattleField(playableCard);
            playerData.Graveyard.Add(playableCard);
        }
    }
}

using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class CardActivationEvent : MatchEvent
    {
        public int PlayerId { get; set; }

        public int PlayableCardId { get; set; }

        public CardActivationEvent(MatchPlayerData currentPlayerData, PlayableCard activatedCard, MatchPlayerData opposingPlayerData) 
        {

            this.Events = new List<MatchEvent> { };
            this.PlayerId = currentPlayerData.PlayerId;
            this.PlayableCardId = activatedCard.Id;

            int indexCardCurrentPlayer = currentPlayerData.BattleField.IndexOf(activatedCard);

            bool hasEnemyCardSameIndex = opposingPlayerData.BattleField[indexCardCurrentPlayer] != null;

            if (activatedCard.HasPower(Power.HEAL_ID))
            {
                int amountHeal = activatedCard.GetPowerValue(Power.HEAL_ID);
                foreach(PlayableCard pc in currentPlayerData.BattleField)
                {
                    if(pc.Health +  amountHeal <= pc.Card.Health)
                    {
                        pc.Health += amountHeal;
                    }
                    else
                    {
                        pc.Health = pc.Card.Health;
                    }
                }
            }
            

            if (hasEnemyCardSameIndex) // there is enemy card
            {
                PlayableCard enemyCard = opposingPlayerData.BattleField[indexCardCurrentPlayer];

                if (activatedCard.HasPower(Power.FIRST_STRIKE_ID)) // if current card has first strike
                {
                    this.Events.Add(new CardDamageEvent(opposingPlayerData, enemyCard, activatedCard.Attack));
                    if(enemyCard.Health != 0) //if enemyCard is still alive
                    {
                        //enemy defends

                    }
                }
                else
                {

                }

                if (enemyCard.HasPower(Power.THORNS_ID))
                {
                    this.Events.Add(new CardDamageEvent(currentPlayerData,activatedCard, enemyCard.GetPowerValue(Power.THORNS_ID)));
                }

                this.Events.Add(new CardDamageEvent(opposingPlayerData, enemyCard, activatedCard.Attack));
                this.Events.Add(new CardDamageEvent(currentPlayerData, activatedCard, enemyCard.Attack));
            }
            else
            {
                //ADD PLAYERDAMAGEEVENT TO EVENTS WITH ENEMY PLAYER
                this.Events.Add(new PlayerDamageEvent(opposingPlayerData, activatedCard.Attack, currentPlayerData));
            }
            
        }
    }
}

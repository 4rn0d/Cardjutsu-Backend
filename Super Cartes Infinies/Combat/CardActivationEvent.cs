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

            if (activatedCard.HasPower(Power.HEAL_ID)) //if current card has healing
            {
                int amountHeal = activatedCard.GetPowerValue(Power.HEAL_ID);
                this.Events.Add(new HealEvent(currentPlayerData, amountHeal));
            }
            

            if (hasEnemyCardSameIndex) // there is enemy card
            {
                PlayableCard enemyCard = opposingPlayerData.BattleField[indexCardCurrentPlayer];

                if (activatedCard.HasPower(Power.FIRST_STRIKE_ID)) // if current card has first strike
                {
                    this.Events.Add(new FirstStrikeEvent(opposingPlayerData, enemyCard, activatedCard.Attack));

                }

                if (enemyCard.HasPower(Power.THORNS_ID))
                {
                    this.Events.Add(new CardDamageEvent(currentPlayerData,activatedCard, enemyCard.GetPowerValue(Power.THORNS_ID)));

                    if (activatedCard.Health == 0) //if currentCard is ded
                    {
                        this.Events.Add(new CardDeathEvent(currentPlayerData, activatedCard));
                        return;

                    }
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

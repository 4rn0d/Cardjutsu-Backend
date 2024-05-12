using Microsoft.CodeAnalysis.CSharp.Syntax;
using Super_Cartes_Infinies.Models;
using System;

namespace Super_Cartes_Infinies.Combat
{
    public class CardActivationEvent : MatchEvent
    {
        public int PlayerId { get; set; }

        public int PlayableCardId { get; set; }

        public bool Thorns(MatchPlayerData enemy,PlayableCard enemyCard, MatchPlayerData attacked, PlayableCard attackedCard)
        {

            if (enemyCard.HasPower(Power.THORNS_ID))
            {
                //this.Events.Add(new ThornsEvent(currentPlayerData,activatedCard, enemyCard.GetPowerValue(Power.THORNS_ID)));

                this.Events.Add(new ThornsEvent(attacked, attackedCard, enemyCard));


                if (attackedCard.Health > 0)
                {
                    bool hasFS = FirstStrike(enemy, enemyCard, attackedCard, attacked);

                    if (!hasFS)
                    {
                        NormalFight(attacked, attackedCard, enemy, enemyCard);
                    }
                }

                return true;



            }

            return false;
            
        }

        public bool FirstStrike(MatchPlayerData attacked, PlayableCard attackedCard, PlayableCard attackerCard, MatchPlayerData attacker)
        {

            if (attackedCard.HasPower(Power.FIRST_STRIKE_ID)) // if current card has first strike
            {
               this.Events.Add(new FirstStrikeEvent(attacked, attackedCard, attackerCard));

                if (attackerCard.Health > 0)
                {
                    this.Events.Add(new CardDamageEvent(attacker, attackerCard, attackedCard));
                }

                return true;

            }

            return false;
            
        }

        public void NormalFight(MatchPlayerData enemy, PlayableCard enemyCard, MatchPlayerData current, PlayableCard currentCard)
        {
            
            this.Events.Add(new CardDamageEvent(current, currentCard, enemyCard));
            this.Events.Add(new CardDamageEvent(enemy, enemyCard, currentCard));
        }

        

        public CardActivationEvent(Match match, MatchPlayerData currentPlayerData, PlayableCard activatedCard, MatchPlayerData opposingPlayerData) 
        {

            this.Events = new List<MatchEvent> { };
            this.PlayerId = currentPlayerData.PlayerId;
            this.PlayableCardId = activatedCard.Id;

            int indexCardCurrentPlayer = currentPlayerData.BattleField.IndexOf(activatedCard);

            bool hasEnemyCardSameIndex = false;

            if (opposingPlayerData.BattleField != null && opposingPlayerData.BattleField.Count != 0 && indexCardCurrentPlayer< opposingPlayerData.BattleField.Count)
            {
                hasEnemyCardSameIndex = opposingPlayerData.BattleField[indexCardCurrentPlayer] != null;
            }

            if (activatedCard.HasPower(Power.CHAOS_ID))
            {

                for (int i = 0; i < currentPlayerData.BattleField.Count; i++)
                {
                    this.Events.Add(new ChaosEvent(currentPlayerData, currentPlayerData.BattleField[i]));
                }
                for (int i = 0; i < opposingPlayerData.BattleField!.Count; i++)
                {
                    this.Events.Add(new ChaosEvent(opposingPlayerData, opposingPlayerData.BattleField[i]));
                }
            }

            if (activatedCard.HasPower(Power.RESURRECT_ID))
            {
                this.Events.Add(new ResurrectEvent(currentPlayerData, activatedCard, match));
            }

            if (activatedCard.HasPower(Power.BOOST_ATTACK_ID)) //if current card has boost attack
            {
                foreach (var playableCard in currentPlayerData.BattleField)
                {
                    this.Events.Add(new BoostAttackEvent(currentPlayerData, playableCard, activatedCard.GetPowerValue(Power.BOOST_ATTACK_ID)));
                }
            }

            if (activatedCard.HasPower(Power.HEAL_ID)) //if current card has healing
            {
                this.Events.Add(new HealEvent(currentPlayerData, activatedCard));
            }
            

            if (hasEnemyCardSameIndex) // there is enemy card
            {
                PlayableCard enemyCard = opposingPlayerData.BattleField[indexCardCurrentPlayer];

                bool enemyThorns = Thorns(opposingPlayerData, enemyCard, currentPlayerData, activatedCard);
                bool currentFS = FirstStrike(opposingPlayerData, enemyCard, activatedCard, currentPlayerData);

                if(!currentFS && !enemyThorns)
                {
                    NormalFight(opposingPlayerData, enemyCard, currentPlayerData, activatedCard);
                }

            }
            else
            {
                //ADD PLAYERDAMAGEEVENT TO EVENTS WITH ENEMY PLAYER
                this.Events.Add(new PlayerDamageEvent(match, opposingPlayerData, activatedCard, currentPlayerData));
            }

            if (activatedCard.HasPower(Power.THIEF_ID))
            {
                this.Events.Add(new ThiefEvent(currentPlayerData, activatedCard, opposingPlayerData));
            }

        }
    }
}

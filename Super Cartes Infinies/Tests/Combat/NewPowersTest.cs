﻿using Moq;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;
using Tests.Services;

namespace Super_Cartes_Infinies.Tests.Combat
{
    [TestClass]
    public class NewPowersTest : BaseTests
    {

        [TestInitialize]
        public void Init()
        {
            base.Init();
        }

        [TestMethod]
        public void BoostAttackTest()
        {

            Power boostAttackPower = new Power
            {
                PowerId = Power.BOOST_ATTACK_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = boostAttackPower,
                Value = 2,
                Card = _cardA
            };

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();
            _playableCardC.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.BattleField.Add(_playableCardA);
            _currentPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(_playableCardC);

            int baseAttackA = _cardA.Attack;
            int baseAttackB = _cardB.Attack;
            int baseAttackC = _cardC.Attack;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.AreEqual(baseAttackA + cardPower.Value, _playableCardA.Attack);
            Assert.AreEqual(baseAttackB + cardPower.Value, _playableCardB.Attack);
            Assert.AreEqual(baseAttackC, _playableCardC.Attack);
        }

        [TestMethod]
        public void ChaosTest()
        {
            Power chaosPower = new Power
            {
                PowerId = Power.CHAOS_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = chaosPower,
                Card = _cardA
            };

            Card dyingCard = new Card
            {
                Id = 2,
                Name = "Dying Card",
                Attack = 0,
                Health = 1,
            };

            PlayableCard dyingPlayableCard = new PlayableCard(dyingCard);

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();
            dyingPlayableCard.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(dyingPlayableCard);

            int cardABaseAttack = _cardA.Attack;
            int cardABaseHealth = _cardA.Health;
            int cardBBaseAttack = _cardB.Attack;
            int cardBBaseHealth = _cardB.Health;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.AreEqual(cardABaseAttack, _playableCardA.Health + _playableCardB.Attack);
            Assert.AreEqual(cardABaseHealth, _playableCardA.Attack);
            Assert.AreEqual(cardBBaseAttack, _playableCardB.Health + _playableCardA.Attack);
            Assert.AreEqual(cardBBaseHealth, _playableCardB.Attack);
            Assert.IsTrue(_opposingPlayerData.Graveyard.Contains(dyingPlayableCard));
        }

        [TestMethod]
        public void ResurectTest()
        {

            Power chaosPower = new Power
            {
                PowerId = Power.RESURRECT_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = chaosPower,
                Card = _cardA
            };

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();
            _playableCardC.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.BattleField.Add(_playableCardA);
            _currentPlayerData.Graveyard.Add(_playableCardB);

            _opposingPlayerData.BattleField.Add(_playableCardC);

            Mock<IRandomNumberService> randomNumberServiceMock = new Mock<IRandomNumberService>();

            randomNumberServiceMock.Setup(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);
            //Associer au match
            _match.RandomNumberService = randomNumberServiceMock.Object;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            // TODO : Vérif que le joueur na pas prit de damage
            Assert.IsTrue(_currentPlayerData.BattleField.Contains(_playableCardB));
            Assert.IsFalse(_currentPlayerData.Graveyard.Contains(_playableCardB));
            Assert.AreEqual(1, _playableCardB.Health);
            // int random = randomNumberServiceMock.Object.GetRandomNumber(0, _currentPlayerData.Graveyard.Count);
            // Assert.AreEqual(1, _currentPlayerData.BattleField[random].Health);
        }

        [TestMethod]
        public void PoisonStatusTest()
        {
            Power poisonPower = new Power
            {
                PowerId = Power.POISON_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = poisonPower,
                Value = 2,
                Card = _cardA
            };

            _playableCardA.Attack = 0;
            _playableCardB.Attack = 0;

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            int startingHealthB = _playableCardB.Health;

            var playerEndTurnEvent1 = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            if (_playableCardB.CardStatuses.Count == 0)
            {
                Assert.Fail();
            }
            else
            {
                Assert.IsTrue(_playableCardB.HasStatus(Status.POISONED_ID));
                Assert.AreEqual(cardPower.Value, _playableCardB.GetStatusValue(Status.POISONED_ID));
            }

            var playerEndTurnEvent2 = new PlayerEndTurnEvent(_match, _opposingPlayerData, _currentPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_playableCardB.HasStatus(Status.POISONED_ID));
            Assert.AreEqual(startingHealthB - cardPower.Value - cardPower.Value, _playableCardB.Health);
            Assert.AreEqual(cardPower.Value + cardPower.Value, _playableCardB.GetStatusValue(Status.POISONED_ID));

        }

        [TestMethod]
        public void StunStatusTest()
        {
            Power stunPower = new Power
            {
                PowerId = Power.STUN_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = stunPower,
                Value = 2,
                Card = _cardA
            };

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);
            // TODO : Faire en sorte que la carteA meurt et un stun de 1

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_playableCardB.HasStatus(Status.STUNNED_ID));

            //Vérifier quelle ne fait pas de damage
            if (_playableCardB.CardStatuses.Count == 0)
            {
                Assert.Fail();
            }
            else
            {
                Assert.IsTrue(_playableCardB.HasStatus(Status.STUNNED_ID));
                Assert.AreEqual(cardPower.Value, _playableCardB.GetStatusValue(Status.STUNNED_ID));
            }

            var playerEndTurnEvent2 = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_currentPlayerData.Health > 0);
            Assert.AreEqual(cardPower.Value - 1, _playableCardB.GetStatusValue(Status.STUNNED_ID));

        }

        [TestMethod]
        public void LightningStrikeSpellTest()
        {
            Power lightingStrikePower = new Power
            {
                PowerId = Power.LIGHTNING_STRIKE_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = lightingStrikePower,
                Value = 2,
                Card = _cardA
            };

            _cardA.IsSpell = true;

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.Hand.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            int startingHealth = _opposingPlayerData.Health;

            var playCardEvent = new PlayCardEvent(_currentPlayerData, _opposingPlayerData, _playableCardA.Id);

            Assert.IsTrue(_currentPlayerData.Graveyard.Contains(_playableCardA));
            Assert.AreEqual( startingHealth - cardPower.Value, _opposingPlayerData.Health);

        }

        [TestMethod]
        public void EarthquakeSpellTest()
        {
            Power earthquakePower = new Power
            {
                PowerId = Power.EARTHQUAKE_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = earthquakePower,
                Value = 2,
                Card = _cardA
            };

            _cardA.IsSpell = true;

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();
            _playableCardC.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.Hand.Add(_playableCardA);
            _currentPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(_playableCardC);

            int startingHealthA = _playableCardA.Health;
            int startingHealthB = _playableCardB.Health;
            int startingHealthC = _playableCardC.Health;

            var playerEndTurnEvent = new PlayCardEvent(_currentPlayerData, _opposingPlayerData, _playableCardA.Id);

            Assert.IsTrue(_currentPlayerData.Graveyard.Contains(_playableCardA));
            Assert.AreEqual(startingHealthA - cardPower.Value, _playableCardA.Health);
            Assert.AreEqual(startingHealthB - cardPower.Value, _playableCardB.Health);
            Assert.AreEqual(startingHealthC - cardPower.Value, _playableCardC.Health);

        }

        [TestMethod]
        public void RandomPainSpellTest()
        {

            Mock<IRandomNumberService> randomNumberServiceMock = new Mock<IRandomNumberService>();

            randomNumberServiceMock.SetupSequence(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(4)
                .Returns(2)
                .Returns(1);

            Power randomPainPower = new Power
            {
                PowerId = Power.RANDOM_PAIN_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = randomPainPower,
                Value = 2,
                Card = _cardA
            };

            _cardA.IsSpell = true;

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _playableCardA.CardStatuses = new List<PlayableCardStatus>();
            _playableCardB.CardStatuses = new List<PlayableCardStatus>();
            _playableCardC.CardStatuses = new List<PlayableCardStatus>();

            _currentPlayerData.Hand.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(_playableCardC);

            var playerEndTurnEvent = new PlayCardEvent(_currentPlayerData, _opposingPlayerData, _playableCardA.Id);

            Assert.IsTrue(_currentPlayerData.Graveyard.Contains(_playableCardA));
            Assert.IsFalse(_currentPlayerData.BattleField.Contains(_playableCardA));

            for (int i = 0; i < _opposingPlayerData.BattleField.Count; i++)
            {
                if (i == randomNumberServiceMock.Object.GetRandomNumber(1, _opposingPlayerData.BattleField.Count))
                {
                    randomNumberServiceMock.Verify(randomNumberMethod =>
                        randomNumberMethod.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeast(1));
                    Assert.AreEqual(10 - _playableCardA.Attack, _opposingPlayerData.BattleField[i].Health);
                    Assert.AreEqual(_playableCardB, _opposingPlayerData.BattleField[i]);
                }
            }

        }
    }
}


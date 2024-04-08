using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Models;

namespace Tests.Services
{
    [TestClass]
    public class PowerTests : BaseTests
	{
        public PowerTests()
        {
        }

        [TestInitialize]
        public void Init()
        {
            base.Init();
        }

        [TestMethod]
        public void FirstStrikeAttacks()
        {
            Power firstStrikePower = new Power
            {
                Id = Power.FIRST_STRIKE_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = firstStrikePower,
                Card = _cardA
            };

            _cardA.CardPowers = new List<CardPower> { cardPower };

            // On reduit le Heatlh pour que la carte meurt
            _playableCardB.Health = 2;

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            Assert.AreEqual(3, _playableCardA.Health);
            Assert.AreEqual(0, _playableCardB.Health);
        }

        [TestMethod]
        public void FirstStrikeAttackWithoutKill()
        {
            Power firstStrikePower = new Power
            {
                Id = Power.FIRST_STRIKE_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = firstStrikePower,
                Card = _cardA
            };

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            // FirstStrike n'a aucun effet si l'attaquant ne tue pas le défenseur
            Assert.AreEqual(_cardA.Health - _playableCardB.Attack, _playableCardA.Health);
            Assert.AreEqual(_cardB.Health - _playableCardA.Attack, _playableCardB.Health);
        }

        [TestMethod]
        public void ThornsAttack()
        {
            Power thornsPower = new Power
            {
                Id = Power.THORNS_ID
            };

            // On donne le pouvoir Thorn au défenseur
            CardPower cardPower = new CardPower
            {
                Power = thornsPower,
                Card = _cardB,
                Value = 3
            };
            _cardB.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            Assert.AreEqual(1, _opposingPlayerData.Health);
            Assert.AreEqual(1, _currentPlayerData.Health);

            // On veut être certain que l'attaquant meurt par Thorns pendant le test
            Assert.IsTrue(_cardA.Health - cardPower.Value <= 0);

            Assert.AreEqual(_cardA.Health - cardPower.Value, _playableCardA.Health);
            Assert.AreEqual(_cardB.Health, _playableCardB.Health);

            AssertCurrentPlayerCardDied();
        }

        [TestMethod]
        public void Heal()
        {
            Power healPower = new Power
            {
                Id = Power.HEAL_ID
            };

            // On donne le pouvoir Heal à l'attaquant
            CardPower cardPower = new CardPower
            {
                Power = healPower,
                Card = _cardB,
                Value = 3
            };
            _cardA.CardPowers = new List<CardPower> { cardPower };

            var damagedPlayableCard = new PlayableCard(_cardB)
            {
                Id = 3
            };

            // On retire 2 PVs à l'attaquant et 4 PVs à l'autre carte de l'attaquant
            _playableCardA.Health -= 2;
            damagedPlayableCard.Health -= 4;

            _currentPlayerData.BattleField.Add(_playableCardA);
            _currentPlayerData.BattleField.Add(damagedPlayableCard);

            _opposingPlayerData.BattleField.Add(_playableCardB);

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            // _playableCardA devrait avoir retrouvé ses points de vie initiaux            
            Assert.AreEqual(_cardA.Health - _playableCardB.Attack, _playableCardA.Health);
            Assert.AreEqual(_cardB.Health - _playableCardA.Attack, _playableCardB.Health);

            // damagePlayableCard devrait avoir été guéri de 3 de ses 4 de dégâts
            Assert.AreEqual(_cardB.Health - 1, damagedPlayableCard.Health);

            // Le damagedPlayableCard tue le joueur adverse
            Assert.AreEqual(0, _opposingPlayerData.Health);
            Assert.AreEqual(1, _currentPlayerData.Health);

            // Toutes les cartes sont encore en jeu
            Assert.AreEqual(2, _currentPlayerData.BattleField.Count);
            Assert.AreEqual(0, _currentPlayerData.Graveyard.Count);
            Assert.AreEqual(1, _opposingPlayerData.BattleField.Count);
            Assert.AreEqual(0, _opposingPlayerData.Graveyard.Count);
        }

        [TestMethod]
        public void StealWithinEnemyManaLimit()
        {
            Power stealPower = new Power
            {
                Id = Power.THIEF_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = stealPower,
                Card = _cardB,
                Value = 1
            };

            _cardB.CardPowers = new List<CardPower> { cardPower };
            _opposingPlayerData.Mana = 3;
            _currentPlayerData.Mana = 3;

            _currentPlayerData.BattleField.Add(_playableCardB);

            int initialManaEnemy = _opposingPlayerData.Mana;
            int initialManaCurrent = _currentPlayerData.Mana;

            int manaPerRoundConf = 3; //HARDCODED

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            Assert.AreEqual(initialManaEnemy - cardPower.Value + manaPerRoundConf, _opposingPlayerData.Mana); //It checks AFTER we regained mana the following round
            Assert.AreEqual(initialManaCurrent + cardPower.Value, _currentPlayerData.Mana);
        }

        [TestMethod]
        public void StealOutsideEnemyManaLimit()
        {
            Power stealPower = new Power
            {
                Id = Power.THIEF_ID
            };

            CardPower cardPower = new CardPower
            {
                Power = stealPower,
                Card = _cardB,
                Value = 4
            };
            _cardB.CardPowers = new List<CardPower> { cardPower };

            _opposingPlayerData.Mana = 3;
            _currentPlayerData.Mana = 3;

            _currentPlayerData.BattleField.Add(_playableCardB);

            int initialManaEnemy = _opposingPlayerData.Mana;

            int initialManaCurrent = _currentPlayerData.Mana;

            int manaPerRoundConf = 3; //HARDCODED

            var playerTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData);

            Assert.AreEqual(_currentPlayerData.PlayerId, playerTurnEvent.PlayerId);

            Assert.AreEqual(manaPerRoundConf, _opposingPlayerData.Mana); //It checks AFTER we regained mana the following round
            Assert.AreEqual(initialManaCurrent + initialManaEnemy, _currentPlayerData.Mana);


        }
    }
}


using Moq;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;
using Tests.Services;

namespace Super_Cartes_Infinies.Tests.Combat
{
    [TestClass]
    public class NewPowersTest : BaseTests
    {
        public NewPowersTest()
        {
        }

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

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            //TODO : ajouter une deuxième cartes au currentPlayer et vérifier

            int baseAttack = _cardA.Attack;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.AreEqual(baseAttack + cardPower.Value, _playableCardA.Attack);
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

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);


            //TODO : Ajouter la mort d'une carte qui meurt dans le process

            int cardABaseAttack = _cardA.Attack;
            int cardABaseHealth = _cardA.Health;
            int cardBBaseAttack = _cardB.Attack;
            int cardBBaseHealth = _cardB.Health;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.AreEqual(cardABaseAttack, _playableCardA.Health);
            Assert.AreEqual(cardABaseHealth, _playableCardA.Attack);
            Assert.AreEqual(cardBBaseAttack, _playableCardB.Health);
            Assert.AreEqual(cardBBaseHealth, _playableCardB.Attack);
        }

        [TestMethod]
        public void ResurectTest()
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

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _currentPlayerData.Graveyard.Add(_playableCardB);

            _opposingPlayerData.BattleField.Add(_playableCardC);

            //Créer un mock IRandomNumberService
            var randomNumberServiceMock = new Mock<IRandomNumberService>();

            //Associer au match
            _match.RandomNumberService = randomNumberServiceMock.Object;

            //Setup pour que getRandom retourn 0
            randomNumberServiceMock.Setup(x => x.GetRandomNumber(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(0);

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);


            // TODO : Vérif que le joueur na pas prit de damage
            Assert.AreEqual(true, _currentPlayerData.BattleField.Contains(_playableCardB));
            Assert.AreEqual(false, _currentPlayerData.Graveyard.Contains(_playableCardB));
            Assert.AreEqual(1, _playableCardB.Health);
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

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            int startingHealthB = _playableCardB.Health;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_playableCardB.HasStatus(Status.POISONED_ID));
            Assert.AreEqual(startingHealthB - cardPower.Value, _playableCardB.Health);


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

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);
            // TODO : Faire en sorte que la carteA meurt et un stun de 1

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_playableCardB.HasStatus(Status.STUNNED_ID));

            var playerEndTurnEvent2 = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            //Vérifier quelle ne fait pas de damage


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

            // TODO : IsSpell à true

            _cardA.IsSpell = true;

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);

            int startingHealth = _opposingPlayerData.Health;

            //TODO : PlayCardEvent et non EndTurnEvent

            var PlayCardEvent = new PlayCardEvent(_currentPlayerData, _opposingPlayerData, _cardA.Id);

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

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _currentPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(_playableCardC);

            int startingHealthA = _playableCardA.Health;
            int startingHealthB = _playableCardB.Health;
            int startingHealthC = _playableCardC.Health;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_currentPlayerData.Graveyard.Contains(_playableCardA));
            Assert.AreEqual(startingHealthA - cardPower.Value, _playableCardA.Health);
            Assert.AreEqual(startingHealthB - cardPower.Value, _playableCardB.Health);
            Assert.AreEqual(startingHealthC - cardPower.Value, _playableCardC.Health);

        }

        [TestMethod]
        public void RandomPainSpellTest()
        {
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

            _cardA.CardPowers = new List<CardPower> { cardPower };

            _currentPlayerData.BattleField.Add(_playableCardA);
            _opposingPlayerData.BattleField.Add(_playableCardB);
            _opposingPlayerData.BattleField.Add(_playableCardC);

            int startingHealthB = _playableCardB.Health;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.IsTrue(_currentPlayerData.Graveyard.Contains(_playableCardA));
            Assert.AreNotEqual<int>(startingHealthB, _playableCardB.Health);

        }
    }
}


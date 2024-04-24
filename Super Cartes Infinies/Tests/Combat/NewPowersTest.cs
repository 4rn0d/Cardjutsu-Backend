using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Models;
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

            int baseAttack = _cardA.Attack;

            var playerEndTurnEvent = new PlayerEndTurnEvent(_match, _currentPlayerData, _opposingPlayerData, NB_MANA_PER_TURN);

            Assert.AreEqual(baseAttack + cardPower.Value, _playableCardA.Attack);
        }
    }
}


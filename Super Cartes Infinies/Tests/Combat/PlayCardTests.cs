using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Models;

namespace Tests.Services
{
    [TestClass]
    public class PlayCardTests : BaseTests
	{
        public PlayCardTests()
        {
        }

        [TestInitialize]
        public void Init()
        {
            base.Init();
        }

        [TestMethod]
        public void TryingToPlayCardWithoutEnougMana()
        {
            var currentPlayerData = new MatchPlayerData(1);
            var opposingPlayerData = new MatchPlayerData(2);

            // Une carte qui coûte vraiment très cher
            Card cardA = new()
            {
                Id = 42,
                Cost = 200
            };

            PlayableCard playableCardA = new(cardA)
            {
                Id = 1
            };

            // La carte est dans la main du joueur
            currentPlayerData.Hand.Add(playableCardA);

            var exception = Assert.ThrowsException<Exception>(() => new PlayCardEvent(currentPlayerData, opposingPlayerData, playableCardA.Id));
            Assert.AreEqual("Le joueur n'a pas assez de mana pour jouer la carte", exception.Message);
        }

        [TestMethod]
        public void PlayingACardWithEnougMana()
        {
            int startingMana = 3;
            var currentPlayerData = new MatchPlayerData(1)
            {
                Mana = startingMana
            };
            var opposingPlayerData = new MatchPlayerData(2);

            // Une carte qui coûte vraiment très cher
            Card cardA = new()
            {
                Id = 42,
                Cost = 2
            };

            PlayableCard playableCardA = new(cardA)
            {
                Id = 1
            };

            // La carte est dans la main du joueur
            currentPlayerData.Hand.Add(playableCardA);

            var exception = new PlayCardEvent(currentPlayerData, opposingPlayerData, playableCardA.Id);
            Assert.AreEqual(currentPlayerData.Mana, startingMana - cardA.Cost);
        }
    }
}


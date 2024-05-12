using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Tests.Elo
{
    [TestClass()]
    public class MatchmakingTests
    {
        [TestMethod()]
        public void SimilarEloReturnsPairedPlayers()
        {
            Player player1 = new Player
            {
                Id = 1,
                EloScore = 1010,
                Name = "p1",
            };

            Player player2 = new Player
            {
                Id = 2,
                EloScore = 1000,
                Name = "p2",
            };
        }

        [TestMethod()]
        public void DistantEloReturnsEmptyPair()
        {
            Player player1 = new Player
            {
                Id = 1,
                EloScore = 2010,
                Name = "p1",
            };

            Player player2 = new Player
            {
                Id = 2,
                EloScore = 1000,
                Name = "p2",
            };
        }

        [TestMethod()]
        public void ManyPlayersPairing()
        {
            Player player1 = new Player
            {
                Id = 1,
                EloScore = 1010,
                Name = "p1",
            };

            Player player2 = new Player
            {
                Id = 2,
                EloScore = 1000,
                Name = "p2",
            };

            Player player3 = new Player
            {
                Id = 3,
                EloScore = 610,
                Name = "p3",
            };

            Player player4 = new Player
            {
                Id = 4,
                EloScore = 2200,
                Name = "p4",
            };

            Player player5 = new Player
            {
                Id = 5,
                EloScore = 1510,
                Name = "p5",
            };

            Player player6 = new Player
            {
                Id = 6,
                EloScore = 1600,
                Name = "p6",
            };


        }
    }
}

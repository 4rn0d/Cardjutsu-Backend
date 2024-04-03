using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Cartes_Infinies.Services.Tests
{
    [TestClass()]
    public class DecksServiceTests
    {
        DbContextOptions<ApplicationDbContext> options;
        public DecksServiceTests()
        {
            options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "DecksService")
                .UseLazyLoadingProxies(true)
                .Options;
        }

        //[TestInitialize]
        //public void Init()
        //{
        //    // TODO avoir la durée de vie d'un context la plus petite possible
        //    using ApplicationDbContext db = new ApplicationDbContext(options);
        //    // TODO on ajoute des données de tests
        //    Card[] cards = new Card[] {
        // new Card
        //        {
        //            Id = 1,
        //            Name = "Cart Surfer",
        //            Attack = 3,
        //            Health = 3,
        //            Cost = 3,
        //            Colour = "Blue",
        //            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png"
        //        }, new Card
        //        {
        //            Id = 2,
        //            Name = "Coffee Shop",
        //            Attack = 2,
        //            Health = 3,
        //            Cost = 3,
        //            Colour = "Green",
        //            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png"
        //        }, new Card
        //        {
        //            Id = 3,
        //            Name = "Astro Barrier",
        //            Attack = 8,
        //            Health = 3,
        //            Cost = 3,
        //            Colour = "Green",
        //            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png"
        //        }, new Card
        //        {
        //            Id = 4,
        //            Name = "Hot Chocolate",
        //            Attack = 3,
        //            Health = 3,
        //            Cost = 3,
        //            Colour = "Orange",
        //            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png"
        //        }, new Card
        //        {
        //            Id = 5,
        //            Name = "Landing Pad",
        //            Attack = 4,
        //            Health = 3,
        //            Cost = 3,
        //            Colour = "Violet",
        //            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png"
        //        }
        //};

        //db.AddRange(cards);

        //    OwnedCard[] decks = new OwnedCard[] {
        // new OwnedCard
        //        {
        //            Id = 1,
        //            PlayerId = 1,
        //            Card =  cards[1],
        //            CardId = 1,
        //            decks = 1,

        //        }, new OwnedCard
        //        {
        //            Id = 2,
        //            PlayerId =1,
        //            Card = cards[0],
        //            CardId = cards,
        //            decks = 3,

        //        }
        //};

        //    Deck[] decks = new Deck[] {
        // new Deck
        //        {
        //            DeckId = 1,
        //            DeckName = "Cart Surfer",
        //            IsCurrentDeck = false,
        //            OwnedCards = 3,
        //            PlayerId = 1,

        //        }, new Deck
        //        {
        //            DeckId = 2,
        //            DeckName = "Coffee Shop",
        //            IsCurrentDeck = true,
        //            OwnedCards = cards,
        //            PlayerId = 3,

        //        }
        //};




        //    db.SaveChanges();



        //}
        [TestCleanup]
        public void Dispose()
        {
            //TODO on efface les données de tests pour remettre la BD dans son état initial
            using ApplicationDbContext db = new ApplicationDbContext(options);
            db.Decks.RemoveRange(db.Decks);
            db.SaveChanges();
        }


        [TestMethod()]
        public void GetDecksTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService( playersService, httpContextAccessor, db );
            Card c = new Card()
            {
                Id = 4,
            };
            service.GetDecks();
            Assert.AreEqual(4, db.Cards.Count());
        }

        [TestMethod()]
        public void DeleteDeckTest()
        {
            Assert.Fail();
        }
    }
}
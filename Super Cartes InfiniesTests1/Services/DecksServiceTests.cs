﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
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

        [TestInitialize]
        public void Init()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);

            // Ajoutez les cartes
            Card[] cards = new Card[] {
        new Card { Id = 1, Name = "Cart Surfer", Attack = 3, Health = 3, Cost = 3, Colour = "Blue", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png" },
        new Card { Id = 2, Name = "Coffee Shop", Attack = 2, Health = 3, Cost = 3, Colour = "Green", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png" },
        new Card { Id = 3, Name = "Astro Barrier", Attack = 8, Health = 3, Cost = 3, Colour = "Green", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png" },
        new Card { Id = 4, Name = "Hot Chocolate", Attack = 3, Health = 3, Cost = 3, Colour = "Orange", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png" },
        new Card { Id = 5, Name = "Landing Pad", Attack = 4, Health = 3, Cost = 3, Colour = "Violet", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png" }
    };

            db.AddRange(cards);

            // Ajoutez les OwnedCards
            List<OwnedCard> ownedCards = new List<OwnedCard>();
            foreach (var card in cards)
            {
                ownedCards.Add(new OwnedCard { PlayerId = 1, CardId = card.Id });
            }

            db.AddRange(ownedCards);

            // Ajoutez les Decks
            List<Deck> decks = new List<Deck>
    {
        new Deck { DeckName = "Cart", IsCurrentDeck = false, OwnedCards = ownedCards.Where(oc => oc.CardId == 1 || oc.CardId == 2).ToList(), PlayerId = 1 },
        new Deck { DeckName = "Coffee", IsCurrentDeck = true, OwnedCards = ownedCards.Where(oc => oc.CardId == 3 || oc.CardId == 4 || oc.CardId == 5).ToList(), PlayerId = 1 }
    };

            db.AddRange(decks);

            db.SaveChanges();
        }
        [TestCleanup]
        public void Dispose()
        {
            //TODO on efface les données de tests pour remettre la BD dans son état initial
            using ApplicationDbContext db = new ApplicationDbContext(options);
            db.Decks.RemoveRange(db.Decks);
            db.SaveChanges();
        }


        [TestMethod()]
        public async void GetDecksTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);


            List<Deck> decks = await service.GetDecks();

            Assert.AreEqual(4, db.Cards.Count());
        }

        [TestMethod()]
        public void DeleteDeckTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);
            service.DeleteDeck(0);
            Deck? deck = db.Decks.Where(x => x.Id == 0).FirstOrDefault();
            Assert.IsNull(deck);
        }

        [TestMethod()]
        public void MakeCurrentDeckTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck? deckTest = db.Decks.Where(x => x.Id == 0).FirstOrDefault();
            Deck? deckTest2 = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            service.MakeCurrentDeck(deckTest.Id);
            Assert.AreEqual(true, deckTest.IsCurrentDeck);
            Assert.AreEqual(false, deckTest2.IsCurrentDeck);
            //pour tester qu'on peut changer le IsCurrentDeck et qu'il en a juste un. 
            service.MakeCurrentDeck(deckTest2.Id);
            Assert.AreEqual(false, deckTest.IsCurrentDeck);
            Assert.AreEqual(true, deckTest2.IsCurrentDeck);
        }

        [TestMethod()]
        public void PostDeckTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck deckAjouter = new Deck()
            {
                DeckName = "DeckTestNiki",
                IsCurrentDeck = false,
                OwnedCards = new List<OwnedCard>(),
                PlayerId = 1,
            };
            List<Card> cards = new List<Card>()
            {
                 new Card
            {
                Id = 1,
                Name = "Cart Surfer",
                Attack = 3,
                Health = 3,
                Cost = 3,
                Colour = "Blue",
                ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png"
            }, new Card
            {
                Id = 2,
                Name = "Coffee Shop",
                Attack = 2,
                Health = 3,
                Cost = 3,
                Colour = "Green",
                ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png"
            }, new Card
            {
                Id = 3,
                Name = "Astro Barrier",
                Attack = 8,
                Health = 3,
                Cost = 3,
                Colour = "Green",
                ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png"
            }, new Card
            {
                Id = 4,
                Name = "Hot Chocolate",
                Attack = 3,
                Health = 3,
                Cost = 3,
                Colour = "Orange",
                ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png"
            }, new Card
            {
                Id = 5,
                Name = "Landing Pad",
                Attack = 4,
                Health = 3,
                Cost = 3,
                Colour = "Violet",
                ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png"
            }
            };

            DeckCardDTO DeckCardDTO = new DeckCardDTO() {
                Deck = deckAjouter,
                cards = cards
            };
            service.PostDeck(DeckCardDTO);
            Assert.AreEqual(deckAjouter, db.Decks.Where(d => d.DeckName == "DeckTestNiki").FirstOrDefault());
            Assert.AreEqual(5, db.Decks.Where(d => d.DeckName == "DeckTestNiki").FirstOrDefault()?.OwnedCards.Count);
        }
        }
    }
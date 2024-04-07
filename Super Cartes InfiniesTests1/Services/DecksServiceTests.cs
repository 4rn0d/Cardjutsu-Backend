using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;
using Moq;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using Super_Cartes_Infinies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Claims;
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
                .UseInMemoryDatabase(databaseName: "SuperCartesInfinies")
                .UseLazyLoadingProxies(true)
                .Options;
        }

        [TestInitialize]
        public void Init()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
          
          
            // Ajoutez les cartes
            List<Card> cards = new List<Card> {
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

            Player player= new Player() {
             Name = "PlayerTestUnit",
              Decks= decks,
              OwnedCards = cards,
              IdentityUser = new IdentityUser() { }

            };
            db.AddRange(player);

            db.SaveChanges();
        }

        [TestCleanup]
        public void Dispose()
        {
            //TODO on efface les données de tests pour remettre la BD dans son état initial
            using ApplicationDbContext db = new ApplicationDbContext(options);

            db.Decks.RemoveRange(db.Decks);
            db.OwnedCards.RemoveRange(db.OwnedCards);
            db.Players.RemoveRange(db.Players);
            db.Cards.RemoveRange(db.Cards);
            db.SaveChanges();
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
        public void GetDecksTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Task.Run(async () =>
            {
                List<Deck> decks = await service.GetDecks(db.Players.First());
                Assert.AreEqual(5, db.Cards.Count());
            }).Wait();
        }

        [TestMethod()]
        public void MakeCurrentDeckTest()
        {
          
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);


                Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
                Deck? deckTest2 = db.Decks.Where(x => x.Id == 2).FirstOrDefault();
                List<Deck> decks = db.Decks.ToList();
                service.MakeCurrentDeck(deckTest.Id, db.Players.First());

                Assert.AreEqual(true, deckTest.IsCurrentDeck);
                Assert.AreEqual(false, deckTest2.IsCurrentDeck);


            service.MakeCurrentDeck(deckTest2.Id, db.Players.First());
                Assert.AreEqual(false, deckTest.IsCurrentDeck);
                Assert.AreEqual(true, deckTest2.IsCurrentDeck);
            
        }
        [TestMethod()]
        public void AjouterCardDeck()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            //test ajouter card
            Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Card cardAjouter = db.Cards.Where(x => x.Id == 4).FirstOrDefault();
            service.AjouterCarte(db.Players.First(), 1, cardAjouter);
            Deck deckVerfier = db.Decks.Where(y => y.Id == 1).FirstOrDefault();
            Assert.AreEqual(cardAjouter, deckVerfier.OwnedCards.Where(x=>x.Card.Id == 4).FirstOrDefault().Card);

          


        }
        [TestMethod()]
        public void AjouterMemeCardDeck()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            //test ajouter card
            Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Card cardAjouter = db.Cards.Where(x => x.Id == 1).FirstOrDefault();
          
            Exception e = Assert.ThrowsException<Exception>(() => service.AjouterCarte(db.Players.First(), 1, cardAjouter));
            Assert.AreEqual("La carte existe dans le deck", e.Message);


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
                Id = 3,
                DeckName = "DeckTestNiki",
                IsCurrentDeck = false,
                OwnedCards = new List<OwnedCard>(),
                PlayerId = db.Players.First().Id,

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

            DeckCardDTO DeckCardDTO = new DeckCardDTO()
            {
                Deck = deckAjouter,
                cards = cards
            };
            service.PostDeck(DeckCardDTO, db.Players.First());
            Deck deckAtester = db.Decks.Where(d => d.DeckName == "DeckTestNiki").First();

            Assert.AreEqual("DeckTestNiki", deckAtester.DeckName);
            Assert.AreEqual(db.Players.First(), deckAtester.Player);
            Assert.AreEqual(false, deckAtester.IsCurrentDeck);
            Assert.AreEqual(5, db.Decks.Where(d => d.DeckName == "DeckTestNiki").FirstOrDefault()?.OwnedCards.Count);
            Assert.AreEqual(5, db.Players.Where(p => p.Id == 1).First().OwnedCards.Count);
        }

        [TestMethod()]
        public void PstDeckMemeNomTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck deckAjouter = new Deck()
            {
                Id = 3,
                DeckName = "Coffee",
                IsCurrentDeck = false,
                OwnedCards = new List<OwnedCard>(),
                PlayerId = db.Players.First().Id,
                
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
            
            
            Exception? e = Assert.ThrowsException<Exception>(() => service.PostDeck(DeckCardDTO, db.Players.First()));
            Assert.AreEqual("Deux decks ne peuvent pas avoir le meme nom", e.Message);

        }
        }

    }

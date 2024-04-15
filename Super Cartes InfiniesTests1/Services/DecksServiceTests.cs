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
using Windows.Security.Authentication.OnlineId;
using Windows.System;

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
            List<Card> cards2 = new List<Card> {
                new Card { Id = 6, Name = "Cart Surfer", Attack = 3, Health = 3, Cost = 3, Colour = "Blue", ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png" },
                
             };

            db.AddRange(cards);
            db.AddRange(cards2);

            // Ajoutez les OwnedCards
            List<OwnedCard> ownedCards = new List<OwnedCard>();
            foreach (var card in cards)
            {
                ownedCards.Add(new OwnedCard { PlayerId = 1, CardId = card.Id });
            }
            List<OwnedCard> ownedCards2 = new List<OwnedCard>();

            foreach (var card in cards2)
            {
                ownedCards2.Add(new OwnedCard { Id = 6, CardId = card.Id });
            }
            db.AddRange(ownedCards2);

            //Card start pour test player 
            List<CardStart> CardsStarts = new List<CardStart>();
            foreach (var card in cards)
            {

                CardsStarts.Add(new CardStart { CardId = card.Id });
            }
            db.AddRange(CardsStarts);
            // Ajoutez les Decks
            List<Deck> decks = new List<Deck>
            {
                new Deck {Id=1, DeckName = "Cart", IsCurrentDeck = false, OwnedCards = ownedCards.Where(oc => oc.CardId == 1 || oc.CardId == 2).ToList(), PlayerId = 1 },
                new Deck {Id=2, DeckName = "Coffee", IsCurrentDeck = true, OwnedCards = ownedCards.Where(oc => oc.CardId == 3 || oc.CardId == 4 || oc.CardId == 5).ToList(), PlayerId = 1 }
            };


            db.AddRange(decks);

            Player player = new Player()
            {
                Id = 1,
                Name = "PlayerTestUnit",
                Decks = decks,
                OwnedCards = cards,
                IdentityUser = new IdentityUser() { }

            };
          

            db.AddRange(player);

            Config config = new Config()
            {
                Id = 1,
                ManaPerRound = 1,
                NbCardsStart = 5,
                NbCarteParDeck = 5,
                NbDecks = 3
            };
            db.AddRange(config);

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
            db.Config.RemoveRange(db.Config);
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
            Deck? deckNotNull = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Assert.IsNotNull(deckNotNull);
            service.DeleteDeck(1, db.Players.First());
            Deck? deckNull = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Assert.IsNull(deckNull);
        }
        [TestMethod()]
        public void DeleteDeckQuiAppartientPasTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck? deckNull = db.Decks.Where(x => x.Id == 5).FirstOrDefault();
            Assert.IsNull(deckNull);

            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.DeleteDeck(5, db.Players.First()));
                Assert.AreEqual("Ce deck n'existe pas", e.Message);
            }).Wait();


        }
        [TestMethod()]
        public void DeleteDeckCourantTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck? deckCourant = db.Decks.Where(x => x.Id == 2).FirstOrDefault();
            Assert.IsTrue(deckCourant.IsCurrentDeck);

            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.DeleteDeck(deckCourant.Id, db.Players.First()));
                Assert.AreEqual("Impossible de supprimer un deck courrant", e.Message);
            }).Wait();
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
                Assert.AreEqual(2, decks.Count());
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
            service.MakeCurrentDeck(deckTest.Id, db.Players.First());

            Assert.AreEqual(true, deckTest.IsCurrentDeck);
            Assert.AreEqual(false, deckTest2.IsCurrentDeck);


            service.MakeCurrentDeck(deckTest2.Id, db.Players.First());
            Assert.AreEqual(false, deckTest.IsCurrentDeck);
            Assert.AreEqual(true, deckTest2.IsCurrentDeck);

        }
        [TestMethod()]
        public void MakeCurrentDeckThatIsAlreadyCurrentTest()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);


            Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Deck? deckTest2 = db.Decks.Where(x => x.Id == 2).FirstOrDefault();

            service.MakeCurrentDeck(deckTest2.Id, db.Players.First());
            Assert.AreEqual(false, deckTest.IsCurrentDeck);
            Assert.AreEqual(true, deckTest2.IsCurrentDeck);
        }

        [TestMethod()]
        public void AjouterCardDeckTest()
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
            Assert.AreEqual(cardAjouter, deckVerfier.OwnedCards.Where(x => x.Card.Id == 4).FirstOrDefault().Card);




        }
        [TestMethod()]
        public void AjouterMemeCardDeckTest()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            //test ajouter card
            Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Card cardAjouter = db.Cards.Where(x => x.Id == 1).FirstOrDefault();



            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.AjouterCarte(db.Players.First(), 1, cardAjouter));
                Assert.AreEqual("La carte existe dans le deck", e.Message);
            }).Wait();
        }
        [TestMethod()]
        public void AjouterMauvaiseCardDansDeckTest()
        {

            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            //test ajouter card
            Deck? deckTest = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            Card cardAjouter = db.Cards.Where(x => x.Id == 6).FirstOrDefault();



            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.AjouterCarte(db.Players.First(), 1, cardAjouter));
                Assert.AreEqual("Cette carte n'existe pas chez le player", e.Message);
            }).Wait();
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
                PlayerId = db.Players.FirstOrDefault().Id,

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
            service.PostDeck(DeckCardDTO, db.Players.FirstOrDefault());
            Deck deckAtester = db.Decks.Where(d => d.DeckName == "DeckTestNiki").First();

            Assert.AreEqual("DeckTestNiki", deckAtester.DeckName);
            Assert.AreEqual(db.Players.First(), deckAtester.Player);
            Assert.AreEqual(false, deckAtester.IsCurrentDeck);
            Assert.AreEqual(5, db.Decks.Where(d => d.DeckName == "DeckTestNiki").FirstOrDefault()?.OwnedCards.Count);
            Assert.AreEqual(5, db.Players.Where(p => p.Id == 1).FirstOrDefault().OwnedCards.Count);
        }

        [TestMethod()]
        public void PostDeckMemeNomTest()
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

            DeckCardDTO DeckCardDTO = new DeckCardDTO()
            {
                Deck = deckAjouter,
                cards = cards
            };
            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.PostDeck(DeckCardDTO, db.Players.First()));
                Assert.AreEqual("Deux decks ne peuvent pas avoir le meme nom", e.Message);
            }).Wait();



        }

        [TestMethod()]
        public void DeleteCardDuDeckTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Card card = db.Cards.Where(x => x.Id == 1).FirstOrDefault();
            Deck deck = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            service.DeleteCardDuDeck(db.Players.First(), deck.Id, card);

            OwnedCard ownedCard = deck.OwnedCards.Where(x => x.Card.Id == card.Id).FirstOrDefault();
            Assert.IsNull(ownedCard);
        }
        [TestMethod()]
        public void DeleteCardDuDeckMauvaiseCarteTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Card cardMauvaisDeck = db.Cards.Where(x => x.Id == 4).FirstOrDefault();
            Deck deck = db.Decks.Where(x => x.Id == 1).FirstOrDefault();


            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.DeleteCardDuDeck(db.Players.First(), deck.Id, cardMauvaisDeck));
                Assert.AreEqual("Le deck ne contient pas cette carte", e.Message);
            }).Wait();

        }
        [TestMethod()]
        public void DeleteCardDuDeckNotFoundTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Card cardMauvaisDeck = db.Cards.Where(x => x.Id == 4).FirstOrDefault();
            Deck deck = db.Decks.Where(x => x.Id == 1).FirstOrDefault();


            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.DeleteCardDuDeck(db.Players.First(), 5, cardMauvaisDeck));
                Assert.AreEqual("Deck is not found", e.Message);
            }).Wait();
        }

        //test si supprime la carte dans le deck et non la carte dans la bd, voir si elle exsite encore independante
        [TestMethod()]
        public void DeleteCardDuDeckTestSiSupprimeDeckEtNonLaCarteDansDB()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Card card = db.Cards.Where(x => x.Id == 1).FirstOrDefault();
            Deck deck = db.Decks.Where(x => x.Id == 1).FirstOrDefault();
            service.DeleteCardDuDeck(db.Players.First(), deck.Id, card);


            Card Cardexiste = db.OwnedCards.Where(x => x.Card.Id == card.Id).FirstOrDefault().Card;
            Assert.AreSame(card, Cardexiste);
        }

        [TestMethod()]
        public void CreerJoueurTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            IdentityUser identityUser = new IdentityUser()
            {
                Id = "4ad47bf7-dcf4-4e03-ae0b-e7eb5ad6221f",
                Email = "niki@gmail.com",
                UserName = "niki@gmail.com",

            };
            playersService.CreatePlayer(identityUser);
            Config config = db.Config.First();
            Player playerATester = db.Players.Where(x => x.IdentityUserId == identityUser.Id).FirstOrDefault();
            Assert.AreEqual(config.NbCardsStart, playerATester.Decks.First().OwnedCards.Count());
            Assert.AreEqual("Depart", playerATester.Decks.First().DeckName);

        }




        [TestMethod()]
        public void PostDeckNomManquantTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck deckAjouter = new Deck()
            {
                Id = 3,
                DeckName = "",
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
            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.PostDeck(DeckCardDTO, db.Players.First()));
                Assert.AreEqual("Nom du deck manquant", e.Message);
            }).Wait();



        }

        [TestMethod()]
        public void PostDeckCardManquantTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Deck deckAjouter = new Deck()
            {
                Id = 3,
                DeckName = "decll",
                IsCurrentDeck = false,
                OwnedCards = new List<OwnedCard>(),
                PlayerId = db.Players.First().Id,

            };
            List<Card> cards = new List<Card>();
           

            DeckCardDTO DeckCardDTO = new DeckCardDTO()
            {
                Deck = deckAjouter,
                cards = cards
            };
            Task.Run(async () =>
            {
                Exception e = await Assert.ThrowsExceptionAsync<Exception>(() => service.PostDeck(DeckCardDTO, db.Players.First()));
                Assert.AreEqual("Cards manquant", e.Message);
            }).Wait();



        }

        [TestMethod()]
        public void ConfigurationDeckTest()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            StartingCardsService startingCardsService = new StartingCardsService(db);
            PlayersService playersService = new PlayersService(db, startingCardsService);
            DecksService service = new DecksService(db, httpContextAccessor);

            Config config = db.Config.First();

            Config configTest = service.ConfigurationDeck();

            Assert.AreEqual(config.NbCardsStart, configTest.NbCardsStart);
            Assert.AreEqual(config.NbCarteParDeck , configTest.NbCarteParDeck);
            Assert.AreEqual(config.NbDecks, configTest.NbDecks);
        }
    }

}

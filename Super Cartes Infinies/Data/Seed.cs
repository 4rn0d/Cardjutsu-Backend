using System;
using System.Drawing;
using Microsoft.AspNetCore.Identity;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Data
{
    public class Seed
    {
        public Seed() { }

        public static Card[] SeedCards()
        {
            return new Card[] {
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
                    Health = 4,
                    Cost = 3,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png"
                }, new Card
                {
                    Id = 3,
                    Name = "Astro Barrier",
                    Attack = 2,
                    Health = 1,
                    Cost = 1,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png"
                }, new Card
                {
                    Id = 4,
                    Name = "Hot Chocolate",
                    Attack = 7,
                    Health = 6,
                    Cost = 4,
                    Colour = "Orange",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png"
                }, new Card
                {
                    Id = 5,
                    Name = "Landing Pad",
                    Attack = 8,
                    Health = 8,
                    Cost = 5,
                    Colour = "Violet",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png"
                }, new Card
                {
                    Id = 6,
                    Name = "Pizza Chef",
                    Attack = 4,
                    Health = 2,
                    Cost = 3,
                    Colour = "Violet",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png"
                }, new Card
                {
                    Id = 7,
                    Name = "Paint by Letters",
                    Attack = 6,
                    Health = 3,
                    Cost = 4,
                    Colour = "Red",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png"
                }, new Card
                {
                    Id = 8,
                    Name = "Mine",
                    Attack = 1,
                    Health = 9,
                    Cost = 2,
                    Colour = "Red",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png"
                }, new Card
                {
                    Id = 9,
                    Name = "Construction Worker",
                    Attack = 4,
                    Health = 2,
                    Cost = 2,
                    Colour = "Yellow",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png"
                }, new Card
                {
                    Id = 10,
                    Name = "Jetpack Adventure",
                    Attack = 6,
                    Health = 1,
                    Cost = 2,
                    Colour = "Yellow",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png"
                }, new Card
                {
                    Id = 11,
                    Name = "Gift Shop",
                    Attack = 3,
                    Health = 3,
                    Cost = 3,
                    Colour = "Blue",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png"
                }, new Card
                {
                    Id = 12,
                    Name = "Hiking in the Forest",
                    Attack = 2,
                    Health = 4,
                    Cost = 3,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png"
                }, new Card
                {
                    Id = 13,
                    Name = "Rescue Squad",
                    Attack = 2,
                    Health = 1,
                    Cost = 1,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png"
                }, new Card
                {
                    Id = 14,
                    Name = "Pet Shop",
                    Attack = 7,
                    Health = 6,
                    Cost = 4,
                    Colour = "Orange",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png"
                }, new Card
                {
                    Id = 15,
                    Name = "Ski Village",
                    Attack = 8,
                    Health = 8,
                    Cost = 5,
                    Colour = "Violet",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png"
                }, new Card
                {
                    Id = 16,
                    Name = "Ice Hockey",
                    Attack = 4,
                    Health = 2,
                    Cost = 3,
                    Colour = "Violet",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png"
                }, new Card
                {
                    Id = 17,
                    Name = "Ski Hill",
                    Attack = 6,
                    Health = 3,
                    Cost = 4,
                    Colour = "Red",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png"
                }, new Card
                {
                    Id = 18,
                    Name = "Snowball Fight",
                    Attack = 1,
                    Health = 9,
                    Cost = 2,
                    Colour = "Red",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png"
                }, new Card
                {
                    Id = 19,
                    Name = "Snow Forts",
                    Attack = 4,
                    Health = 2,
                    Cost = 2,
                    Colour = "Yellow",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png"
                }, new Card
                {
                    Id = 20,
                    Name = "Soccer",
                    Attack = 6,
                    Health = 1,
                    Cost = 2,
                    Colour = "Yellow",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png"
                }, new Card
                {
                    Id = 21,
                    Name = "Beach",
                    Attack = 3,
                    Health = 3,
                    Cost = 3,
                    Colour = "Blue",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png"
                }, new Card
                {
                    Id = 22,
                    Name = "Football",
                    Attack = 2,
                    Health = 4,
                    Cost = 3,
                    Colour = "Blue",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png"
                }, new Card
                {
                    Id = 23,
                    Name = "Baseball",
                    Attack = 2,
                    Health = 1,
                    Cost = 1,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png"
                }, new Card
                {
                    Id = 24,
                    Name = "Emerald Princess",
                    Attack = 7,
                    Health = 6,
                    Cost = 4,
                    Colour = "Green",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png"
                }, new Card
                {
                    Id = 25,
                    Name = "Bean Counters",
                    Attack = 8,
                    Health = 8,
                    Cost = 5,
                    Colour = "Orange",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png"
                }, new Card
                {
                    Id = 26,
                    Name = "Manhole Cover",
                    Attack = 4,
                    Health = 2,
                    Cost = 3,
                    Colour = "Violet",
                    ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png"
                }
            };
        }
       

        public static IdentityUser[] SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            IdentityUser admin = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                // La comparaison d'identity se fait avec les versions normalisés
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                // On encrypte le mot de passe
                PasswordHash = hasher.HashPassword(null, "Passw0rd!"),
                LockoutEnabled = true
            };


            return new IdentityUser[] { admin };
        }

        public static IdentityRole[] SeedRoles()
        {
            IdentityRole adminRole = new IdentityRole
            {
                Id = "11111111-1111-1111-1111-111111111112",
                Name = ApplicationDbContext.ADMIN_ROLE,
                NormalizedName = ApplicationDbContext.ADMIN_ROLE.ToUpper()
            };

            return new IdentityRole[] { adminRole };
        }

        public static IdentityUserRole<string>[] SeedUserRoles()
        {
            IdentityUserRole<string> userAdmin = new IdentityUserRole<string>
            {
                RoleId = "11111111-1111-1111-1111-111111111112",
                UserId = "11111111-1111-1111-1111-111111111111"
            };
            return new IdentityUserRole<string>[] { userAdmin };
        }

        public static Power[] SeedPower()
        {
            Power power1 = new Power()
            {
                PowerId = 1,
                Name = "First Strike",
                Description = "First Strike permet à une carte d’attaquer en « premier » et de ne pas recevoir de dégât si elle tue la carte de l’adversaire.",
                Icone = "https://leagueofitems.com/images/runes/256/8369.webp",
                HasValue = false
            };
            Power power2 = new Power()
            {
                PowerId = 2,
                Name = "Thorns",
                Description = "Lorsqu’une carte défend, elle inflige X de dégâts AVANT de recevoir des dégâts. Si l’attaquant est tué par ces dégâts, l’attaque s’arrête et le défenseur ne reçoit pas de dégâts.",
                Icone = "https://leagueofitems.com/images/items/128/3075.webp",
                HasValue = true
            };
            Power power3 = new Power()
            {
                PowerId = 3,
                Name = "Heal",
                Description = "Soigne les cartes alliées de X incluant elle-même AVANT d’attaquer (mais les cartes ne peuvent pas avoir plus de health qu’au départ.)",
                Icone = "https://cdnb.artstation.com/p/assets/images/images/059/650/103/large/mackenzie-miller-healthpotion.jpg?1676863888",
                HasValue = true
            };
            Power power4 = new Power()
            {
                PowerId = 4,
                Name = "Thief",
                Description = "Vole le mana de l'adversaire",
                Icone = "https://cdn-icons-png.flaticon.com/512/843/843332.png",
                HasValue = false
            };
            return new Power[] { power1, power2, power3, power4 };
        }

        public static Config[] SeedConfigs()
        {
            return new Config[]
            {
                new Config
                {
                    Id = 1,
                    NbCardsStart = 4,
                    ManaPerRound = 3,
                    NbCarteParDeck = 5,
                    NbDecks = 3,
                }
            };
        }

        public static CardStart[] SeedCardStarts()
        {
            return new CardStart[] {
                new CardStart
                {
                    Id = 1,
                    CardId = 1,
                }, new CardStart
                {
                    Id = 2,
                    CardId = 2,
                }, new CardStart
                {
                    Id = 3,
                    CardId = 3,
                }, new CardStart
                {
                    Id = 4,
                    CardId = 1,
                }, new CardStart
                {
                    Id = 5,
                    CardId = 2,
                }, new CardStart
                {
                    Id = 6,
                    CardId = 3,
                }, new CardStart
                {
                    Id = 7,
                    CardId = 7
                }, new CardStart
                {
                    Id = 8,
                    CardId = 8,
                }, new CardStart
                {
                    Id = 9,
                    CardId = 4,
                }
            };
        }

        public static IdentityUser[] SeedTestUsers()
        {
            return new IdentityUser[] {
                new IdentityUser()
                {
                    Id = "User1Id"

                },
                new IdentityUser
                {
                    Id = "User2Id"
                }
            };
        }

        public static Player[] SeedTestPlayers()
        {
            return new Player[] {
                new Player
                {
                    Id = 1,
                    Name = "Test player 1",
                    IdentityUserId = "User1Id"

                },
                new Player
                {
                    Id = 2,
                    Name = "Test player 2",
                    IdentityUserId = "User2Id"
                }
            };
        }

    }
}


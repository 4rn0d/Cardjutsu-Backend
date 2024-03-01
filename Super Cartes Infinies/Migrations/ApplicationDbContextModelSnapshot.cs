﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Cartes_Infinies.Data;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111112",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "User1Id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e69d210a-d309-4262-9c4a-2e3f18dafcae",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f633b035-b9ad-432b-83bc-e013495a2423",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "User2Id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "739595df-0d0e-4384-b9e4-86de20f628db",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b1c213f5-4e74-43f2-9581-1624de352190",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "11111111-1111-1111-1111-111111111111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed77da77-d8d2-482b-b4d0-a3c705dde63d",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI+2ASF2P8FpvmHAF1/4ShkIxYKKWClEv1Oedm4zikGGgoNgxPVRS9XzpiC0B+otsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7214d323-8948-4745-b210-6f4fc5677825",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "11111111-1111-1111-1111-111111111111",
                            RoleId = "11111111-1111-1111-1111-111111111112"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 3,
                            Colour = "Blue",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png",
                            Name = "Cart Surfer"
                        },
                        new
                        {
                            Id = 2,
                            Attack = 2,
                            Colour = "Green",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png",
                            Name = "Coffee Shop"
                        },
                        new
                        {
                            Id = 3,
                            Attack = 8,
                            Colour = "Green",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png",
                            Name = "Astro Barrier"
                        },
                        new
                        {
                            Id = 4,
                            Attack = 3,
                            Colour = "Orange",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png",
                            Name = "Hot Chocolate"
                        },
                        new
                        {
                            Id = 5,
                            Attack = 4,
                            Colour = "Violet",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png",
                            Name = "Landing Pad"
                        },
                        new
                        {
                            Id = 6,
                            Attack = 6,
                            Colour = "Violet",
                            Cost = 3,
                            Health = 4,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png",
                            Name = "Pizza Chef"
                        },
                        new
                        {
                            Id = 7,
                            Attack = 2,
                            Colour = "Red",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png",
                            Name = "Paint by Letters"
                        },
                        new
                        {
                            Id = 8,
                            Attack = 7,
                            Colour = "Red",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png",
                            Name = "Mine"
                        },
                        new
                        {
                            Id = 9,
                            Attack = 2,
                            Colour = "Yellow",
                            Cost = 1,
                            Health = 1,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png",
                            Name = "Construction Worker"
                        },
                        new
                        {
                            Id = 10,
                            Attack = 5,
                            Colour = "Yellow",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png",
                            Name = "Jetpack Adventure"
                        },
                        new
                        {
                            Id = 11,
                            Attack = 3,
                            Colour = "Blue",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png",
                            Name = "Gift Shop"
                        },
                        new
                        {
                            Id = 12,
                            Attack = 2,
                            Colour = "Green",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png",
                            Name = "Hiking in the Forest"
                        },
                        new
                        {
                            Id = 13,
                            Attack = 5,
                            Colour = "Green",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png",
                            Name = "Rescue Squad"
                        },
                        new
                        {
                            Id = 14,
                            Attack = 3,
                            Colour = "Orange",
                            Cost = 4,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png",
                            Name = "Pet Shop"
                        },
                        new
                        {
                            Id = 15,
                            Attack = 4,
                            Colour = "Violet",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png",
                            Name = "Ski Village"
                        },
                        new
                        {
                            Id = 16,
                            Attack = 8,
                            Colour = "Violet",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png",
                            Name = "Ice Hockey"
                        },
                        new
                        {
                            Id = 17,
                            Attack = 2,
                            Colour = "Red",
                            Cost = 5,
                            Health = 8,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png",
                            Name = "Ski Hill"
                        },
                        new
                        {
                            Id = 18,
                            Attack = 6,
                            Colour = "Red",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png",
                            Name = "Snowball Fight"
                        },
                        new
                        {
                            Id = 19,
                            Attack = 2,
                            Colour = "Yellow",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png",
                            Name = "Snow Forts"
                        },
                        new
                        {
                            Id = 20,
                            Attack = 7,
                            Colour = "Yellow",
                            Cost = 3,
                            Health = 2,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png",
                            Name = "Soccer"
                        },
                        new
                        {
                            Id = 21,
                            Attack = 3,
                            Colour = "Blue",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png",
                            Name = "Beach"
                        },
                        new
                        {
                            Id = 22,
                            Attack = 5,
                            Colour = "Blue",
                            Cost = 4,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png",
                            Name = "Football"
                        },
                        new
                        {
                            Id = 23,
                            Attack = 2,
                            Colour = "Green",
                            Cost = 2,
                            Health = 9,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png",
                            Name = "Baseball"
                        },
                        new
                        {
                            Id = 24,
                            Attack = 8,
                            Colour = "Green",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png",
                            Name = "Emerald Princess"
                        },
                        new
                        {
                            Id = 25,
                            Attack = 3,
                            Colour = "Orange",
                            Cost = 3,
                            Health = 3,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png",
                            Name = "Bean Counters"
                        },
                        new
                        {
                            Id = 26,
                            Attack = 4,
                            Colour = "Violet",
                            Cost = 2,
                            Health = 2,
                            ImageUrl = "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png",
                            Name = "Manhole Cover"
                        });
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.CardStart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardStart");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1
                        },
                        new
                        {
                            Id = 2,
                            CardId = 2
                        },
                        new
                        {
                            Id = 3,
                            CardId = 3
                        },
                        new
                        {
                            Id = 4,
                            CardId = 1
                        },
                        new
                        {
                            Id = 5,
                            CardId = 2
                        },
                        new
                        {
                            Id = 6,
                            CardId = 3
                        },
                        new
                        {
                            Id = 7,
                            CardId = 7
                        },
                        new
                        {
                            Id = 8,
                            CardId = 8
                        },
                        new
                        {
                            Id = 9,
                            CardId = 4
                        });
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ManaPerRound")
                        .HasColumnType("int");

                    b.Property<int>("NbCardsStart")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Config");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManaPerRound = 3,
                            NbCardsStart = 4
                        });
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsMatchCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPlayerATurn")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerDataAId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerDataBId")
                        .HasColumnType("int");

                    b.Property<string>("UserAId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserBId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WinnerUserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerDataAId");

                    b.HasIndex("PlayerDataBId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.MatchPlayerData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int>("Mana")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("MatchPlayersData");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.OwnedCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PlayerId");

                    b.ToTable("OwnedCards");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.PlayableCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Attack")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int?>("MatchPlayerDataId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchPlayerDataId1")
                        .HasColumnType("int");

                    b.Property<int?>("MatchPlayerDataId2")
                        .HasColumnType("int");

                    b.Property<int?>("MatchPlayerDataId3")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("MatchPlayerDataId");

                    b.HasIndex("MatchPlayerDataId1");

                    b.HasIndex("MatchPlayerDataId2");

                    b.HasIndex("MatchPlayerDataId3");

                    b.ToTable("PlayableCard");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IdentityUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdentityUserId = "User1Id",
                            Name = "Test player 1"
                        },
                        new
                        {
                            Id = 2,
                            IdentityUserId = "User2Id",
                            Name = "Test player 2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Card", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.Player", null)
                        .WithMany("OwnedCards")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.CardStart", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Match", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", "PlayerDataA")
                        .WithMany()
                        .HasForeignKey("PlayerDataAId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", "PlayerDataB")
                        .WithMany()
                        .HasForeignKey("PlayerDataBId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PlayerDataA");

                    b.Navigation("PlayerDataB");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.MatchPlayerData", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.OwnedCard", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Cartes_Infinies.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.PlayableCard", b =>
                {
                    b.HasOne("Super_Cartes_Infinies.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", null)
                        .WithMany("BattleField")
                        .HasForeignKey("MatchPlayerDataId");

                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", null)
                        .WithMany("CardsPile")
                        .HasForeignKey("MatchPlayerDataId1");

                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", null)
                        .WithMany("Graveyard")
                        .HasForeignKey("MatchPlayerDataId2");

                    b.HasOne("Super_Cartes_Infinies.Models.MatchPlayerData", null)
                        .WithMany("Hand")
                        .HasForeignKey("MatchPlayerDataId3");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Player", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.MatchPlayerData", b =>
                {
                    b.Navigation("BattleField");

                    b.Navigation("CardsPile");

                    b.Navigation("Graveyard");

                    b.Navigation("Hand");
                });

            modelBuilder.Entity("Super_Cartes_Infinies.Models.Player", b =>
                {
                    b.Navigation("OwnedCards");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbCardsStart = table.Column<int>(type: "int", nullable: false),
                    ManaPerRound = table.Column<int>(type: "int", nullable: false),
                    NbDecks = table.Column<int>(type: "int", nullable: false),
                    NbCarteParDeck = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Power",
                columns: table => new
                {
                    PowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasValue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Power", x => x.PowerId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCurrentDeck = table.Column<bool>(type: "bit", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlayerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Decks_Players_PlayerId1",
                        column: x => x.PlayerId1,
                        principalTable: "Players",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MatchPlayersData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPlayersData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchPlayersData_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardPower",
                columns: table => new
                {
                    CardPowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    PowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPower", x => x.CardPowerId);
                    table.ForeignKey(
                        name: "FK_CardPower_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardPower_Power_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Power",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardStart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardStart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardStart_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnedCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnedCards_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnedCards_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPlayerATurn = table.Column<bool>(type: "bit", nullable: false),
                    IsMatchCompleted = table.Column<bool>(type: "bit", nullable: false),
                    WinnerUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserBId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerDataAId = table.Column<int>(type: "int", nullable: false),
                    PlayerDataBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_MatchPlayersData_PlayerDataAId",
                        column: x => x.PlayerDataAId,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Matches_MatchPlayersData_PlayerDataBId",
                        column: x => x.PlayerDataBId,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlayableCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    MatchPlayerDataId = table.Column<int>(type: "int", nullable: true),
                    MatchPlayerDataId1 = table.Column<int>(type: "int", nullable: true),
                    MatchPlayerDataId2 = table.Column<int>(type: "int", nullable: true),
                    MatchPlayerDataId3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayableCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayableCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayableCard_MatchPlayersData_MatchPlayerDataId",
                        column: x => x.MatchPlayerDataId,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayableCard_MatchPlayersData_MatchPlayerDataId1",
                        column: x => x.MatchPlayerDataId1,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayableCard_MatchPlayersData_MatchPlayerDataId2",
                        column: x => x.MatchPlayerDataId2,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayableCard_MatchPlayersData_MatchPlayerDataId3",
                        column: x => x.MatchPlayerDataId3,
                        principalTable: "MatchPlayersData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeckOwnedCard",
                columns: table => new
                {
                    OwnedCardsId = table.Column<int>(type: "int", nullable: false),
                    decksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckOwnedCard", x => new { x.OwnedCardsId, x.decksId });
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_Decks_decksId",
                        column: x => x.decksId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_OwnedCards_OwnedCardsId",
                        column: x => x.OwnedCardsId,
                        principalTable: "OwnedCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-1111-1111-1111-111111111112", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", 0, "9a9f7ade-b12b-48f1-85e4-5d3b5a730d5c", "admin@admin.com", true, true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEOu/cV/ZtbrQu0wUuwMIE8EWb0WrWdSXBypnAuLfA2Ak7TvSwgeSMe8C3AT/pVuZ6Q==", null, false, "45679162-f32b-4741-b919-bda922c185fd", false, "admin@admin.com" },
                    { "User1Id", 0, "82aae080-64a8-4610-bac9-d0905836a140", null, false, false, null, null, null, null, null, false, "c65b536a-79c9-4236-a88a-711a77c273a4", false, null },
                    { "User2Id", 0, "4af3cbd5-1edf-4c04-8dac-cd0f5770b3aa", null, false, false, null, null, null, null, null, false, "19ff5d36-995c-44e2-804c-f5b228858d27", false, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name", "PlayerId" },
                values: new object[,]
                {
                    { 1, 3, "Blue", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png", "Cart Surfer", null },
                    { 2, 2, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png", "Coffee Shop", null },
                    { 3, 8, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png", "Astro Barrier", null },
                    { 4, 3, "Orange", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png", "Hot Chocolate", null },
                    { 5, 4, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png", "Landing Pad", null },
                    { 6, 6, "Violet", 3, 4, "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png", "Pizza Chef", null },
                    { 7, 2, "Red", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png", "Paint by Letters", null },
                    { 8, 7, "Red", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png", "Mine", null },
                    { 9, 2, "Yellow", 1, 1, "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png", "Construction Worker", null },
                    { 10, 5, "Yellow", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png", "Jetpack Adventure", null },
                    { 11, 3, "Blue", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png", "Gift Shop", null },
                    { 12, 2, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png", "Hiking in the Forest", null },
                    { 13, 5, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png", "Rescue Squad", null },
                    { 14, 3, "Orange", 4, 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png", "Pet Shop", null },
                    { 15, 4, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png", "Ski Village", null },
                    { 16, 8, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png", "Ice Hockey", null },
                    { 17, 2, "Red", 5, 8, "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png", "Ski Hill", null },
                    { 18, 6, "Red", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png", "Snowball Fight", null },
                    { 19, 2, "Yellow", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png", "Snow Forts", null },
                    { 20, 7, "Yellow", 3, 2, "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png", "Soccer", null },
                    { 21, 3, "Blue", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png", "Beach", null },
                    { 22, 5, "Blue", 4, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png", "Football", null },
                    { 23, 2, "Green", 2, 9, "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png", "Baseball", null },
                    { 24, 8, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png", "Emerald Princess", null },
                    { 25, 3, "Orange", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png", "Bean Counters", null },
                    { 26, 4, "Violet", 2, 2, "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png", "Manhole Cover", null }
                });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "Id", "ManaPerRound", "NbCardsStart", "NbCarteParDeck", "NbDecks" },
                values: new object[] { 1, 3, 4, 5, 3 });

            migrationBuilder.InsertData(
                table: "Power",
                columns: new[] { "PowerId", "Description", "HasValue", "Icone", "Name" },
                values: new object[,]
                {
                    { 1, "First Strike permet à une carte d’attaquer en « premier » et de ne pas recevoir de dégât si elle tue la carte de l’adversaire.", false, "https://leagueofitems.com/images/runes/256/8369.webp", "First Strike" },
                    { 2, "Lorsqu’une carte défend, elle inflige X de dégâts AVANT de recevoir des dégâts. Si l’attaquant est tué par ces dégâts, l’attaque s’arrête et le défenseur ne reçoit pas de dégâts.", true, "https://leagueofitems.com/images/items/128/3075.webp", "Thorns" },
                    { 3, "Soigne les cartes alliées de X incluant elle-même AVANT d’attaquer (mais les cartes ne peuvent pas avoir plus de health qu’au départ.)", true, "https://cdnb.artstation.com/p/assets/images/images/059/650/103/large/mackenzie-miller-healthpotion.jpg?1676863888", "Heal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-1111-1111-1111-111111111112", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.InsertData(
                table: "CardStart",
                columns: new[] { "Id", "CardId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 4 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { 1, "User1Id", "Test player 1" },
                    { 2, "User2Id", "Test player 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardPower_CardId",
                table: "CardPower",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPower_PowerId",
                table: "CardPower",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_CardStart_CardId",
                table: "CardStart",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_DeckOwnedCard_decksId",
                table: "DeckOwnedCard",
                column: "decksId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_PlayerId",
                table: "Decks",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_PlayerId1",
                table: "Decks",
                column: "PlayerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_PlayerDataAId",
                table: "Matches",
                column: "PlayerDataAId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_PlayerDataBId",
                table: "Matches",
                column: "PlayerDataBId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayersData_PlayerId",
                table: "MatchPlayersData",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCards_CardId",
                table: "OwnedCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCards_PlayerId",
                table: "OwnedCards",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCard_CardId",
                table: "PlayableCard",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCard_MatchPlayerDataId",
                table: "PlayableCard",
                column: "MatchPlayerDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCard_MatchPlayerDataId1",
                table: "PlayableCard",
                column: "MatchPlayerDataId1");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCard_MatchPlayerDataId2",
                table: "PlayableCard",
                column: "MatchPlayerDataId2");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCard_MatchPlayerDataId3",
                table: "PlayableCard",
                column: "MatchPlayerDataId3");

            migrationBuilder.CreateIndex(
                name: "IX_Players_IdentityUserId",
                table: "Players",
                column: "IdentityUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CardPower");

            migrationBuilder.DropTable(
                name: "CardStart");

            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "DeckOwnedCard");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "PlayableCard");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Power");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "OwnedCards");

            migrationBuilder.DropTable(
                name: "MatchPlayersData");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class editImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c437853-c8b9-4b99-9c87-6c09f34d436e", "AQAAAAIAAYagAAAAEPOSnhN8udKL+doFmTnAEr7nTV5lqjnGy1kduXjNT0JvuR3GUXJ6FRxg1o/4qAdJ9w==", "7e0a70b0-3125-4ad2-9b3d-1a6da5ffbc18" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Health", "ImageUrl" },
                values: new object[] { 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58327085-4ec1-4184-a43f-9919d4bdd12b", "AQAAAAIAAYagAAAAEDNLTMOs0V8Up9dJcShk0aoSEEt9vxHrAnDKtFU9qMMCWPKeD8cz6TdW4QOJ3GAwPg==", "8b3be6b7-4a80-46ba-a98c-5357ad56b72a" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png/revision/latest?cb=20150121025008");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png/revision/latest?cb=20150123213646");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png/revision/latest?cb=20150123213647");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png/revision/latest?cb=20150123213647");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png/revision/latest?cb=20150123213647");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png/revision/latest?cb=20150123213648");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png/revision/latest?cb=20150806164936");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png/revision/latest?cb=20150123213648");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png/revision/latest?cb=20150123220534");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png/revision/latest?cb=20150123220536");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png/revision/latest?cb=20150123220535");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png/revision/latest?cb=20150123220536");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png/revision/latest?cb=20150123220537");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Health", "ImageUrl" },
                values: new object[] { 6, "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png/revision/latest?cb=20150123220538" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png/revision/latest?cb=20150806165004");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png/revision/latest?cb=20150123224012");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png/revision/latest?cb=20150123224012");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png/revision/latest?cb=20150123224013");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png/revision/latest?cb=20150123224013");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png/revision/latest?cb=20150123224014");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png/revision/latest?cb=20150123224014");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png/revision/latest?cb=20150123224014");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png/revision/latest?cb=20150123224015");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png/revision/latest?cb=20150123224015");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png/revision/latest?cb=20150123224016");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png/revision/latest?cb=20150123224059");
        }
    }
}

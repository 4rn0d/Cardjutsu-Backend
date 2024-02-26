using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class color : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38bf7a26-e388-489a-aeb6-7f146ee5eff9", "AQAAAAIAAYagAAAAEPks1qKNegDfW216lVCg2MS8dtWA0aB5KjEEzStVfR6MO908gewJKBLEGNDd9ZMCOA==", "e69b0b3a-4fa8-40b3-a30b-59e8f84dfc73" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Colour", "ImageUrl", "Name" },
                values: new object[] { "Blue", "https://static.wikia.nocookie.net/clubpenguin/images/0/0b/CART_SURFER_card_image.png/revision/latest?cb=20150121025008", "Cart Surfer" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Colour", "Health", "ImageUrl", "Name" },
                values: new object[] { "Green", 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b2/COFFEE_SHOP_card_image.png/revision/latest?cb=20150123213646", "Coffee Shop" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 8, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/2/22/ASTRO_BARRIER_card_image.png/revision/latest?cb=20150123213647", "Astro Barrier" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 3, "Orange", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/3/3d/HOT_CHOCOLATE_card_image.png/revision/latest?cb=20150123213647", "Hot Chocolate" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 4, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/d/d2/LANDING_PAD_card_image.png/revision/latest?cb=20150123213647", "Landing Pad" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Attack", "Colour", "Health", "ImageUrl", "Name" },
                values: new object[] { 6, "Violet", 4, "https://static.wikia.nocookie.net/clubpenguin/images/5/57/PIZZA_CHEF_card_image.png/revision/latest?cb=20150123213648", "Pizza Chef" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Attack", "Colour", "Cost", "ImageUrl", "Name" },
                values: new object[] { 2, "Red", 3, "https://static.wikia.nocookie.net/clubpenguin/images/b/b5/PAINT_BY_LETTERS_card_image.png/revision/latest?cb=20150806164936", "Paint by Letters" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 7, "Red", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/3/30/MINE_card_image.png/revision/latest?cb=20150123213648", "Mine" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 2, "Yellow", 1, 1, "https://static.wikia.nocookie.net/clubpenguin/images/a/a5/CONSTRUCTION_WORKER_card_image.png/revision/latest?cb=20150123220534", "Construction Worker" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 5, "Yellow", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/13/JET_PACK_ADVENTURE_card_image.png/revision/latest?cb=20150123220536", "Jetpack Adventure" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attack", "Colour", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 11, 3, "Blue", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f2/GIFT_SHOP_card_image.png/revision/latest?cb=20150123220535", "Gift Shop" },
                    { 12, 2, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/7/72/HIKING_IN_THE_FOREST_card_image.png/revision/latest?cb=20150123220536", "Hiking in the Forest" },
                    { 13, 5, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/a/a6/RESCUE_SQUAD_card_image.png/revision/latest?cb=20150123220537", "Rescue Squad" },
                    { 14, 3, "Orange", 4, 6, "https://static.wikia.nocookie.net/clubpenguin/images/b/b3/PET_SHOP_card_image.png/revision/latest?cb=20150123220538", "Pet Shop" },
                    { 15, 4, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/c/c3/SKI_VILLAGE_card_image.png/revision/latest?cb=20150806165004", "Ski Village" },
                    { 16, 8, "Violet", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f4/ICE_HOCKEY_card_image.png/revision/latest?cb=20150123224012", "Ice Hockey" },
                    { 17, 2, "Red", 5, 8, "https://static.wikia.nocookie.net/clubpenguin/images/c/c1/SKI_HILL_card_image.png/revision/latest?cb=20150123224012", "Ski Hill" },
                    { 18, 6, "Red", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/f/f5/SNOWBALL_FIGHT_card_image.png/revision/latest?cb=20150123224013", "Snowball Fight" },
                    { 19, 2, "Yellow", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/13/SNOW_FORTS_card_image.png/revision/latest?cb=20150123224013", "Snow Forts" },
                    { 20, 7, "Yellow", 3, 2, "https://static.wikia.nocookie.net/clubpenguin/images/9/97/SOCCER_card_image.png/revision/latest?cb=20150123224014", "Soccer" },
                    { 21, 3, "Blue", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/7/77/BEACH_card_image.png/revision/latest?cb=20150123224014", "Beach" },
                    { 22, 5, "Blue", 4, 3, "https://static.wikia.nocookie.net/clubpenguin/images/1/1a/FOOTBALL_card_image.png/revision/latest?cb=20150123224014", "Football" },
                    { 23, 2, "Green", 2, 9, "https://static.wikia.nocookie.net/clubpenguin/images/f/f0/BASEBALL_card_image.png/revision/latest?cb=20150123224015", "Baseball" },
                    { 24, 8, "Green", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/5/52/EMERALD_PRINCESS_card_image.png/revision/latest?cb=20150123224015", "Emerald Princess" },
                    { 25, 3, "Orange", 3, 3, "https://static.wikia.nocookie.net/clubpenguin/images/6/6b/BEAN_COUNTERS_card_image.png/revision/latest?cb=20150123224016", "Bean Counters" },
                    { 26, 4, "Violet", 2, 2, "https://static.wikia.nocookie.net/clubpenguin/images/e/e8/MANHOLE_COVER_card_image.png/revision/latest?cb=20150123224059", "Manhole Cover" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdab8540-0309-41f5-b265-970765428f35", "AQAAAAIAAYagAAAAEDVvYsXrtC1IprDRB5MC3I978iZYucFfVAGFfjlAd4aM3BLoj9R3UzjyqrgL3O8GdA==", "a0bcbf3a-72e3-49fe-bb05-d02464ba1260" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "https://i.pinimg.com/originals/a8/16/49/a81649bd4b0f032ce633161c5a076b87.jpg", "Chat Dragon" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Health", "ImageUrl", "Name" },
                values: new object[] { 4, "https://i0.wp.com/thediscerningcat.com/wp-content/uploads/2021/02/tabby-cat-wearing-sunglasses.jpg", "Chat Awesome" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 2, 1, 1, "https://cdn.wallpapersafari.com/27/53/SZ8PO9.jpg", "Chatton Laser" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 7, 4, 6, "https://wallpapers.com/images/hd/epic-cat-poster-baavft05ylgta4j8.jpg", "Chat Spacial" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 8, 5, 8, "https://i.etsystatic.com/6230905/r/il/32aa5a/3474618751/il_fullxfull.3474618751_mfvf.jpg", "Chat Guerrier" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Attack", "Health", "ImageUrl", "Name" },
                values: new object[] { 4, 2, "https://store.playstation.com/store/api/chihiro/00_09_000/container/AU/en/99/EP2402-CUSA05624_00-ETH0000000002875/0/image?_version=00_09_000&platform=chihiro&bg_color=000000&opacity=100&w=720&h=720", "Chat Laser" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Attack", "Cost", "ImageUrl", "Name" },
                values: new object[] { 6, 4, "https://images.squarespace-cdn.com/content/51b3dc8ee4b051b96ceb10de/1394662654865-JKOZ7ZFF39247VYDTGG9/hilarious-jedi-cats-fight-video-preview.jpg?content-type=image%2Fjpeg", "Jedi Chat" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 1, 2, 9, "https://i.ytimg.com/vi/2I7pZlUhZak/maxresdefault.jpg", "Blob Chat" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 4, 2, 2, "https://townsquare.media/site/142/files/2011/08/jedicats.jpg?w=980&q=75", "Jedi Chatton" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Attack", "Cost", "Health", "ImageUrl", "Name" },
                values: new object[] { 6, 2, 1, "https://cdn.theatlantic.com/thumbor/fOZjgqHH0RmXA1A5ek-yDz697W4=/133x0:2091x1020/1200x625/media/img/mt/2015/12/RTRD62Q/original.jpg", "Chat Furtif" });
        }
    }
}

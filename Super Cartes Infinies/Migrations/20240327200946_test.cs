using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    DeckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCurrentDeck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.DeckId);
                });

            migrationBuilder.CreateTable(
                name: "DeckOwnedCard",
                columns: table => new
                {
                    DecksDeckId = table.Column<int>(type: "int", nullable: false),
                    OwnedCardsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckOwnedCard", x => new { x.DecksDeckId, x.OwnedCardsId });
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_Deck_DecksDeckId",
                        column: x => x.DecksDeckId,
                        principalTable: "Deck",
                        principalColumn: "DeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckOwnedCard_OwnedCards_OwnedCardsId",
                        column: x => x.OwnedCardsId,
                        principalTable: "OwnedCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1893a1-d273-4c1b-8f57-fc43a356b75d", "AQAAAAIAAYagAAAAEEsnkBJikVJ6jQxsyZEjdh15HUehP27y86vg4ys+ekNMjrclfp89I37SCRDSjj+rdA==", "20038086-6104-492e-9263-2002a83298fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e7a480a-09d0-4611-99b0-e109fbdc3980", "edca7f61-375d-4f41-924e-e482d032443e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a501165b-daae-43ee-9050-92ae69fa0780", "24b0c829-d98a-40c2-bc7e-1f0b8b43d6d0" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckOwnedCard_OwnedCardsId",
                table: "DeckOwnedCard",
                column: "OwnedCardsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckOwnedCard");

            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06251837-86bd-4e70-baa3-2b43bf28ce7d", "AQAAAAIAAYagAAAAEA0xvVsmHg5ORjzGeVXFmK7DZ9iA3IerhIcU+RbFQhRq7Y+Ab398EJfkSSSBsX0t/Q==", "6cc5c7be-1cea-4b2f-9b3b-f86c593d7257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd0f7e28-6466-4a2b-bf71-760add2d2a5f", "9f37b339-efc4-41e3-bb79-bc6de73a8c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15c977e1-882d-4977-8897-1f1415604d0d", "a3fc39e8-bff8-4a2f-91d5-a97b72e66e72" });
        }
    }
}

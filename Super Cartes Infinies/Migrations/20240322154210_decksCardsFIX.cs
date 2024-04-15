using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardsFIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Decks_DeckId",
                table: "DeckCard");

            migrationBuilder.DropIndex(
                name: "IX_DeckCard_DeckId",
                table: "DeckCard");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "DeckCard");

            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e9a7bdc-d332-429a-b000-c4d4f881b79f", "AQAAAAIAAYagAAAAEF8kunWNqLDrp0kyGjUK90Yw1YlkRM3MRVykKmBtXx+YNIEh6T+762bFxMjKr+8zcQ==", "376ae163-ef95-4ef9-9685-0d7b98e5c0ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "926aaf0b-79ac-44a2-97e0-7fa00ed8e52e", "b80b25de-5e9f-4adf-8382-6b16d2112479" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "170c4dbc-d754-4a79-aec6-75c37182ce57", "efbb9f23-d207-4fdb-8fb2-a141423c23f6" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "DeckId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "DeckId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Decks_DeckId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_DeckId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "DeckCard",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac97955-fb29-4201-9447-2b51d371c65f", "AQAAAAIAAYagAAAAEAxh+gpg/0jSweUzRjwqZ+ra2RNW0yBQbRrFZYxg6NFr4c/IdwcGISHf+UAS5yScKw==", "30b29be8-c7bb-453d-8585-60b7beef4bf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45886259-8f1a-4f60-a035-2025c1f52230", "e51ba75e-8b77-4a2f-bcbc-f72112e90da4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fac27489-b131-4089-be01-ba8fbd95a4c1", "ea3f8af2-7b58-4f73-8716-69ce2235e435" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_DeckId",
                table: "DeckCard",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Decks_DeckId",
                table: "DeckCard",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCards2FIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Deckid",
                table: "DeckCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2914808-5b6c-4156-892f-3a6a20c6e36a", "AQAAAAIAAYagAAAAEI+qvZ8CYCyWZiwR3cpMiOrkPOukM3yLyxVRS8MiRiC08cmm15+zs5eeLepIFnCRuA==", "5602405e-5a4f-431d-898d-a042f55d8408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16a7ab8c-7663-443d-b65e-14da9fde4456", "5c652131-c33a-4522-ae4d-21022751724c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "762ed292-4129-43f8-9ca5-8c440b46367a", "051918b4-090c-4e95-aaa4-95e344dcfa70" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_Deckid",
                table: "DeckCard",
                column: "Deckid");

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Decks_Deckid",
                table: "DeckCard",
                column: "Deckid",
                principalTable: "Decks",
                principalColumn: "DeckId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Decks_Deckid",
                table: "DeckCard");

            migrationBuilder.DropIndex(
                name: "IX_DeckCard_Deckid",
                table: "DeckCard");

            migrationBuilder.DropColumn(
                name: "Deckid",
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
    }
}

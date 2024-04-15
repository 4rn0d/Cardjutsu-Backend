using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDeckCard : Migration
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

            migrationBuilder.CreateTable(
                name: "DeckCard",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckCard", x => new { x.DeckId, x.CardId });
                    table.ForeignKey(
                        name: "FK_DeckCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckCard_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "DeckId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a65d611e-4a32-4600-b038-d072e1b25dd0", "AQAAAAIAAYagAAAAECxNayjLnhwCVHlY3GpKlzJDNR3Bje2PITKtGXjp6McMV1pOx2fiqS/GJuoTnOu0Jw==", "f199b5f9-6558-4717-b6ff-8be0ad3d516b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3adce9a4-bfe7-4284-8461-071cb9501c9b", "6fab2eb7-d3f9-43c0-89f4-e2944ae586d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d4d0957-7722-46c9-b69b-1c940a8118f8", "098135c0-5424-4687-beb6-e4264c18bc80" });

            migrationBuilder.CreateIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeckCard");

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
                values: new object[] { "c8ad1ac4-7b0e-4149-b179-b38e56d910d6", "AQAAAAIAAYagAAAAEDAiNeSWCP196fIq/RqnL1aaByhtiSZ7xLQYADcYy8UJH7iUF11HJWO3jdRNbov1rA==", "5b7d5367-b466-49be-b42f-a0b75be2ae61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3459288-3d5f-42f9-8734-3a6439b55dc5", "10b03a64-9a78-41b5-ad5c-7a116d21d038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c75d9a92-23bb-461a-a440-f5b7c2ed56ce", "b51571a8-a628-4cab-8ec9-2a928c674098" });

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

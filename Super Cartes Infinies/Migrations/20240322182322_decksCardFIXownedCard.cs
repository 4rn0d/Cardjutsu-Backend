using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardFIXownedCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_OwnedCardId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "OwnedCardId",
                table: "DeckCard",
                newName: "CardId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_OwnedCardId",
                table: "DeckCard",
                newName: "IX_DeckCard_CardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973afac1-e2a3-42fb-9b27-0ecee00ca139", "AQAAAAIAAYagAAAAEFEVWgociRVYxMh5ZzslVPd5VHxAFONMVNTBsKW0PYfDc1K9HJuNcjDKbv6x9Z011A==", "300eb9e4-bd81-4e16-bb62-d02cf94f8920" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4acc5021-e65b-43e0-9ec1-2eaf20ab1c56", "9c54ff0a-7ee5-4028-b967-08ba3058fba6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "176ea486-de3a-4b9c-86fb-343657f7f39a", "eb71960c-903f-4c55-8338-31ff925b897a" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "DeckCard",
                newName: "OwnedCardId");

            migrationBuilder.RenameIndex(
                name: "IX_DeckCard_CardId",
                table: "DeckCard",
                newName: "IX_DeckCard_OwnedCardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "068e8cd8-8de0-4849-a2c8-f45e631adf89", "AQAAAAIAAYagAAAAEGM7lJj0GBcKuSh0sWPmFaO1mBB4cQszDZCkwcOT0eVUBnedNVpdJvPJi1azbgJHVA==", "575f04cf-549f-443b-aa40-24d5ae5a071c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5da45c0-d097-4450-b733-6ebc20b77ef5", "830e65f4-f938-4ba7-8984-8af6126bcb33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7799198-9753-4915-956d-b283510b6354", "904db070-8d71-4825-afb5-ed4d9cfcce4e" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Cards_OwnedCardId",
                table: "DeckCard",
                column: "OwnedCardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

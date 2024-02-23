using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class ajoutFkOwnedCard3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00fff364-f250-4ca8-891b-53499e542770", "AQAAAAIAAYagAAAAEBiIaZQTxseKaeoHdi1DGQRAgRpdYHChCExlQHUc+0S8xzAbOa59FwScJelDyZjkkg==", "f3f7bfec-f2b6-432a-bf68-da5df488cca0" });

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCards_CardId",
                table: "OwnedCards",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCards_PlayerId",
                table: "OwnedCards",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedCards_Cards_CardId",
                table: "OwnedCards",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnedCards_Players_PlayerId",
                table: "OwnedCards",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnedCards_Cards_CardId",
                table: "OwnedCards");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnedCards_Players_PlayerId",
                table: "OwnedCards");

            migrationBuilder.DropIndex(
                name: "IX_OwnedCards_CardId",
                table: "OwnedCards");

            migrationBuilder.DropIndex(
                name: "IX_OwnedCards_PlayerId",
                table: "OwnedCards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bd7f31c-86a2-42c2-90c3-569771d30b3e", "AQAAAAIAAYagAAAAENfwrOjSMpcBZdUrw8SyI+jimNb7gz7BdUTVyp3AYiwTXV7aR+D7kk+bGIV1X7w9SQ==", "bd6e0b6f-4cf6-4515-b92d-f41bf1770842" });
        }
    }
}

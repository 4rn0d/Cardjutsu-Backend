using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class FixOwnedCardsPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_OwnedCards_OwnedCardId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "OwnedCardId",
                table: "Cards",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_OwnedCardId",
                table: "Cards",
                newName: "IX_Cards_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "CardID",
                table: "OwnedCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64c331ba-dcd0-4fcc-9016-a27cfd127af8", "AQAAAAIAAYagAAAAEM0v5cc/X+JY2NQlEB5GHkPVaydXfKz1/vyDbQvAz1iCxEEajOe84Cbzq1FC2TCuAA==", "76369a2e-5e9f-4207-b8e9-a42470be1146" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardID",
                table: "OwnedCards");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Cards",
                newName: "OwnedCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                newName: "IX_Cards_OwnedCardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff5077e4-0b55-4860-8f93-f011ed6df506", "AQAAAAIAAYagAAAAEIwqo4S15j4ftt8liemF+hmzC/rgmwra9n0nWKNLpxvEnvp5XuM7C62iWFWa2tCV+w==", "5df95abb-a4c6-4d07-a211-b9710d00136c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_OwnedCards_OwnedCardId",
                table: "Cards",
                column: "OwnedCardId",
                principalTable: "OwnedCards",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class FixOwnedCardClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnedCardId",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OwnedCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedCards", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff5077e4-0b55-4860-8f93-f011ed6df506", "AQAAAAIAAYagAAAAEIwqo4S15j4ftt8liemF+hmzC/rgmwra9n0nWKNLpxvEnvp5XuM7C62iWFWa2tCV+w==", "5df95abb-a4c6-4d07-a211-b9710d00136c" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "OwnedCardId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_OwnedCardId",
                table: "Cards",
                column: "OwnedCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_OwnedCards_OwnedCardId",
                table: "Cards",
                column: "OwnedCardId",
                principalTable: "OwnedCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_OwnedCards_OwnedCardId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "OwnedCards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_OwnedCardId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "OwnedCardId",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3566e33a-a12f-4da3-a1be-48eb40ac78d5", "AQAAAAIAAYagAAAAEGsBftmLEdj1f7qWJiziFSkXevw8OfhziXdrSG55YAw9k4nutYA9tKfVQ3bDR0uwyA==", "4027a58c-5260-4200-b25b-9e2b71c1eb97" });
        }
    }
}

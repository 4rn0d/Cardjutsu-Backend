using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardFIXownedCard2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "DeckCard",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OwnedCardId",
                table: "DeckCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "558cb78c-1fc9-4859-9883-42831be0b5e1", "AQAAAAIAAYagAAAAECuUI/WP0UGsnyl5UDhxNOIFGQEQ4fZOVUjSrMWk8rJhMAbsyXjDsPcUf5wbBMHNkQ==", "8b967a92-964e-4359-87ae-7aa6a12814c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8047120f-5c96-443f-ada5-ddc52b004d97", "630b3a02-b733-43d4-ab12-15c7622eab27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08b1a9b9-31b4-48d9-accd-172ceb05a070", "ecffca07-94b0-497d-bc9c-250082a95963" });

            migrationBuilder.AddForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeckCard_Cards_CardId",
                table: "DeckCard");

            migrationBuilder.DropColumn(
                name: "OwnedCardId",
                table: "DeckCard");

            migrationBuilder.AlterColumn<int>(
                name: "CardId",
                table: "DeckCard",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardFIXownedCardId : Migration
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
                values: new object[] { "49635a4d-3d36-4a8b-a051-a95b84a42c72", "AQAAAAIAAYagAAAAEHiifNd+hsdqrQrTeP90ZGfG0W+GXkWHWNl/0mqwk6Tptoxo3MVsyeGNNgrlx5P89w==", "e409b085-b020-4eae-8025-abb238631e25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc00d319-2fb9-449b-8387-fe20412d9693", "aedc6037-09c5-49c1-bd07-c21861c83640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1a1df86-0d2f-4e5b-bdd7-226f4651ce02", "210772a7-2346-4025-9ee6-383414b1273b" });

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
                values: new object[] { "4486bc98-a79e-442b-88ad-63859ddd3515", "AQAAAAIAAYagAAAAEFk6CGC2ZTixhrZycgiulCNese2QLx0Qg5U0ekfaijWR/pe9AIXBBcUUYVkjzyK6lQ==", "28c128c3-7ac3-4793-9190-3ec43912b927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c22c781-3d74-4c1e-866e-1ec935127daa", "f0201f34-184d-4be9-8ff5-3f52eaa4e10c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5266b41-0410-459c-8b54-9c1649314f1e", "ded98a68-fb69-4ad3-919b-e3c59428a53d" });

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

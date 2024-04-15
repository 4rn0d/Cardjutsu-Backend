using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class DeckPlayerLiaison : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Decks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId1",
                table: "Decks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffe2af2e-304a-4602-b105-8958d324f20a", "AQAAAAIAAYagAAAAEHhXE7CGgyBzy9KhjlZq+dQZCXKQCYc86j4jqkulmXxWLPfqwNh9W9cSm8B1OkZG+g==", "43b3bb97-ca19-4961-b2a2-fb1d65eff566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "602fd9fe-f3d7-4bde-aad2-bcb351e2e6a9", "7b592246-d79d-40a7-b20d-220515d2b814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7435800f-b18c-455c-813e-8815988cb919", "8394472c-1c7f-4a03-867f-0cbafa3da8ad" });

            migrationBuilder.CreateIndex(
                name: "IX_Decks_PlayerId1",
                table: "Decks",
                column: "PlayerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Players_PlayerId1",
                table: "Decks",
                column: "PlayerId1",
                principalTable: "Players",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Players_PlayerId1",
                table: "Decks");

            migrationBuilder.DropIndex(
                name: "IX_Decks_PlayerId1",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "PlayerId1",
                table: "Decks");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "Decks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e060eb-02b9-42df-b83d-cfc28336eced", "AQAAAAIAAYagAAAAEBJJ3RPvUbVtFfq1tX3V1NbRK87rLLWtbWi7316WW8Yhjj+MtaJR0jNDjgNt0URaaQ==", "fb3e40f9-1174-4cdb-aa79-c4eed17d3e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b46d272-dd4f-4165-9078-cfceb61782d8", "0a411718-2ff3-42a1-8824-877f89187b79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "731cb459-1963-4442-8af3-176d9db80ae0", "d7e5d71f-f942-4dd2-88a2-cfbd9343294b" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerSpactateur2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPlayer",
                table: "Players",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88f68929-baa4-4081-a7b3-ec9f210ec7b2", "AQAAAAIAAYagAAAAEK1bcydLYLgsUp+WnOSbgbdqpSq57j/pPY9tEGxS5OR6LYYti620BhdIDkQbYEASYQ==", "9ad0a76f-51d4-4b9f-8c69-4dda71c51f8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4c043770-c743-4a63-b1ef-0b20f4ef7e0c", "5c11cfb8-5edb-47dd-88e0-5aeaffedb3bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "302114a6-8652-4cb9-a0d0-7c0222de20b2", "5b81e3cf-3ea4-48fa-a3ee-b212d1effcb5" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPlayer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPlayer",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlayer",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ec98d5-d6df-47f0-9122-a7da91242cc3", "AQAAAAIAAYagAAAAEKMrGNJxjrWZ1IS0246Ae7FIHYlWsrIxnFLSqFI767oSLo75+yHY4xfPsJelSaYD8Q==", "684126eb-e0c6-4f28-b3dc-fc100492016c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eaecea87-8da2-47ce-aa8e-b8206222e0df", "4a53d8ee-d69f-4c8e-8299-1ab08547807e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbbb719a-fe51-4c76-a49d-66e8d496580f", "e9fc1710-d0d2-4720-a70d-b5690f727b85" });
        }
    }
}

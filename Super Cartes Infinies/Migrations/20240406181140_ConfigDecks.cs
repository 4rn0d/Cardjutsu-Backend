using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class ConfigDecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NbDecks",
                table: "Config",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63753295-3676-4b89-aaea-94bdc6cc9044", "AQAAAAIAAYagAAAAEN+ZGhRTkCZSzPBqFNFA59COyAgCL5N9mXzhnl/9GeBhTDHT5i388EPo7m+sHLGphA==", "2e9730f0-07cd-4499-8bef-cece83bc1e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4df3a45d-923f-4ebf-b191-55b0eb65ebe6", "251afb8f-33e2-48ea-b07c-5797ea3cbc4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4d6d316-a684-43b7-8824-ff19eee3b724", "2cd9c74b-b8de-4e6d-96ee-256c3f179b6c" });

            migrationBuilder.UpdateData(
                table: "Config",
                keyColumn: "Id",
                keyValue: 1,
                column: "NbDecks",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NbDecks",
                table: "Config");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3538f877-fff0-4824-aaa6-b652cc3152c2", "AQAAAAIAAYagAAAAEE5c7IbuUYeJ4/8z+d+fNm9jG3473sR62YLUhDnmvczMberRh8BCP1qms2x3gIL9dQ==", "ba608ae1-d733-44f5-8b81-7a23acf41a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0a6872c-e037-483c-b28a-9140b7520e5f", "ded442fc-c800-4241-902e-6af68a13367b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a989c55a-4b8b-4eef-8ce1-88ec4aeb19aa", "ed737b35-c967-4465-a37f-8802a6309bf3" });
        }
    }
}

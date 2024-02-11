using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class FixOwnedCardImplmentation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3566e33a-a12f-4da3-a1be-48eb40ac78d5", "AQAAAAIAAYagAAAAEGsBftmLEdj1f7qWJiziFSkXevw8OfhziXdrSG55YAw9k4nutYA9tKfVQ3bDR0uwyA==", "4027a58c-5260-4200-b25b-9e2b71c1eb97" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716d9aba-860d-4af7-877c-6f356864397f", "AQAAAAIAAYagAAAAEBxfHgoKHhOVrFSTnEFYNn8Z91Ox0PZjqhqpv6L/nYfLex3rep4Ik790wRbj0QwkEg==", "8a21b69e-7082-431f-af33-d7e3ecd471d4" });
        }
    }
}

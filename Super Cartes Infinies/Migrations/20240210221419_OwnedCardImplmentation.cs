using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class OwnedCardImplmentation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716d9aba-860d-4af7-877c-6f356864397f", "AQAAAAIAAYagAAAAEBxfHgoKHhOVrFSTnEFYNn8Z91Ox0PZjqhqpv6L/nYfLex3rep4Ik790wRbj0QwkEg==", "8a21b69e-7082-431f-af33-d7e3ecd471d4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06f141ce-d366-4b5d-8331-905ad6b064fd", "AQAAAAIAAYagAAAAEMgzVAITOX8B5vKo8JN9J+dYQc39T1On8NajKtBplyHPSJCL4vpXmalFd3iVGeX5Eg==", "ce93c89b-758a-4556-88d0-1d6adc937a47" });
        }
    }
}

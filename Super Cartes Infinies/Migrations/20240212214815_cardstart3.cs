using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class cardstart3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a73701e-b24f-4b48-8596-8a065fe40d9e", "AQAAAAIAAYagAAAAEHaz8nKkx8uEh+M4ucEVJMXg9Cqj1XGRPJODBE2qgTJsRgFqR8lU+izA5FiHCToenQ==", "d5d5b4a2-281b-4899-9d83-ed33fc8e043a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ea21ca1-a540-403d-bc9c-b16a94ec2c09", "AQAAAAIAAYagAAAAEOu9Z4dk5aFa44/Y3oU2R4xfJrHxQljFyG44R0PaS97C58muysSVP7bPSuAZSBH1Yw==", "3e979788-00c4-4c96-8453-03448ba785ab" });
        }
    }
}

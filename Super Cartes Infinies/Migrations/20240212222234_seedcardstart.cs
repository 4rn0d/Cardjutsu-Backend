using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class seedcardstart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "329015ec-141d-412a-b5e6-d9cb3978f3cd", "AQAAAAIAAYagAAAAEAilBVvWjggKaGvxaOOehLolued60b50SfzQUwkU3duIrjzZ1KA0sSmHYnmI/GaxVw==", "2dc6557a-dd2c-4649-a697-f2dbd772654b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a73701e-b24f-4b48-8596-8a065fe40d9e", "AQAAAAIAAYagAAAAEHaz8nKkx8uEh+M4ucEVJMXg9Cqj1XGRPJODBE2qgTJsRgFqR8lU+izA5FiHCToenQ==", "d5d5b4a2-281b-4899-9d83-ed33fc8e043a" });
        }
    }
}

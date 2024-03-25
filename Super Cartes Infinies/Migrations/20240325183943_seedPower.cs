using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class seedPower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa8a54b-c1bd-473d-b9ec-848164abc154", "AQAAAAIAAYagAAAAEH5MsgC3GhWTyZvQkbGJ0aO1soBqz7hmqI1YEvg0UlfSYdHYxe5QEugSDesN79h7oQ==", "84cb9031-62ea-449b-90e5-44c60e8f51bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "827be8cb-016c-45f2-b71f-086737fcf3e1", "ff0e603a-837e-43e4-8653-5c2b5eb22abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "550343fb-a493-4d13-8eef-462ca8c6be22", "5319e435-6bca-4cda-b5a4-540ca6dad228" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06251837-86bd-4e70-baa3-2b43bf28ce7d", "AQAAAAIAAYagAAAAEA0xvVsmHg5ORjzGeVXFmK7DZ9iA3IerhIcU+RbFQhRq7Y+Ab398EJfkSSSBsX0t/Q==", "6cc5c7be-1cea-4b2f-9b3b-f86c593d7257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd0f7e28-6466-4a2b-bf71-760add2d2a5f", "9f37b339-efc4-41e3-bb79-bc6de73a8c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15c977e1-882d-4977-8897-1f1415604d0d", "a3fc39e8-bff8-4a2f-91d5-a97b72e66e72" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerSpactateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708b60a1-1517-4dfc-b23e-eaaebeb512e1", "AQAAAAIAAYagAAAAECRZileQwl4NQwksdi8lwyd6fxQ3+JGVjZ2haPolBDIZ1TcyfrL0CdTMAKU4368Erg==", "12915b24-14d3-4fea-bd2d-7ea2e22591ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "344b8aa9-6212-4566-b4fa-f4ca7d3d9d59", "e10836ca-34be-40f0-9cad-c67541be68e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69047ad5-1ebb-4539-b2f3-81a87683b18f", "a89afedb-a007-4800-8830-c45e5fd13f20" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class coulours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd182fec-f5e9-465e-87e2-8c0237c1931d", "AQAAAAIAAYagAAAAEKPlFHJoISqag0jS91ioBOGyesDvyqUeV73AOjUtfHThpHHnOUJz70xy3+ZbiJoUxw==", "6271b21a-6931-4580-9a9b-2ca38a6cb2c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03682bb1-4bd9-4bb4-ac3a-9855ba15b7db", "74e16b3a-94b5-4847-a610-4511d287e067" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99355001-b107-4835-bfa9-353901f98a25", "cfa1a9f6-2b24-4332-9205-4f0535745b11" });

            migrationBuilder.InsertData(
                table: "Power",
                columns: new[] { "PowerId", "Description", "HasValue", "Icone", "Name" },
                values: new object[] { 4, "Vole le mana de l'adversaire", false, "https://cdn-icons-png.flaticon.com/512/843/843332.png", "Thief" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbae21ac-742a-4ac3-99a9-1df5bd1ce937", "AQAAAAIAAYagAAAAEIvqyIYDZOIH6y9uS7cqhqBZ+Cbo8Zl9cP3iTfDQFL0i8so2rQXut8ZsBNk2944dHg==", "b5f88f89-0a9e-4629-ac54-03a66c49fbfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b619e5e-75c0-49d9-8f67-c30b9f051e1d", "ec9798ee-942e-4488-95ae-eb9d1bfd0259" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0523e6f6-0d4f-4709-bde6-11bc30aa42d8", "72e5e964-b3b6-4d06-9499-f8d18243f6ad" });
        }
    }
}

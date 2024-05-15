using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class jsonIgnore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a9f7ade-b12b-48f1-85e4-5d3b5a730d5c", "AQAAAAIAAYagAAAAEOu/cV/ZtbrQu0wUuwMIE8EWb0WrWdSXBypnAuLfA2Ak7TvSwgeSMe8C3AT/pVuZ6Q==", "45679162-f32b-4741-b919-bda922c185fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82aae080-64a8-4610-bac9-d0905836a140", "c65b536a-79c9-4236-a88a-711a77c273a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4af3cbd5-1edf-4c04-8dac-cd0f5770b3aa", "19ff5d36-995c-44e2-804c-f5b228858d27" });
        }
    }
}

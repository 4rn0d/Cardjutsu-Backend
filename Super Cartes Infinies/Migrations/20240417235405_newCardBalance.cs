using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class newCardBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b4ecec9-40d1-43f7-997f-d4091327a9b2", "AQAAAAIAAYagAAAAEP9NhOE2Z4tB1KM0zuSCS3bJbCK79452rHtsRUXjqm9w/Dvdn1UzajZ9rMNccuKm5Q==", "1dfd6e23-9630-401a-9703-db184ff91001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86354c74-b154-491f-a187-1c362aa3caf0", "7a668967-d646-44bb-b6f8-ed7751a5a20c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85b8c8aa-4108-4c1f-b7ca-a5ac3e365c36", "3e1aaab3-9e16-4d62-824d-1f9c3ffbdc97" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Health",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 7, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 8, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Attack", "Cost" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 1, 2, 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 6, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Health",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 8, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 1, 2, 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 6, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cost", "Health" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 7, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 8, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cost",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Health",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 8, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Attack", "Cost" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 7, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Health",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 4, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Attack", "Health" },
                values: new object[] { 8, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 6, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 2, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 7, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Cost", "Health" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 8, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Attack", "Cost", "Health" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "Cost",
                value: 2);
        }
    }
}

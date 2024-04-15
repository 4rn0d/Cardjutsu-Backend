using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class addHasValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasPowers",
                table: "Cards");

            migrationBuilder.AddColumn<bool>(
                name: "HasValue",
                table: "Power",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef586cf9-f672-4ca8-b993-c5e48b72249e", "AQAAAAIAAYagAAAAEGG/2ZhhEDdRRT14ikfdNDVQOIgV2J+Ys3uNJwxlkq0+hI7mNC46ugu2vzI8UI52aQ==", "47a0ab1e-337d-4696-adf5-906834a24d5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10ffb2d5-a9f0-4f0f-9c72-bea8f3b92177", "8977ad99-d797-47ee-a490-799aa9a403ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "693b8ef1-a24d-4e9e-ad86-9618d60270f0", "f5eb97f7-1d7a-4774-86b6-99002fece9c3" });

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 1,
                column: "HasValue",
                value: false);

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 2,
                column: "HasValue",
                value: true);

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 3,
                column: "HasValue",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasValue",
                table: "Power");

            migrationBuilder.AddColumn<bool>(
                name: "HasPowers",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac97da2-1f73-4744-9b09-a8df341b8f53", "AQAAAAIAAYagAAAAELdI1fJ3tnz3Sv7S7/+I6pWlHjzFJrUw5s9Ym076XjtTDJXm4unbz3LqHe18QgWiwA==", "1de7ad15-fd4d-4789-8164-52c8e7c7d075" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61e5f136-8110-449d-af93-cbf6994e1234", "5eaee0dc-1c1b-48c6-9ee7-924b00b4e69a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a24314a-ab35-49f0-853f-6628cafd79ab", "644391cb-bf5a-4173-9a4b-f2a9cb265532" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "HasPowers",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "HasPowers",
                value: false);
        }
    }
}

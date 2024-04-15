using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class ConfigDecksFIXset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NbCarteParDeck",
                table: "Config",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5515313e-ac3a-4e19-a807-f5f004c887e9", "AQAAAAIAAYagAAAAEO1cTvh+4g5FCZhjpdmYZFzxaYQ0+pqSluLGpNWNZcbTLjP1/DsgbHIZ9H/jnX3TCA==", "6edfccba-b794-4753-83df-a167a6b1d78a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a238c81c-e9b4-428d-8d29-e0d7d28e1968", "9b32e817-acff-405e-8138-6e93151847d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00b0d7d7-1e69-4dc9-86b4-bd5d7da81aa8", "490ad87c-4164-4de3-8832-60096a88aaed" });

            migrationBuilder.UpdateData(
                table: "Config",
                keyColumn: "Id",
                keyValue: 1,
                column: "NbCarteParDeck",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NbCarteParDeck",
                table: "Config");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63753295-3676-4b89-aaea-94bdc6cc9044", "AQAAAAIAAYagAAAAEN+ZGhRTkCZSzPBqFNFA59COyAgCL5N9mXzhnl/9GeBhTDHT5i388EPo7m+sHLGphA==", "2e9730f0-07cd-4499-8bef-cece83bc1e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4df3a45d-923f-4ebf-b191-55b0eb65ebe6", "251afb8f-33e2-48ea-b07c-5797ea3cbc4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4d6d316-a684-43b7-8824-ff19eee3b724", "2cd9c74b-b8de-4e6d-96ee-256c3f179b6c" });
        }
    }
}

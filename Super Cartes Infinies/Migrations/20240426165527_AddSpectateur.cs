using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AddSpectateur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchId1",
                table: "Players",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MatchId", "MatchId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MatchId", "MatchId1" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchId",
                table: "Players",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MatchId1",
                table: "Players",
                column: "MatchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Matches_MatchId",
                table: "Players",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Matches_MatchId1",
                table: "Players",
                column: "MatchId1",
                principalTable: "Matches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Matches_MatchId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Matches_MatchId1",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_MatchId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_MatchId1",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "MatchId1",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f4826d-f7ea-4be2-bf95-7c998eafbf24", "AQAAAAIAAYagAAAAEAXwDs1FUy6Qv7W4nZWNM1ggi3NpCGzzSLP2UZom1XXLQth5KfTUZJ96KbfqPLTmSQ==", "4b3ff335-17ce-4b72-a7b4-d326c84616c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc951cba-ab62-4de5-ab2c-95ed6698febe", "9a580031-76ab-415b-b94f-91987f289b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04ab95ba-9384-4532-86cd-d599f8f38404", "0cafa479-e95b-42d6-8281-f64a2bdc17c0" });
        }
    }
}

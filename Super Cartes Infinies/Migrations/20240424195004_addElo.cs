using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class addElo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EloScore",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed04ff8e-e96a-4911-9258-01945cf9fed5", "AQAAAAIAAYagAAAAEBPNvonWXJQfxZvmVAlr2VNrNcz5phfPr2Yarz31Z2lG8rnBFv0gPDdlEk9iS1ha4A==", "9b441589-3243-4984-808e-c5cc4deb4bf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf937d10-35fd-4218-b925-3581c7008326", "e2d906ad-5db5-4e13-8602-74a1fdd3ca62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5af4af43-0a70-4efc-8516-7dd7464b5325", "602ff7c5-ab1d-40f5-ab23-9bf2adf154c9" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "EloScore",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "EloScore",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EloScore",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1351b6-0a9b-450e-a4c0-fab16b68a916", "AQAAAAIAAYagAAAAEF6EDqmdTzPgWCPD2FiGbfXa3rdbHvHYLCuxO8iLyheP2vMrg98NmlUeKhPqCmwQnQ==", "2c6a20fd-912e-4f62-a86c-9b5cbf13dca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76c2d7aa-6b84-497c-ad74-3873d1b1350d", "a0a75ca3-de33-42b0-b7a0-fadda9ca9804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e11c8bd9-e1b4-46f3-9bc9-3c513415c99f", "f8e9c4c2-a9f4-4091-b222-a8d5162231d6" });
        }
    }
}

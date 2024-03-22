using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class decksCardFIXDeckId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4486bc98-a79e-442b-88ad-63859ddd3515", "AQAAAAIAAYagAAAAEFk6CGC2ZTixhrZycgiulCNese2QLx0Qg5U0ekfaijWR/pe9AIXBBcUUYVkjzyK6lQ==", "28c128c3-7ac3-4793-9190-3ec43912b927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c22c781-3d74-4c1e-866e-1ec935127daa", "f0201f34-184d-4be9-8ff5-3f52eaa4e10c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5266b41-0410-459c-8b54-9c1649314f1e", "ded98a68-fb69-4ad3-919b-e3c59428a53d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56029aba-5bcc-4ced-8488-b593750cbb2b", "AQAAAAIAAYagAAAAEC56AChJlv1X+aiFSGMjvY5fsjHpmi447B/ZLrixXCGmbqeDcAAlrC2SThfYpt6i+Q==", "fbe679c4-9433-4bd9-8117-653cb554d689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c247cc5d-741c-4c58-a3f8-0eb26c7a65e1", "2aa8c02e-9aa5-443a-b85c-568cd53b9541" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fdead57-f20f-430e-b27e-6c7205b06667", "3968446a-0db4-4c2d-8a89-ba31ab5d80d8" });
        }
    }
}

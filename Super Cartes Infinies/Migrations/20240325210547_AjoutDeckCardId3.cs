using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDeckCardId3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3824c3-4c38-43e6-8eca-e2865a7becb0", "AQAAAAIAAYagAAAAEFOo64HM9Te/Nq16dxLv3O6a7QUvBOOI8QV+V4/ucuzLscH9IpDYeFAh4n+UE1ICMQ==", "432507ef-e6eb-49b1-8ae9-db7eaff11a4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b84903c-6e55-496b-9fb0-473754ee8049", "9420668d-3e3d-4e0f-aa3c-b17e6eb26505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fe85fc5-63b7-41d8-a968-b4bd144bd71f", "b6fe421f-8160-4b07-8d76-1fd5e96a33c9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "763cbb54-4684-4c83-9634-a0f69c7f38ed", "AQAAAAIAAYagAAAAEGS9QiI3yE3upRRpJjMKmU6sxZTuClZtGCh2Maq81mi7feF0UYCpBNep6LUSXx6ZLQ==", "8fa8cabc-1262-4c9e-b7fe-df2fe49f8948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "772c093c-ff5a-4474-9df0-5ffbb99afbc9", "ae978d88-e67c-4834-a2b6-94dec956db62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8944f298-dcae-4a77-9e63-819194ca48cd", "71cde82a-6e43-4879-bc65-7d748f52f247" });
        }
    }
}

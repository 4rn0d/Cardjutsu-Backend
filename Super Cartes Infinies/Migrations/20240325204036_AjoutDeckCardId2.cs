using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDeckCardId2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5064a9e5-8c6a-455a-8fda-c223d3592884", "AQAAAAIAAYagAAAAEKiaINZmDPCYWNyggE7Dre9frNJfFmbW+SQATgmPVkmJ/rwvHobVoIvB+sDgTbPUGA==", "5d160317-5c05-427f-b5a8-1f2ad4565c48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "095c90fd-7ed5-4d6b-8b85-7e39910f8db4", "b85b5375-0c5e-4ab6-80cb-688f8aab11c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75d39ba0-4fe0-4005-ae98-47e344f71c07", "f5fafc73-52f4-4035-b964-d644c2d0206c" });
        }
    }
}

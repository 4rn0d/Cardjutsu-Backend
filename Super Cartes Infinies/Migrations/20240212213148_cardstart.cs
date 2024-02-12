using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class cardstart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b452656-4956-4d58-8c9e-632c18c927ea", "AQAAAAIAAYagAAAAEKnTJzHEN6G+MpBzGJ5lrF6Sxm1SM5X1s0SKbMUHJ+ESEBb/4jpCBAhDhKci5yaiNA==", "f7988a9e-2d24-46e7-80f0-05387c0259c1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c50daf36-fa66-459a-8098-27cc0860d7c0", "AQAAAAIAAYagAAAAEMkh3zsORFLdGu1k1H7HMAZUlHHHs60aY4KIijyRjsFiwyAH1MUxpuEg4ro3araAXQ==", "c06e0f0c-1872-42df-bf7e-d5f37fa5da13" });
        }
    }
}

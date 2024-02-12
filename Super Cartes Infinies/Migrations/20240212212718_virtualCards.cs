using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class virtualCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c50daf36-fa66-459a-8098-27cc0860d7c0", "AQAAAAIAAYagAAAAEMkh3zsORFLdGu1k1H7HMAZUlHHHs60aY4KIijyRjsFiwyAH1MUxpuEg4ro3araAXQ==", "c06e0f0c-1872-42df-bf7e-d5f37fa5da13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbfbb2d-05bc-4f13-a108-5cac760e2fb4", "AQAAAAIAAYagAAAAEDXHEfg+Pj/Xz8OBoaARzKMxW/pWUBBQqftLz6Qfs0SganVXaz7iL0eOdDDeabEq6g==", "ba04ca9e-d4ce-4a35-a74b-52743d4ee921" });
        }
    }
}

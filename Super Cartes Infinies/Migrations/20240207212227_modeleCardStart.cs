using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modeleCardStart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffbfbb2d-05bc-4f13-a108-5cac760e2fb4", "AQAAAAIAAYagAAAAEDXHEfg+Pj/Xz8OBoaARzKMxW/pWUBBQqftLz6Qfs0SganVXaz7iL0eOdDDeabEq6g==", "ba04ca9e-d4ce-4a35-a74b-52743d4ee921" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "968d0530-d106-4d40-9b82-e73a20da6fde", "AQAAAAIAAYagAAAAEDdyl5c4caswQvEUT3/xDEJPRWjloNdCFcHojyCYEd9B3EPFxHRKaxmHKrChKt3Mnw==", "b91980c0-cc44-4aca-9ff9-5f1c9b46407d" });
        }
    }
}

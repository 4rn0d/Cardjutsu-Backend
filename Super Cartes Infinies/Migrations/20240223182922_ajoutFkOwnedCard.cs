using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class ajoutFkOwnedCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3bfc15-ea95-4d3b-b624-0e8b84e0a56c", "AQAAAAIAAYagAAAAEACho0POnukrDWA+Gl53JxmWwmjNnTAwAl/bEJLwqYW48sY9/UCx5CqFMwWB/qdgYw==", "7cef2f44-9c27-4129-a8a0-4041c728e526" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64c331ba-dcd0-4fcc-9016-a27cfd127af8", "AQAAAAIAAYagAAAAEM0v5cc/X+JY2NQlEB5GHkPVaydXfKz1/vyDbQvAz1iCxEEajOe84Cbzq1FC2TCuAA==", "76369a2e-5e9f-4207-b8e9-a42470be1146" });
        }
    }
}

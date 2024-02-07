using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modeleCarteDep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a852aaac-af24-4f90-b97f-a189699d2212", "AQAAAAIAAYagAAAAEHdehI9B9f5UPRYeQGnLbH1GMnaFlfI/Xu/eHHt7Ikc4QnD6ZQ+IlyNpI8WIziXxKQ==", "b2c6055b-e7c6-4875-a56f-774034a2ebac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdab8540-0309-41f5-b265-970765428f35", "AQAAAAIAAYagAAAAEDVvYsXrtC1IprDRB5MC3I978iZYucFfVAGFfjlAd4aM3BLoj9R3UzjyqrgL3O8GdA==", "a0bcbf3a-72e3-49fe-bb05-d02464ba1260" });
        }
    }
}

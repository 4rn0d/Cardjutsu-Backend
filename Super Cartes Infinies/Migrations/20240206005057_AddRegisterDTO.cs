using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AddRegisterDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "085b407f-dbb1-4d73-95fb-0f98f10b5699", "AQAAAAIAAYagAAAAEGI+Y90v7GQsibAiQ/b8aBXXBWMDqDC7WFBzonah3wzYyMFYqfxgyytngV9uedRyPg==", "7ee12883-8383-48df-ba95-779908fdb814" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdab8540-0309-41f5-b265-970765428f35", "AQAAAAIAAYagAAAAEDVvYsXrtC1IprDRB5MC3I978iZYucFfVAGFfjlAd4aM3BLoj9R3UzjyqrgL3O8GdA==", "a0bcbf3a-72e3-49fe-bb05-d02464ba1260" });
        }
    }
}

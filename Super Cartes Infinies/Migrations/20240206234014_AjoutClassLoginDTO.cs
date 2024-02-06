using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutClassLoginDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Players");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc45c41-a6ce-4091-8c5e-0c17dfa1b228", "AQAAAAIAAYagAAAAEP1QvGdYPXFtkyP6ifqPOjUaAMEAVQZvERAjVjbKQugz6czm4I8zevbv3LRpus8hFg==", "d0867d87-cfd2-49af-b17f-62c8b6162eef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

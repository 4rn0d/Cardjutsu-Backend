using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modeleConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbCardsStart = table.Column<int>(type: "int", nullable: false),
                    ManaPerRound = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba66d650-8d27-44e8-aa4d-52aee442babb", "AQAAAAIAAYagAAAAEARcbvH92BbSARGtcmnL0SX5PSRPs3HDTcksaSa9z4ZJmK0aZmHSlA2SqPUQn7AT4Q==", "740391d7-eaf4-4532-b8fc-2effc7c85ce2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a852aaac-af24-4f90-b97f-a189699d2212", "AQAAAAIAAYagAAAAEHdehI9B9f5UPRYeQGnLbH1GMnaFlfI/Xu/eHHt7Ikc4QnD6ZQ+IlyNpI8WIziXxKQ==", "b2c6055b-e7c6-4875-a56f-774034a2ebac" });
        }
    }
}

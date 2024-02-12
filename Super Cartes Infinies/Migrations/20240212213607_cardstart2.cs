using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class cardstart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardStart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardStart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardStart_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ea21ca1-a540-403d-bc9c-b16a94ec2c09", "AQAAAAIAAYagAAAAEOu9Z4dk5aFa44/Y3oU2R4xfJrHxQljFyG44R0PaS97C58muysSVP7bPSuAZSBH1Yw==", "3e979788-00c4-4c96-8453-03448ba785ab" });

            migrationBuilder.CreateIndex(
                name: "IX_CardStart_CardId",
                table: "CardStart",
                column: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardStart");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b452656-4956-4d58-8c9e-632c18c927ea", "AQAAAAIAAYagAAAAEKnTJzHEN6G+MpBzGJ5lrF6Sxm1SM5X1s0SKbMUHJ+ESEBb/4jpCBAhDhKci5yaiNA==", "f7988a9e-2d24-46e7-80f0-05387c0259c1" });
        }
    }
}

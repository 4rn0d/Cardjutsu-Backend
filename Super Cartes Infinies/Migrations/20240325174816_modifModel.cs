using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modifModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Power",
                columns: table => new
                {
                    PowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Power", x => x.PowerId);
                });

            migrationBuilder.CreateTable(
                name: "CardPower",
                columns: table => new
                {
                    CardPowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    PowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPower", x => x.CardPowerId);
                    table.ForeignKey(
                        name: "FK_CardPower_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardPower_Power_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Power",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06251837-86bd-4e70-baa3-2b43bf28ce7d", "AQAAAAIAAYagAAAAEA0xvVsmHg5ORjzGeVXFmK7DZ9iA3IerhIcU+RbFQhRq7Y+Ab398EJfkSSSBsX0t/Q==", "6cc5c7be-1cea-4b2f-9b3b-f86c593d7257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd0f7e28-6466-4a2b-bf71-760add2d2a5f", "9f37b339-efc4-41e3-bb79-bc6de73a8c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15c977e1-882d-4977-8897-1f1415604d0d", "a3fc39e8-bff8-4a2f-91d5-a97b72e66e72" });

            migrationBuilder.CreateIndex(
                name: "IX_CardPower_CardId",
                table: "CardPower",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardPower_PowerId",
                table: "CardPower",
                column: "PowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardPower");

            migrationBuilder.DropTable(
                name: "Power");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5915dad-3bad-40e4-beab-c1426eb5676f", "AQAAAAIAAYagAAAAEDm1IyMB6qz1eu46agQOCMehKrJV9Qcj+8OoiJBMe9MztOkb69KYWZP+8HAt6TYYRw==", "1f6e9cd6-a9d2-4aff-a840-20b452d60019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5560bc06-1bde-4838-8be8-e6908b67b526", "623aafd6-af4f-40e1-906d-27464a4ab8a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a37ffc8a-3951-4803-864a-b8c3f892a0f2", "b5f6f6e9-ddd3-4cc8-a79d-de3c03cedb2b" });
        }
    }
}

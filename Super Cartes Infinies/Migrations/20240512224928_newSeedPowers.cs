using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class newSeedPowers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Icone",
                table: "Power",
                newName: "Icon");

            migrationBuilder.AddColumn<bool>(
                name: "IsSpell",
                table: "Cards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayableCardStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    PlayableCardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayableCardStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayableCardStatus_PlayableCard_PlayableCardId",
                        column: x => x.PlayableCardId,
                        principalTable: "PlayableCard",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayableCardStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7df93b7-c85a-4b4c-8988-f2d13a1fe5d1", "AQAAAAIAAYagAAAAEL35pOmRr4Fr6ccINiuM2bxmOnHUK3fweV3Uexwq4OBvmzUd3EOogDrQEP4dlwYeCw==", "61da5147-651e-4c27-8853-a3a820553283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf598ee0-436b-4a00-9a7e-a69b735b2283", "63dde96c-8804-418b-9d07-a42d0b00565c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aed6420b-81e2-4c5a-af3a-a8cc86f5e387", "922dacca-8e8f-4887-ad79-e0bc0c6af0d7" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsSpell",
                value: false);

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 3,
                column: "Description",
                value: "Soigne les cartes alliées de X incluant elle-même AVANT d’attaquer.");

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 4,
                column: "Description",
                value: "Vole le mana de l'adversaire.");

            migrationBuilder.InsertData(
                table: "Power",
                columns: new[] { "PowerId", "Description", "HasValue", "Icon", "Name" },
                values: new object[,]
                {
                    { 5, "Augmente l'attaque des cartes en jeu du joueur.", true, "https://static.thenounproject.com/png/3257866-200.png", "Boost Attack" },
                    { 6, "Inverse l'attaque et la défense de toutes les cartes en jeu.", false, "https://cdn-icons-png.flaticon.com/512/5110/5110231.png", "Chaos" },
                    { 7, "Ramène une carte (au hazard) du Graveyard du joueur en jeu. La carte ramené en jeu n'attaque pas tout de suite et a seulement 1 de Health.", false, "https://cdn-icons-png.flaticon.com/512/4334/4334125.png", "Resurect" },
                    { 8, "Ajoute une valeur de poison à la carte attaquée. Le poison diminue ensuite la vie d’une carte de la valeur du poison à la fin de son activation. Si une carte a déjà une valeur de poison et qu’elle est à nouveau attaquée, la valeur de poison est augmentée.", true, "https://cdn-icons-png.flaticon.com/512/3953/3953085.png", "Poison" },
                    { 9, "Empêche une carte d’agir pendant son activation durant X tours.", true, "https://en.tankiwiki.com/images/en/5/53/Icon_Stun.png", "Stunned" },
                    { 10, "Fait X dégâts au joueur adverse.", true, "https://static-00.iconduck.com/assets.00/lightning-icon-1676x2048-p46nhgow.png", "Lightning Strike" },
                    { 11, "Fait X dégâts à TOUTES les cartes en jeu (même les nôtres!).", true, "https://cdn-icons-png.flaticon.com/512/3426/3426193.png", "Earthquake" },
                    { 12, "Fait 1 à 6 de dégâts à une carte adverse (au hazard).", false, "https://www.svgrepo.com/show/323837/card-random.svg", "Random Pain" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCardStatus_PlayableCardId",
                table: "PlayableCardStatus",
                column: "PlayableCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayableCardStatus_StatusId",
                table: "PlayableCardStatus",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayableCardStatus");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "IsSpell",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "Power",
                newName: "Icone");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b1351b6-0a9b-450e-a4c0-fab16b68a916", "AQAAAAIAAYagAAAAEF6EDqmdTzPgWCPD2FiGbfXa3rdbHvHYLCuxO8iLyheP2vMrg98NmlUeKhPqCmwQnQ==", "2c6a20fd-912e-4f62-a86c-9b5cbf13dca7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76c2d7aa-6b84-497c-ad74-3873d1b1350d", "a0a75ca3-de33-42b0-b7a0-fadda9ca9804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e11c8bd9-e1b4-46f3-9bc9-3c513415c99f", "f8e9c4c2-a9f4-4091-b222-a8d5162231d6" });

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 3,
                column: "Description",
                value: "Soigne les cartes alliées de X incluant elle-même AVANT d’attaquer (mais les cartes ne peuvent pas avoir plus de health qu’au départ.)");

            migrationBuilder.UpdateData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 4,
                column: "Description",
                value: "Vole le mana de l'adversaire");
        }
    }
}

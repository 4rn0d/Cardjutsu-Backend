using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class seedPower2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f61d2790-63c7-4408-a8d8-ef8d58db6d05", "AQAAAAIAAYagAAAAEPcAqBIqyCOjVWD3eKahj3NcGqOlb4iiILbf0yT5Tk0r++Wwpj2l8IUqPa0t6cDM2g==", "b8e5e768-51de-4176-add6-050c7fcd0465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51803559-13a0-4992-ad4f-8bd33ec0668d", "b843ea18-bb64-4eb7-b71e-f5b76eafc19a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "247fd7a3-e45c-4ef4-b999-2fda913e389c", "36d078cf-a1ca-4a8c-9263-0d64d25bd654" });

            migrationBuilder.InsertData(
                table: "Power",
                columns: new[] { "PowerId", "Description", "Icone", "Name" },
                values: new object[,]
                {
                    { 1, "First Strike permet à une carte d’attaquer en « premier » et de ne pas recevoir de dégât si elle tue la carte de l’adversaire.", "https://leagueofitems.com/images/runes/256/8369.webp", "First Strike" },
                    { 2, "Lorsqu’une carte défend, elle inflige X de dégâts AVANT de recevoir des dégâts. Si l’attaquant est tué par ces dégâts, l’attaque s’arrête et le défenseur ne reçoit pas de dégâts.", "https://leagueofitems.com/images/items/128/3075.webp", "Thorns" },
                    { 3, "Soigne les cartes alliées de X incluant elle-même AVANT d’attaquer (mais les cartes ne peuvent pas avoir plus de health qu’au départ.)", "https://cdnb.artstation.com/p/assets/images/images/059/650/103/large/mackenzie-miller-healthpotion.jpg?1676863888", "Heal" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Power",
                keyColumn: "PowerId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa8a54b-c1bd-473d-b9ec-848164abc154", "AQAAAAIAAYagAAAAEH5MsgC3GhWTyZvQkbGJ0aO1soBqz7hmqI1YEvg0UlfSYdHYxe5QEugSDesN79h7oQ==", "84cb9031-62ea-449b-90e5-44c60e8f51bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "827be8cb-016c-45f2-b71f-086737fcf3e1", "ff0e603a-837e-43e4-8653-5c2b5eb22abe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "550343fb-a493-4d13-8eef-462ca8c6be22", "5319e435-6bca-4cda-b5a4-540ca6dad228" });
        }
    }
}

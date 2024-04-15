using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class Deckname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeckName",
                table: "Decks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac97955-fb29-4201-9447-2b51d371c65f", "AQAAAAIAAYagAAAAEAxh+gpg/0jSweUzRjwqZ+ra2RNW0yBQbRrFZYxg6NFr4c/IdwcGISHf+UAS5yScKw==", "30b29be8-c7bb-453d-8585-60b7beef4bf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45886259-8f1a-4f60-a035-2025c1f52230", "e51ba75e-8b77-4a2f-bcbc-f72112e90da4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fac27489-b131-4089-be01-ba8fbd95a4c1", "ea3f8af2-7b58-4f73-8716-69ce2235e435" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeckName",
                table: "Decks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cd4421e-a581-426d-aea7-66e5562585df", "AQAAAAIAAYagAAAAEGAEzHicei5uLmKGCeJ0tAqw9C/Pmz+nrGdig9TlSVfAMOqTN29s6B2HhwaTLePBeQ==", "00b4464a-d2a6-433d-a10a-9f7cc23c150f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97ab4341-483f-49df-a4bf-c31ad0d4cbce", "d56250cc-cf97-43c4-bcd8-7427884d7b5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12e0cb86-17d6-4d67-90e8-64adc61e6225", "0e694ebb-db94-4f22-88cb-cb3d57b908ca" });
        }
    }
}

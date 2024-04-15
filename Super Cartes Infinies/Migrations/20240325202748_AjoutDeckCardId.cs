using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDeckCardId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DeckCard",
                newName: "DeckCardId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c16db60e-f5bb-4006-8897-87b4a0981870", "AQAAAAIAAYagAAAAEBcq0OSUeD4uOMjMl/Wf/4Q0GWrWnLZks45aehqmNRky5aFnBwu7pvyHaawCERwQWQ==", "0f246ac3-b241-4a40-8e02-910508f01316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fda10c8-5799-4dc1-9853-f397b0147174", "278769f6-4231-44c4-b535-2bfe785badf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "323f9567-fdb3-478b-849e-9ed29d44564b", "51e7231d-baa0-477e-aa1c-27f059525bac" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeckCardId",
                table: "DeckCard",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a65d611e-4a32-4600-b038-d072e1b25dd0", "AQAAAAIAAYagAAAAECxNayjLnhwCVHlY3GpKlzJDNR3Bje2PITKtGXjp6McMV1pOx2fiqS/GJuoTnOu0Jw==", "f199b5f9-6558-4717-b6ff-8be0ad3d516b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3adce9a4-bfe7-4284-8461-071cb9501c9b", "6fab2eb7-d3f9-43c0-89f4-e2944ae586d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d4d0957-7722-46c9-b69b-1c940a8118f8", "098135c0-5424-4687-beb6-e4264c18bc80" });
        }
    }
}

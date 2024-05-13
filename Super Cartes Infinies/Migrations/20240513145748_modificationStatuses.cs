using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modificationStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33258440-14d0-49f1-bcbd-15cbb4526a4d", "AQAAAAIAAYagAAAAEETwK3almORA+AyRxPDevNeLVofBXVcbUvR6WhMICNlBDfXPoPGcjnuALkNgV+sHgw==", "20095eba-33e1-47e4-8db8-330b425c7ba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2619c45c-07a4-43f0-b9e1-8cb3ffbbb07c", "f95aab6d-d543-4cc8-bb95-802cfba19a76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90635307-67ae-490f-b539-ca0c9111333b", "6852de6f-284e-4afb-91fc-3ef11f8f7d93" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Description", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "La carte ne peut plus agir", "", "Stunned" },
                    { 2, "La carte perd de la vie à chaque tour", "", "Poisoned" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36775b41-d6ad-41bb-b380-7d30e468ad10", "AQAAAAIAAYagAAAAECxUXpKBI2b9MqOsAJxMkMODkGvJj1AhSGGu/8hx3D+Dz3zcf7fDieuMMCzTZXU1EA==", "a916776b-4e85-42ea-81ad-2a3f97717c28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e86d494-1b10-4625-8cf6-8de0a3b80647", "aac9dc81-7181-4c0d-95b3-3b21bc449c98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91b6bcb2-c3f7-4446-99ae-1a76e150307c", "353c67b0-e743-4b4f-b833-f06252e83045" });
        }
    }
}

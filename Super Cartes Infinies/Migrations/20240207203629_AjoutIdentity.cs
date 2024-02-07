using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06f141ce-d366-4b5d-8331-905ad6b064fd", "AQAAAAIAAYagAAAAEMgzVAITOX8B5vKo8JN9J+dYQc39T1On8NajKtBplyHPSJCL4vpXmalFd3iVGeX5Eg==", "ce93c89b-758a-4556-88d0-1d6adc937a47" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cc45c41-a6ce-4091-8c5e-0c17dfa1b228", "AQAAAAIAAYagAAAAEP1QvGdYPXFtkyP6ifqPOjUaAMEAVQZvERAjVjbKQugz6czm4I8zevbv3LRpus8hFg==", "d0867d87-cfd2-49af-b17f-62c8b6162eef" });
        }
    }
}

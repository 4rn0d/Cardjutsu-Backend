using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class SeedConfig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "968d0530-d106-4d40-9b82-e73a20da6fde", "AQAAAAIAAYagAAAAEDdyl5c4caswQvEUT3/xDEJPRWjloNdCFcHojyCYEd9B3EPFxHRKaxmHKrChKt3Mnw==", "b91980c0-cc44-4aca-9ff9-5f1c9b46407d" });

            migrationBuilder.InsertData(
                table: "Config",
                columns: new[] { "Id", "ManaPerRound", "NbCardsStart" },
                values: new object[] { 1, 3, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Config",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc11996e-d64e-47a6-8a60-4ddeebf4a516", "AQAAAAIAAYagAAAAEJJ8D0+5aqElVqYRDp9f1MxbyvqiRIesuk54qepNzNEme+xzJFXeSFpO1TfVFg1FqQ==", "e2f867d4-d5b2-44fa-a4f9-d522913d876d" });
        }
    }
}

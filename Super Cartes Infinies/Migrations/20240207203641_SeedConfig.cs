using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class SeedConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc11996e-d64e-47a6-8a60-4ddeebf4a516", "AQAAAAIAAYagAAAAEJJ8D0+5aqElVqYRDp9f1MxbyvqiRIesuk54qepNzNEme+xzJFXeSFpO1TfVFg1FqQ==", "e2f867d4-d5b2-44fa-a4f9-d522913d876d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba66d650-8d27-44e8-aa4d-52aee442babb", "AQAAAAIAAYagAAAAEARcbvH92BbSARGtcmnL0SX5PSRPs3HDTcksaSa9z4ZJmK0aZmHSlA2SqPUQn7AT4Q==", "740391d7-eaf4-4532-b8fc-2effc7c85ce2" });
        }
    }
}

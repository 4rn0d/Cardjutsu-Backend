using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class modificationStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Status",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Icon",
                table: "Status",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}

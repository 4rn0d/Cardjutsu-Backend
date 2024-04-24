using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIsMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMessage",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2119a8a7-955e-477b-99ac-5b5620c986cb", "AQAAAAIAAYagAAAAEPdpwy8/yHZp2WgnE0G3rh9TCkZP8sJMX0S6Ibwicq8jdwt4VMKmv9CnXulhJyAO0w==", "732fccd4-a694-4a3c-8e89-55b300a61927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15392c19-6f86-4960-8dbb-ffaf9499953f", "f1f35ed4-9e27-48d8-bdf1-83bb56a08944" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8d27578-5d50-4138-9a50-3a55489a4425", "7b314359-86d9-4382-a9af-51ec0b3edc3b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMessage",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a6a4302-12ed-4a32-900b-a3737ac80c7f", "AQAAAAIAAYagAAAAECnx/WJjZx87cKqsdVZUUPu2VfHvkj87iBvlccE3SiLlCeHMllfY/AaVWeZ5hB7K8w==", "464495d5-376f-4b2c-b193-324cca8ee5d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ced06ca-12a2-43ad-a48f-0f4d18fb6e19", "3dc2c0d0-c161-4826-b217-184ac55ea583" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a57fba9f-5e47-4cc4-99c0-e9405b287f72", "f55e97e4-6a69-43a8-90c7-f0c26b556ac0" });
        }
    }
}

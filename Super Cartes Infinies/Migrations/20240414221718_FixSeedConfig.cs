using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff445df3-0d0e-4bc7-a36e-2437606d31e9", "AQAAAAIAAYagAAAAEHgXce56s3b8KQoCYvCWs2DSIri2y8OR5JL0Rmq3JMSuEz6k8BQrqf1wSZLckHbxfQ==", "6ba4afe0-74db-475b-bfcc-93c0228cc486" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abe7792a-6c9f-47ba-a74e-fceeac7c4232", "cc8ee375-84c9-425e-aa78-e5d5a996d766" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7fb09ff-a835-4a61-89d6-15ef747e989c", "61a920e2-22b1-410e-bafb-0f918bb3fbd7" });

            migrationBuilder.UpdateData(
                table: "Config",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NbCarteParDeck", "NbDecks" },
                values: new object[] { 5, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5515313e-ac3a-4e19-a807-f5f004c887e9", "AQAAAAIAAYagAAAAEO1cTvh+4g5FCZhjpdmYZFzxaYQ0+pqSluLGpNWNZcbTLjP1/DsgbHIZ9H/jnX3TCA==", "6edfccba-b794-4753-83df-a167a6b1d78a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a238c81c-e9b4-428d-8d29-e0d7d28e1968", "9b32e817-acff-405e-8138-6e93151847d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00b0d7d7-1e69-4dc9-86b4-bd5d7da81aa8", "490ad87c-4164-4de3-8832-60096a88aaed" });

            migrationBuilder.UpdateData(
                table: "Config",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NbCarteParDeck", "NbDecks" },
                values: new object[] { 0, 0 });
        }
    }
}

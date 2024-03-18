using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class inits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5915dad-3bad-40e4-beab-c1426eb5676f", "AQAAAAIAAYagAAAAEDm1IyMB6qz1eu46agQOCMehKrJV9Qcj+8OoiJBMe9MztOkb69KYWZP+8HAt6TYYRw==", "1f6e9cd6-a9d2-4aff-a840-20b452d60019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5560bc06-1bde-4838-8be8-e6908b67b526", "623aafd6-af4f-40e1-906d-27464a4ab8a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a37ffc8a-3951-4803-864a-b8c3f892a0f2", "b5f6f6e9-ddd3-4cc8-a79d-de3c03cedb2b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed77da77-d8d2-482b-b4d0-a3c705dde63d", "AQAAAAIAAYagAAAAEI+2ASF2P8FpvmHAF1/4ShkIxYKKWClEv1Oedm4zikGGgoNgxPVRS9XzpiC0B+otsw==", "7214d323-8948-4745-b210-6f4fc5677825" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e69d210a-d309-4262-9c4a-2e3f18dafcae", "f633b035-b9ad-432b-83bc-e013495a2423" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "739595df-0d0e-4384-b9e4-86de20f628db", "b1c213f5-4e74-43f2-9581-1624de352190" });
        }
    }
}

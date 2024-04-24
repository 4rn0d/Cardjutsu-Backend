using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Cartes_Infinies.Migrations
{
    /// <inheritdoc />
    public partial class _10players : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User1Id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "User2Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1030293-e485-43b9-8bb4-846989501ca7", "AQAAAAIAAYagAAAAEDW5S+EhhJxJEz+0vM1tWKk+kRWHF/tmHh5XPao4/wL3Th/Fx2p2LfFPqz92M4rXDw==", "be8bf105-5f1f-42f0-9840-793e62f08590" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111112", 0, "0129a83c-99c8-4473-8764-b6928c10b6bc", "player1@aol.com", true, true, null, "PLAYER1@AOL.COM", "PLAYER1@AOL.COM", "AQAAAAIAAYagAAAAEMLhuGz7HN1CkXsrTgtMzymDOmEgkaD78puDTJxzgptCDZZXl0tVYasXqvJSDiKZNg==", null, false, "cb9afd24-8064-4ed7-a746-c2b4546c2e8a", false, "player1@aol.com" },
                    { "11111111-1111-1111-1111-111111111113", 0, "7562015f-cb24-468c-9b3a-2eb06b0f7c06", "player2@aol.com", true, true, null, "PLAYER2@AOL.COM", "PLAYER2@AOL.COM", "AQAAAAIAAYagAAAAELDHJ4UTHjaiicBekpWC7I1eB84GH5DbSv4Wixpkc6aMzkbKR554giT9GoxUUKaVaw==", null, false, "1ff79973-4761-40ac-bb70-dec76f703e39", false, "player2@aol.com" },
                    { "11111111-1111-1111-1111-111111111114", 0, "d6133bd5-341d-49c1-aaf7-f4c0663244d9", "player3@aol.com", true, true, null, "PLAYER3@AOL.COM", "PLAYER3@AOL.COM", "AQAAAAIAAYagAAAAEM7xLNGU5S6y5XsM6Hjb+F7gv8sLEaW3+2VD/Fpev/d3RRezv6BX5hjVKZt0c8dCig==", null, false, "c6bb8e11-599e-4b19-b5f5-f4df0b26fa1d", false, "player3@aol.com" },
                    { "11111111-1111-1111-1111-111111111115", 0, "27a73def-ae73-46c4-97b8-39dafbf27f71", "player4@aol.com", true, true, null, "PLAYER4@AOL.COM", "PLAYER4@AOL.COM", "AQAAAAIAAYagAAAAEJCSStLWpFhBWxAqG+AkfiXNZ++UAqJzM4J7JMCraWwu3JQkveYG8OkrifPQmg1S/w==", null, false, "e6692af3-17a6-4709-a99b-36fbed7dd827", false, "player4@aol.com" },
                    { "11111111-1111-1111-1111-111111111116", 0, "b2c8377b-b65c-4c4a-a481-da867286e791", "player5@aol.com", true, true, null, "PLAYER5@AOL.COM", "PLAYER5@AOL.COM", "AQAAAAIAAYagAAAAEFjVclN/8wiELsLGpJfRYdeKdGRNJulPOwyN2q8zj52XK2+tAV+mw7hFBbWHPOEQ9Q==", null, false, "ec1680b5-e09a-49b1-8964-521f39fe38d8", false, "player5@aol.com" },
                    { "11111111-1111-1111-1111-111111111117", 0, "a9dcaeb3-0785-4ba0-ab26-2e3b1fab703c", "player6@aol.com", true, true, null, "PLAYER6@AOL.COM", "PLAYER6@AOL.COM", "AQAAAAIAAYagAAAAEGweN3P5YNS1qj30kxKIb5sX0GBwBgaocOZsDwi2bek9naKhDVBrrZ9xSrCLDpJcKg==", null, false, "8874f5e5-f338-4af3-9fe2-5961212588c1", false, "player6@aol.com" },
                    { "11111111-1111-1111-1111-111111111118", 0, "a6ad64d2-7991-45f3-ac9f-4c4b8126a994", "player7@aol.com", true, true, null, "PLAYER7@AOL.COM", "PLAYER7@AOL.COM", "AQAAAAIAAYagAAAAEA189l7IpUr6El08H0fLGaWUGu3M1wZLw3oxsvVk1xNF1rdZ4DSxDwpRkpCb/1YoEw==", null, false, "51a34b04-8f72-4e13-af47-587944b721c1", false, "player7@aol.com" },
                    { "11111111-1111-1111-1111-111111111119", 0, "b66eccb3-6627-4223-8700-d6e8e0e8e6ff", "player8@aol.com", true, true, null, "PLAYER8@AOL.COM", "PLAYER8@AOL.COM", "AQAAAAIAAYagAAAAEDLLQM5Dc+PCfj/Oz0hHifHAgcscadd9KE8hEtE/8/IGAmGjORG1E4nSZ+E5K34MuA==", null, false, "eb80812b-3568-447b-8e8e-c5ada80ebdf7", false, "player8@aol.com" },
                    { "11111111-1111-1111-1111-111111111120", 0, "01e7c638-f3b4-4e5f-91bb-903336a02b86", "player9@aol.com", true, true, null, "PLAYER9@AOL.COM", "PLAYER9@AOL.COM", "AQAAAAIAAYagAAAAEKoDa2F727UV47vcxA2h/M5Jm5JIh+i9n1lDwkS/ieYp88r7QxwCFWDnSPyk/4gNdQ==", null, false, "eb98a390-ce90-45d6-92ba-9ddf9b80f92f", false, "player9@aol.com" },
                    { "11111111-1111-1111-1111-111111111121", 0, "333ce92e-63b7-4b58-9d34-ecaf78c5862b", "player10@aol.com", true, true, null, "PLAYER10@AOL.COM", "PLAYER10@AOL.COM", "AQAAAAIAAYagAAAAECobIyob+GULc/r7eLa4rw6d/iThrYiHSqyOMQGm4/1PPi+v51a4FbG50cLyucOqqw==", null, false, "d7aec882-0cc1-4a22-9f56-db2e96ed76e4", false, "player10@aol.com" }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EloScore", "IdentityUserId", "Name" },
                values: new object[] { 2000, "11111111-1111-1111-1111-111111111112", "Pro player" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EloScore", "IdentityUserId", "Name" },
                values: new object[] { 750, "11111111-1111-1111-1111-111111111113", "iWhiff" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "EloScore", "IdentityUserId", "Name" },
                values: new object[,]
                {
                    { 3, 1970, "11111111-1111-1111-1111-111111111114", "GertrudeTTV" },
                    { 4, 600, "11111111-1111-1111-1111-111111111115", "Noob" },
                    { 5, 1000, "11111111-1111-1111-1111-111111111116", "moomz" },
                    { 6, 800, "11111111-1111-1111-1111-111111111117", "pipo" },
                    { 7, 1070, "11111111-1111-1111-1111-111111111118", "GLT" },
                    { 8, 1400, "11111111-1111-1111-1111-111111111119", "Wooo" },
                    { 9, 1500, "11111111-1111-1111-1111-111111111120", "Hibou" },
                    { 10, 1630, "11111111-1111-1111-1111-111111111121", "P10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111114");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111116");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111117");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111120");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111121");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed04ff8e-e96a-4911-9258-01945cf9fed5", "AQAAAAIAAYagAAAAEBPNvonWXJQfxZvmVAlr2VNrNcz5phfPr2Yarz31Z2lG8rnBFv0gPDdlEk9iS1ha4A==", "9b441589-3243-4984-808e-c5cc4deb4bf3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "User1Id", 0, "bf937d10-35fd-4218-b925-3581c7008326", null, false, false, null, null, null, null, null, false, "e2d906ad-5db5-4e13-8602-74a1fdd3ca62", false, null },
                    { "User2Id", 0, "5af4af43-0a70-4efc-8516-7dd7464b5325", null, false, false, null, null, null, null, null, false, "602ff7c5-ab1d-40f5-ab23-9bf2adf154c9", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EloScore", "IdentityUserId", "Name" },
                values: new object[] { 0, "User1Id", "Test player 1" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EloScore", "IdentityUserId", "Name" },
                values: new object[] { 0, "User2Id", "Test player 2" });
        }
    }
}

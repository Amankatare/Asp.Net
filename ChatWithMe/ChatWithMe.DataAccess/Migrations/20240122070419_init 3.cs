using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatWithMe.DataAccess.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "5f641c58-6ef4-4524-90d2-439f05085c51");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "9bed1edc-cf5d-47c7-ab86-a1df05bfe374");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "da764a34-7f49-47d9-a1d6-841e5a3066b6");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "f46166a9-6a44-4bef-8a30-35a4e0fbbc23");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "2e117bf3-bae0-46e3-8cb4-db4ee4d677b4");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "47882e55-76da-4e1f-ade8-f8a345b89420");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "48c6c220-cf21-4130-8c23-90920be34a87");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "6d8d080a-f862-441b-a9dd-e59684bd0011");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "9ed30118-9b83-4de5-b923-8d6776997aa2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f641c58-6ef4-4524-90d2-439f05085c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bed1edc-cf5d-47c7-ab86-a1df05bfe374");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da764a34-7f49-47d9-a1d6-841e5a3066b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f46166a9-6a44-4bef-8a30-35a4e0fbbc23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e117bf3-bae0-46e3-8cb4-db4ee4d677b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47882e55-76da-4e1f-ade8-f8a345b89420");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48c6c220-cf21-4130-8c23-90920be34a87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d8d080a-f862-441b-a9dd-e59684bd0011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ed30118-9b83-4de5-b923-8d6776997aa2");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7be4d40a-cdcf-432e-80bb-0676af279103", "909f449d-5a43-4b97-8cde-f6cfd23aa1f6", "Admin", null },
                    { "cacdb56c-a876-4fe3-8ae2-ef7328588901", "1e5817b2-4b23-48ab-8130-23bd87a75309", "Guest", null },
                    { "e1d50d33-478a-4d6f-8d35-146600498d0a", "f21f3241-45fb-4c7d-b21d-659847f4a86a", "Moderator", null },
                    { "f8a4440f-8019-4372-b871-2dd870ffe14b", "2f370239-a3a1-4ba4-b4c1-3511be1137a1", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "088ed478-882e-4c1a-9c60-02a7ff152b00", 0, "af9cdfb3-3c3b-46d8-946c-b8481e0451a2", "user4@example.com", false, false, null, null, null, null, null, false, "41828331-0d6c-40cb-9361-7a8429fd6a80", false, "user4@example.com" },
                    { "57dd17c9-b5b2-4e04-a4df-0a045ceb5274", 0, "120d0f93-6438-4781-b845-9cb597185bfd", "user2@example.com", false, false, null, null, null, null, null, false, "a8d82ca8-b8c3-491d-aa01-c7ba7751fda1", false, "user2@example.com" },
                    { "9b1234f4-1234-46b0-bde3-b8997d738cc7", 0, "7e9022ed-5eb4-42b4-8220-2280de33c307", "user1@example.com", false, false, null, null, null, null, null, false, "08e0e3e7-7317-439a-a472-b561d84a891c", false, "user1@example.com" },
                    { "c3a417d4-e3a1-43ae-967d-aa57851672d0", 0, "ea3548d8-c07a-4006-b69b-1c45cd27cdc7", "user5@example.com", false, false, null, null, null, null, null, false, "e0ab64a3-5f22-4186-8c12-ba4fd115cda5", false, "user5@example.com" },
                    { "e0210088-829c-4833-8df3-65284cd6cdf0", 0, "cf709f0e-ce46-4367-b461-905dce52f38e", "user3@example.com", false, false, null, null, null, null, null, false, "0a522012-3bc8-48c1-a515-55711f5734e3", false, "user3@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                column: "Id",
                values: new object[]
                {
                    "7be4d40a-cdcf-432e-80bb-0676af279103",
                    "cacdb56c-a876-4fe3-8ae2-ef7328588901",
                    "e1d50d33-478a-4d6f-8d35-146600498d0a",
                    "f8a4440f-8019-4372-b871-2dd870ffe14b"
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                column: "Id",
                values: new object[]
                {
                    "088ed478-882e-4c1a-9c60-02a7ff152b00",
                    "57dd17c9-b5b2-4e04-a4df-0a045ceb5274",
                    "9b1234f4-1234-46b0-bde3-b8997d738cc7",
                    "c3a417d4-e3a1-43ae-967d-aa57851672d0",
                    "e0210088-829c-4833-8df3-65284cd6cdf0"
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AppUserId",
                table: "Messages",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "7be4d40a-cdcf-432e-80bb-0676af279103");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "cacdb56c-a876-4fe3-8ae2-ef7328588901");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "e1d50d33-478a-4d6f-8d35-146600498d0a");

            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "f8a4440f-8019-4372-b871-2dd870ffe14b");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "088ed478-882e-4c1a-9c60-02a7ff152b00");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "57dd17c9-b5b2-4e04-a4df-0a045ceb5274");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "9b1234f4-1234-46b0-bde3-b8997d738cc7");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "c3a417d4-e3a1-43ae-967d-aa57851672d0");

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: "e0210088-829c-4833-8df3-65284cd6cdf0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be4d40a-cdcf-432e-80bb-0676af279103");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cacdb56c-a876-4fe3-8ae2-ef7328588901");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1d50d33-478a-4d6f-8d35-146600498d0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a4440f-8019-4372-b871-2dd870ffe14b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "088ed478-882e-4c1a-9c60-02a7ff152b00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57dd17c9-b5b2-4e04-a4df-0a045ceb5274");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b1234f4-1234-46b0-bde3-b8997d738cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3a417d4-e3a1-43ae-967d-aa57851672d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0210088-829c-4833-8df3-65284cd6cdf0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f641c58-6ef4-4524-90d2-439f05085c51", "6df135d3-b44d-4b34-871c-72f763141475", "Admin", null },
                    { "9bed1edc-cf5d-47c7-ab86-a1df05bfe374", "94b3d35a-5d25-4fe6-a1a8-019a350ff7de", "Guest", null },
                    { "da764a34-7f49-47d9-a1d6-841e5a3066b6", "afeda9ab-96cd-4985-97ed-6c83387cffa3", "Moderator", null },
                    { "f46166a9-6a44-4bef-8a30-35a4e0fbbc23", "885e9f19-32c4-443a-afa2-799f04328ffa", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e117bf3-bae0-46e3-8cb4-db4ee4d677b4", 0, "ff6937f0-a5b5-40de-b189-09daa20d8baa", "user1@example.com", false, false, null, null, null, null, null, false, "39823946-4fcc-43e5-9266-064d55f12289", false, "user1@example.com" },
                    { "47882e55-76da-4e1f-ade8-f8a345b89420", 0, "3e70a1e4-64c7-4a54-bc7a-40c9f08e284f", "user5@example.com", false, false, null, null, null, null, null, false, "002eafc5-d2c9-4e18-9ebd-d5a380e2abfb", false, "user5@example.com" },
                    { "48c6c220-cf21-4130-8c23-90920be34a87", 0, "dcac39d5-ab9f-4b78-9d55-a463c268cc0d", "user3@example.com", false, false, null, null, null, null, null, false, "742b0211-de52-4a17-ac0e-94f9e805c0ec", false, "user3@example.com" },
                    { "6d8d080a-f862-441b-a9dd-e59684bd0011", 0, "71bf37b4-de5e-48d7-b17e-0ec82764bfd2", "user4@example.com", false, false, null, null, null, null, null, false, "c0a5ab6a-9d32-481f-90de-e57fa7aa2f21", false, "user4@example.com" },
                    { "9ed30118-9b83-4de5-b923-8d6776997aa2", 0, "701c1e73-2ef8-44a2-b0c5-eb3a1d119597", "user2@example.com", false, false, null, null, null, null, null, false, "f118bd81-7f41-451b-b433-8ef66059f8ef", false, "user2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                column: "Id",
                values: new object[]
                {
                    "5f641c58-6ef4-4524-90d2-439f05085c51",
                    "9bed1edc-cf5d-47c7-ab86-a1df05bfe374",
                    "da764a34-7f49-47d9-a1d6-841e5a3066b6",
                    "f46166a9-6a44-4bef-8a30-35a4e0fbbc23"
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                column: "Id",
                values: new object[]
                {
                    "2e117bf3-bae0-46e3-8cb4-db4ee4d677b4",
                    "47882e55-76da-4e1f-ade8-f8a345b89420",
                    "48c6c220-cf21-4130-8c23-90920be34a87",
                    "6d8d080a-f862-441b-a9dd-e59684bd0011",
                    "9ed30118-9b83-4de5-b923-8d6776997aa2"
                });
        }
    }
}

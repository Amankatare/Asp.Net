using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatWithMe.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRole_AspNetRoles_Id",
                        column: x => x.Id,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropTable(
                name: "AppUser");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC2.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirmation",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 1,
                column: "PasswordConfirmation",
                value: "Pass123!");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 2,
                column: "PasswordConfirmation",
                value: "SecurePwd456");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 3,
                column: "PasswordConfirmation",
                value: "MySecretPwd789");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 4,
                column: "PasswordConfirmation",
                value: "StrongPwd123");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 5,
                column: "PasswordConfirmation",
                value: "Pwd12345!");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordConfirmation",
                table: "Student");
        }
    }
}

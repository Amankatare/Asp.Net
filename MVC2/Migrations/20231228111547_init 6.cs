using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC2.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { "john.smith@example.com", "John Smith", "Pass123!", "1234567890" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 2,
                columns: new[] { "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { "alice.johnson@example.com", "Alice Johnson", "SecurePwd456", "9876543210" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 3,
                columns: new[] { "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { "bob.miller@example.com", "Bob Miller", "MySecretPwd789", "5551112233" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 4,
                columns: new[] { "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { "emily.davis@example.com", "Emily Davis", "StrongPwd123", "7778889999" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 5,
                columns: new[] { "Email", "Name", "Password", "PhoneNumber" },
                values: new object[] { "michael.lee@example.com", "Michael Lee", "Pwd12345!", "1112223333" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 1,
                columns: new[] { "Email", "Name", "PhoneNumber" },
                values: new object[] { "john@example.com", "John Doe", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 2,
                columns: new[] { "Email", "Name", "PhoneNumber" },
                values: new object[] { "jane@example.com", "Jane Doe", "987-654-3210" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 3,
                columns: new[] { "Email", "Name", "PhoneNumber" },
                values: new object[] { "jane@example.com", "Jane Doe", "987-654-3210" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 4,
                columns: new[] { "Email", "Name", "PhoneNumber" },
                values: new object[] { "alice@example.com", "Alice Smith", "555-123-4567" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "RollNo",
                keyValue: 5,
                columns: new[] { "Email", "Name", "PhoneNumber" },
                values: new object[] { "bob@example.com", "Bob Johnson", "888-555-1234" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNo", "Email", "Name", "PhoneNumber" },
                values: new object[] { 6, "eva@example.com", "Eva Martinez", "777-888-9999" });
        }
    }
}

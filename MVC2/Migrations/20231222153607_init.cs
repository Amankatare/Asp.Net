using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    RollNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.RollNo);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNo", "Email", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John Doe", "123-456-7890" },
                    { 2, "jane@example.com", "Jane Doe", "987-654-3210" },
                    { 3, "jane@example.com", "Jane Doe", "987-654-3210" },
                    { 4, "alice@example.com", "Alice Smith", "555-123-4567" },
                    { 5, "bob@example.com", "Bob Johnson", "888-555-1234" },
                    { 6, "eva@example.com", "Eva Martinez", "777-888-9999" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}

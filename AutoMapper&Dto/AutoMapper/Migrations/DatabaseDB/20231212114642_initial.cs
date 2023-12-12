using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMapper_Dto.Migrations.DatabaseDB
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 1, "Building A", "Human Resources" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 2, "Data Center", "IT Department" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 3, "Floor 5", "Marketing" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DepartmentId", "Email", "Name", "Phone", "Salary" },
                values: new object[] { 1, 1, "john.doe@example.com", "John Doe", "123-456-7890", 50000.00m });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DepartmentId", "Email", "Name", "Phone", "Salary" },
                values: new object[] { 2, 2, "jane.smith@example.com", "Jane Smith", "987-654-3210", 60000.00m });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "DepartmentId", "Email", "Name", "Phone", "Salary" },
                values: new object[] { 3, 1, "bob.johnson@example.com", "Bob Johnson", "555-123-4567", 75000.00m });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}

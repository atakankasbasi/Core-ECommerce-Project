using Microsoft.EntityFrameworkCore.Migrations;

namespace SpryStore.DataAccessLayer.Migrations
{
    public partial class employeeregu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeImage",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmployeeStatus",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeImage",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "Employees");
        }
    }
}

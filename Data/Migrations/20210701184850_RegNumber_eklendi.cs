using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAssignment.Data.Migrations
{
    public partial class RegNumber_eklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegNumber",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNumber",
                table: "Student");
        }
    }
}

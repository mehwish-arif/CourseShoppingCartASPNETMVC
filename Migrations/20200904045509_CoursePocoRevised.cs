using Microsoft.EntityFrameworkCore.Migrations;

namespace CouseCatalogueMVC.Migrations
{
    public partial class CoursePocoRevised : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFreeThisWeek",
                table: "Courses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFreeThisWeek",
                table: "Courses");
        }
    }
}

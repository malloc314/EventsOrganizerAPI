using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsOrganizer.Migrations
{
    public partial class NoRequiredAddCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLimit",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLimit",
                table: "Events");
        }
    }
}

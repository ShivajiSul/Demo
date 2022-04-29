using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCAPP_Core.Migrations
{
    public partial class shiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cast",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Person");
        }
    }
}

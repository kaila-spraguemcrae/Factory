using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class RemoveFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Engineers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Engineers",
                nullable: true);
        }
    }
}

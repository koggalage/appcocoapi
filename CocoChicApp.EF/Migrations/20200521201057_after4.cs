using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class after4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RelativeName",
                table: "Tbl_ConsentFormDaily",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelativeName",
                table: "Tbl_ConsentFormDaily");
        }
    }
}

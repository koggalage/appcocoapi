using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class custafter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFilledInitConcern",
                table: "Tbl_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SignatureURL",
                table: "Tbl_Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFilledInitConcern",
                table: "Tbl_Customer");

            migrationBuilder.DropColumn(
                name: "SignatureURL",
                table: "Tbl_Customer");
        }
    }
}

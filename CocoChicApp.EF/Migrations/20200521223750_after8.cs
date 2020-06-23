using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class after8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ConsentBy",
                table: "Tbl_ConsentFormDaily",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ConsentBy",
                table: "Tbl_ConsentFormDaily",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

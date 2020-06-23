using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class after10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAnySkinTreatment",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsAnySkinTreatment",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}

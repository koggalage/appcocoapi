using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegNo",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "RegNo",
                table: "Tbl_TreatmentDailyUpdate",
                newName: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                newName: "RegNo");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Tbl_TreatmentDailyUpdate",
                newName: "RegNo");
        }
    }
}

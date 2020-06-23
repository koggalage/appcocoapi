using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class after6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.DropColumn(
                name: "TherapistName",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Tbl_ConsentFormDaily",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TherapistId",
                table: "Tbl_ConsentFormDaily",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.DropColumn(
                name: "TherapistId",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "Tbl_ConsentFormDaily",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TherapistName",
                table: "Tbl_ConsentFormDaily",
                nullable: true);
        }
    }
}

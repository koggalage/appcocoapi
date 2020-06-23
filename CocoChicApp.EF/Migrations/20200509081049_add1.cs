using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class add1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdate",
                columns: table => new
                {
                    Tduid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegNo = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Problem = table.Column<string>(nullable: true),
                    DoctorNote = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    IsSkinCare = table.Column<bool>(nullable: true),
                    IsSalon = table.Column<bool>(nullable: true),
                    IsHair = table.Column<bool>(nullable: true),
                    IsSpa = table.Column<bool>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: true),
                    DoctorAppointmentId = table.Column<int>(nullable: true),
                    ServiceAppointmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdate", x => x.Tduid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tduid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tduid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tduid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tduid",
                principalTable: "Tbl_TreatmentDailyUpdate",
                principalColumn: "Tduid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tduid",
                table: "Tbl_TreatmentDailyUpdatePhotos");

            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdate");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tduid",
                table: "Tbl_TreatmentDailyUpdatePhotos");
        }
    }
}

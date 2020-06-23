using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class brdropw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdatePhotos");

            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdate",
                columns: table => new
                {
                    Tduid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BranchId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    DoctorAppointmentId = table.Column<int>(nullable: true),
                    DoctorNote = table.Column<string>(nullable: true),
                    IsHair = table.Column<bool>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: true),
                    IsSalon = table.Column<bool>(nullable: true),
                    IsSkinCare = table.Column<bool>(nullable: true),
                    IsSpa = table.Column<bool>(nullable: true),
                    Problem = table.Column<string>(nullable: true),
                    RegNo = table.Column<string>(nullable: true),
                    ServiceAppointmentId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdate", x => x.Tduid);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdatePhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(nullable: true),
                    RegNo = table.Column<string>(nullable: true),
                    Tduid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdatePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tduid",
                        column: x => x.Tduid,
                        principalTable: "Tbl_TreatmentDailyUpdate",
                        principalColumn: "Tduid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tduid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tduid");
        }
    }
}

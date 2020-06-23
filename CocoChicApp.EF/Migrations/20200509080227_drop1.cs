using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class drop1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos");

            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdate");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos");

            migrationBuilder.DropColumn(
                name: "Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdate",
                columns: table => new
                {
                    Cfid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConsentBy = table.Column<string>(nullable: true),
                    ConsentDatetime = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    DoctorName = table.Column<string>(nullable: true),
                    Etime = table.Column<TimeSpan>(nullable: false),
                    ExplainedBy = table.Column<string>(nullable: true),
                    IsClientSigned = table.Column<bool>(nullable: false),
                    IsDoctorSinged = table.Column<bool>(nullable: false),
                    IsTherapistSigned = table.Column<bool>(nullable: false),
                    NameOfTheTreatment = table.Column<string>(nullable: true),
                    Nic = table.Column<string>(nullable: true),
                    PreviousListOfTreatment = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    Stime = table.Column<TimeSpan>(nullable: false),
                    TherapistName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdate", x => x.Cfid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tbl_TreatmentDailyUpdateCfid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tbl_TreatmentDailyUpdateCfid",
                principalTable: "Tbl_TreatmentDailyUpdate",
                principalColumn: "Cfid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class beforeconcent6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdate",
                columns: table => new
                {
                    Cfid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(nullable: true),
                    ConsentDatetime = table.Column<DateTime>(nullable: false),
                    Nic = table.Column<string>(nullable: true),
                    NameOfTheTreatment = table.Column<string>(nullable: true),
                    PreviousListOfTreatment = table.Column<string>(nullable: true),
                    ExplainedBy = table.Column<string>(nullable: true),
                    ConsentBy = table.Column<string>(nullable: true),
                    Relationship = table.Column<string>(nullable: true),
                    IsClientSigned = table.Column<bool>(nullable: false),
                    TherapistName = table.Column<string>(nullable: true),
                    IsTherapistSigned = table.Column<bool>(nullable: false),
                    Stime = table.Column<TimeSpan>(nullable: false),
                    Etime = table.Column<TimeSpan>(nullable: false),
                    DoctorName = table.Column<string>(nullable: true),
                    IsDoctorSinged = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdate", x => x.Cfid);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TreatmentDailyUpdatePhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tduid = table.Column<int>(nullable: false),
                    RegNo = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Tbl_TreatmentDailyUpdateCfid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TreatmentDailyUpdatePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdate_Tbl_TreatmentDailyUpdateCfid",
                        column: x => x.Tbl_TreatmentDailyUpdateCfid,
                        principalTable: "Tbl_TreatmentDailyUpdate",
                        principalColumn: "Cfid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TreatmentDailyUpdatePhotos_Tbl_TreatmentDailyUpdateCfid",
                table: "Tbl_TreatmentDailyUpdatePhotos",
                column: "Tbl_TreatmentDailyUpdateCfid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdatePhotos");

            migrationBuilder.DropTable(
                name: "Tbl_TreatmentDailyUpdate");
        }
    }
}

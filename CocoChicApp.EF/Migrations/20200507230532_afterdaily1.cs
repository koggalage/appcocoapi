using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class afterdaily1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_ConsentFormDaily",
                columns: table => new
                {
                    Cfdid = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Tbl_ConsentFormDaily", x => x.Cfdid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_ConsentFormDaily");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class beforeconcent5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_ConsentFormIniti",
                columns: table => new
                {
                    Cfid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(nullable: true),
                    IsDiabetes = table.Column<bool>(nullable: true),
                    IsHypertension = table.Column<bool>(nullable: true),
                    IsHeartDisease = table.Column<bool>(nullable: true),
                    IsAsthma = table.Column<bool>(nullable: true),
                    IsSinuitis = table.Column<bool>(nullable: true),
                    IsHyperlipidemia = table.Column<bool>(nullable: true),
                    IsOther = table.Column<bool>(nullable: true),
                    IsSurgical = table.Column<string>(nullable: true),
                    IsMarried = table.Column<string>(nullable: true),
                    IsSmoking = table.Column<string>(nullable: true),
                    IsAlcoholic = table.Column<string>(nullable: true),
                    CurrentMedication = table.Column<string>(nullable: true),
                    IsAllergies = table.Column<string>(nullable: true),
                    IsMenstrualAbnormalities = table.Column<string>(nullable: true),
                    CurrentlyUsedProduct = table.Column<string>(nullable: true),
                    IsAnySkinTreatment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ConsentFormIniti", x => x.Cfid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_ConsentFormIniti");
        }
    }
}

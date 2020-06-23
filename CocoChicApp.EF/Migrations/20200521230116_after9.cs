using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CocoChicApp.EF.Migrations
{
    public partial class after9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etime",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.DropColumn(
                name: "Stime",
                table: "Tbl_ConsentFormDaily");

            migrationBuilder.AlterColumn<bool>(
                name: "IsSurgical",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsSmoking",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMenstrualAbnormalities",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsMarried",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAllergies",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAlcoholic",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsentBy",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConsentDatetime",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsClientSigned",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDoctorSinged",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTherapistSigned",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KnownAllergies",
                table: "Tbl_ConsentFormIniti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MenstrualAbnormalities",
                table: "Tbl_ConsentFormIniti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherDiseases",
                table: "Tbl_ConsentFormIniti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviousSkinTreatments",
                table: "Tbl_ConsentFormIniti",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurgicalHistory",
                table: "Tbl_ConsentFormIniti",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapistId",
                table: "Tbl_ConsentFormIniti",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsentBy",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "ConsentDatetime",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "IsClientSigned",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "IsDoctorSinged",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "IsTherapistSigned",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "KnownAllergies",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "MenstrualAbnormalities",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "OtherDiseases",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "PreviousSkinTreatments",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "SurgicalHistory",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.DropColumn(
                name: "TherapistId",
                table: "Tbl_ConsentFormIniti");

            migrationBuilder.AlterColumn<string>(
                name: "IsSurgical",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsSmoking",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsMenstrualAbnormalities",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsMarried",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsAllergies",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsAlcoholic",
                table: "Tbl_ConsentFormIniti",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Etime",
                table: "Tbl_ConsentFormDaily",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Stime",
                table: "Tbl_ConsentFormDaily",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}

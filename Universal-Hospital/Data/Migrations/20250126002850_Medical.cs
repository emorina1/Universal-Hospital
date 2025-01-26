using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universal_Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class Medical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalStaff_Departament_DepartamentId",
                table: "MedicalStaff");

            migrationBuilder.DropIndex(
                name: "IX_MedicalStaff_DepartamentId",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "MedicalStaff");

            migrationBuilder.RenameColumn(
                name: "MedicalStaffId",
                table: "MedicalStaff",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "MedicalStaff",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "MedicalStaff",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "MedicalStaff",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmploymentDate",
                table: "MedicalStaff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "MedicalStaff",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "MedicalStaff",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "EmploymentDate",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "MedicalStaff");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "MedicalStaff");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MedicalStaff",
                newName: "MedicalStaffId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "MedicalStaff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "MedicalStaff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "MedicalStaff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MedicalStaff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "MedicalStaff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalStaff_DepartamentId",
                table: "MedicalStaff",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalStaff_Departament_DepartamentId",
                table: "MedicalStaff",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "DepartamentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

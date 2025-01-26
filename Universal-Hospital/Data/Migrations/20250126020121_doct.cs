using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universal_Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class doct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Departament_DepartamentId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_DepartamentId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Specialty",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctor",
                newName: "IdD");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "IdD",
                table: "Doctor",
                newName: "DoctorId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Doctor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Specialty",
                table: "Doctor",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartamentId",
                table: "Doctor",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Departament_DepartamentId",
                table: "Doctor",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "DepartamentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

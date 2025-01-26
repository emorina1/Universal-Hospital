using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universal_Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class elsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Time_Doctor_DoctorId",
                table: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Time_DoctorId",
                table: "Time");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Time",
                newName: "IdD");

            migrationBuilder.RenameColumn(
                name: "TimetableId",
                table: "Time",
                newName: "TimeId");

            migrationBuilder.AddColumn<int>(
                name: "DoctorIdD",
                table: "Time",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShiftType",
                table: "Time",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Time_DoctorIdD",
                table: "Time",
                column: "DoctorIdD");

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Doctor_DoctorIdD",
                table: "Time",
                column: "DoctorIdD",
                principalTable: "Doctor",
                principalColumn: "IdD",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Time_Doctor_DoctorIdD",
                table: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Time_DoctorIdD",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "DoctorIdD",
                table: "Time");

            migrationBuilder.DropColumn(
                name: "ShiftType",
                table: "Time");

            migrationBuilder.RenameColumn(
                name: "IdD",
                table: "Time",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "TimeId",
                table: "Time",
                newName: "TimetableId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_DoctorId",
                table: "Time",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Time_Doctor_DoctorId",
                table: "Time",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "IdD",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

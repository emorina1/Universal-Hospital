using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universal_Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Timetable");

            migrationBuilder.DropColumn(
                name: "ShiftType",
                table: "Timetable");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Timetable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Timetable_DepartamentId",
                table: "Timetable",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timetable_Departament_DepartamentId",
                table: "Timetable",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "DepartamentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timetable_Departament_DepartamentId",
                table: "Timetable");

            migrationBuilder.DropIndex(
                name: "IX_Timetable_DepartamentId",
                table: "Timetable");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Timetable");

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                table: "Timetable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShiftType",
                table: "Timetable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

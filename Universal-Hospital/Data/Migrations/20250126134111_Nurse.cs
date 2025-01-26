using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Universal_Hospital.Data.Migrations
{
    /// <inheritdoc />
    public partial class Nurse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nurse_Departament_DepartamentId",
                table: "Nurse");

            migrationBuilder.DropIndex(
                name: "IX_Nurse_DepartamentId",
                table: "Nurse");

            migrationBuilder.AddColumn<string>(
                name: "DepartamentName",
                table: "Nurse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartamentName",
                table: "Nurse");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_DepartamentId",
                table: "Nurse",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurse_Departament_DepartamentId",
                table: "Nurse",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "DepartamentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

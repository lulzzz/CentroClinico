using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class AppointmentSpecialityCollumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_specialties_SpecialityID",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "SpecialityID",
                table: "appointments",
                newName: "speciality_id");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_SpecialityID",
                table: "appointments",
                newName: "IX_appointments_speciality_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_specialties_speciality_id",
                table: "appointments",
                column: "speciality_id",
                principalTable: "specialties",
                principalColumn: "speciality_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_specialties_speciality_id",
                table: "appointments");

            migrationBuilder.RenameColumn(
                name: "speciality_id",
                table: "appointments",
                newName: "SpecialityID");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_speciality_id",
                table: "appointments",
                newName: "IX_appointments_SpecialityID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_specialties_SpecialityID",
                table: "appointments",
                column: "SpecialityID",
                principalTable: "specialties",
                principalColumn: "speciality_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

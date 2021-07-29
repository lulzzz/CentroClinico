using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class AppointmentSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SpecialityID",
                table: "appointments",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_SpecialityID",
                table: "appointments",
                column: "SpecialityID");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_specialties_SpecialityID",
                table: "appointments",
                column: "SpecialityID",
                principalTable: "specialties",
                principalColumn: "speciality_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_specialties_SpecialityID",
                table: "appointments");

            migrationBuilder.DropIndex(
                name: "IX_appointments_SpecialityID",
                table: "appointments");

            migrationBuilder.DropColumn(
                name: "SpecialityID",
                table: "appointments");
        }
    }
}

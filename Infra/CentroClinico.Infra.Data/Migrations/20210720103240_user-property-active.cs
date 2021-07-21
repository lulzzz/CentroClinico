using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class userpropertyactive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctor_speciality_doctors_speciality_id",
                table: "doctor_speciality");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_speciality_specialties_doctor_id",
                table: "doctor_speciality");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_doctors_unity_id",
                table: "doctor_unity");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_unities_doctor_id",
                table: "doctor_unity");

            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_speciality_doctors_doctor_id",
                table: "doctor_speciality",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_speciality_specialties_speciality_id",
                table: "doctor_speciality",
                column: "speciality_id",
                principalTable: "specialties",
                principalColumn: "speciality_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_unity_doctors_doctor_id",
                table: "doctor_unity",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_unity_unities_unity_id",
                table: "doctor_unity",
                column: "unity_id",
                principalTable: "unities",
                principalColumn: "unity_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctor_speciality_doctors_doctor_id",
                table: "doctor_speciality");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_speciality_specialties_speciality_id",
                table: "doctor_speciality");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_doctors_doctor_id",
                table: "doctor_unity");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_unities_unity_id",
                table: "doctor_unity");

            migrationBuilder.DropColumn(
                name: "active",
                table: "users");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_speciality_doctors_speciality_id",
                table: "doctor_speciality",
                column: "speciality_id",
                principalTable: "doctors",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_speciality_specialties_doctor_id",
                table: "doctor_speciality",
                column: "doctor_id",
                principalTable: "specialties",
                principalColumn: "speciality_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_unity_doctors_unity_id",
                table: "doctor_unity",
                column: "unity_id",
                principalTable: "doctors",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_unity_unities_doctor_id",
                table: "doctor_unity",
                column: "doctor_id",
                principalTable: "unities",
                principalColumn: "unity_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

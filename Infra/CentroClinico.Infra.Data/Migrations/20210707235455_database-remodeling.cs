using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class databaseremodeling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Unities_UnityID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Users_UserID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Unities_UnityID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_UserID",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorUnities_Doctors_DoctorID",
                table: "DoctorUnities");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorUnities_Unities_UnityID",
                table: "DoctorUnities");

            migrationBuilder.DropForeignKey(
                name: "FK_Employeies_Users_UserID",
                table: "Employeies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Unities_UnityID",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "DoctorSpecialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Unities",
                table: "Unities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeies",
                table: "Employeies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UnityID",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorUnities",
                table: "DoctorUnities");

            migrationBuilder.DropIndex(
                name: "IX_DoctorUnities_UnityID",
                table: "DoctorUnities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UnityID",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Unities",
                newName: "unities");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "specialties");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "rooms");

            migrationBuilder.RenameTable(
                name: "Employeies",
                newName: "employeies");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "doctors");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "appointments");

            migrationBuilder.RenameTable(
                name: "DoctorUnities",
                newName: "doctor_unity");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "custumers");

            migrationBuilder.RenameColumn(
                name: "Profile",
                table: "users",
                newName: "profile");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "users",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "unities",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "unities",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "unities",
                newName: "house_number");

            migrationBuilder.RenameColumn(
                name: "AdditionalInfo",
                table: "unities",
                newName: "additional_info");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "unities",
                newName: "unity_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "specialties",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "specialties",
                newName: "speciality_id");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "rooms",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "Floor",
                table: "rooms",
                newName: "floor");

            migrationBuilder.RenameColumn(
                name: "UnityID",
                table: "rooms",
                newName: "unity_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "rooms",
                newName: "room_id");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_UnityID",
                table: "rooms",
                newName: "IX_rooms_unity_id");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "employeies",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "employeies",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "employeies",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "employeies",
                newName: "house_number");

            migrationBuilder.RenameColumn(
                name: "AdditionalInfo",
                table: "employeies",
                newName: "additional_info");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "employeies",
                newName: "employee_id");

            migrationBuilder.RenameIndex(
                name: "IX_Employeies_UserID",
                table: "employeies",
                newName: "IX_employeies_user_id");

            migrationBuilder.RenameColumn(
                name: "CRM",
                table: "doctors",
                newName: "crm");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "doctors",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "doctors",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "doctors",
                newName: "doctor_id");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_UserID",
                table: "doctors",
                newName: "IX_doctors_user_id");

            migrationBuilder.RenameColumn(
                name: "UnityID",
                table: "appointments",
                newName: "unity_id");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "appointments",
                newName: "doctor_id");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "appointments",
                newName: "date_time");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "appointments",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "appointments",
                newName: "appointment_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_UnityID",
                table: "appointments",
                newName: "IX_appointments_unity_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorID",
                table: "appointments",
                newName: "IX_appointments_doctor_id");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_CustomerID",
                table: "appointments",
                newName: "IX_appointments_customer_id");

            migrationBuilder.RenameColumn(
                name: "UnityID",
                table: "doctor_unity",
                newName: "unity_id");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "doctor_unity",
                newName: "doctor_id");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorUnities_DoctorID",
                table: "doctor_unity",
                newName: "IX_doctor_unity_doctor_id");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "custumers",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "InsurancePlan",
                table: "custumers",
                newName: "insurance_plan");

            migrationBuilder.RenameColumn(
                name: "InsuranceCompany",
                table: "custumers",
                newName: "insurance_company");

            migrationBuilder.RenameColumn(
                name: "InsuranceCardNumber",
                table: "custumers",
                newName: "insurance_card_number");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "custumers",
                newName: "custumer_id");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_UserID",
                table: "custumers",
                newName: "IX_custumers_user_id");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "users",
                type: "varchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "users",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "unities",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "unities",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "house_number",
                table: "unities",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "additional_info",
                table: "unities",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "specialties",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "employeies",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "employeies",
                type: "varchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "house_number",
                table: "employeies",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "additional_info",
                table: "employeies",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "crm",
                table: "doctors",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "doctors",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "insurance_plan",
                table: "custumers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "insurance_company",
                table: "custumers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "insurance_card_number",
                table: "custumers",
                type: "varchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_unities",
                table: "unities",
                column: "unity_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_specialties",
                table: "specialties",
                column: "speciality_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rooms",
                table: "rooms",
                column: "room_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeies",
                table: "employeies",
                column: "employee_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                table: "doctors",
                column: "doctor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                column: "appointment_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctor_unity",
                table: "doctor_unity",
                columns: new[] { "unity_id", "doctor_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_custumers",
                table: "custumers",
                column: "custumer_id");

            migrationBuilder.CreateTable(
                name: "doctor_speciality",
                columns: table => new
                {
                    doctor_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    speciality_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_speciality", x => new { x.doctor_id, x.speciality_id });
                    table.ForeignKey(
                        name: "FK_doctor_speciality_doctors_speciality_id",
                        column: x => x.speciality_id,
                        principalTable: "doctors",
                        principalColumn: "doctor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doctor_speciality_specialties_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "specialties",
                        principalColumn: "speciality_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_speciality_speciality_id",
                table: "doctor_speciality",
                column: "speciality_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_custumers_customer_id",
                table: "appointments",
                column: "customer_id",
                principalTable: "custumers",
                principalColumn: "custumer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "doctor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_unities_unity_id",
                table: "appointments",
                column: "unity_id",
                principalTable: "unities",
                principalColumn: "unity_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_custumers_users_user_id",
                table: "custumers",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
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

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_users_user_id",
                table: "doctors",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employeies_users_user_id",
                table: "employeies",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_unities_unity_id",
                table: "rooms",
                column: "unity_id",
                principalTable: "unities",
                principalColumn: "unity_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_custumers_customer_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_doctor_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_unities_unity_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_custumers_users_user_id",
                table: "custumers");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_doctors_unity_id",
                table: "doctor_unity");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_unity_unities_doctor_id",
                table: "doctor_unity");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_users_user_id",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_employeies_users_user_id",
                table: "employeies");

            migrationBuilder.DropForeignKey(
                name: "FK_rooms_unities_unity_id",
                table: "rooms");

            migrationBuilder.DropTable(
                name: "doctor_speciality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_unities",
                table: "unities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_specialties",
                table: "specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rooms",
                table: "rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employeies",
                table: "employeies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctor_unity",
                table: "doctor_unity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_custumers",
                table: "custumers");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "unities",
                newName: "Unities");

            migrationBuilder.RenameTable(
                name: "specialties",
                newName: "Specialties");

            migrationBuilder.RenameTable(
                name: "rooms",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "employeies",
                newName: "Employeies");

            migrationBuilder.RenameTable(
                name: "doctors",
                newName: "Doctors");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "Appointments");

            migrationBuilder.RenameTable(
                name: "doctor_unity",
                newName: "DoctorUnities");

            migrationBuilder.RenameTable(
                name: "custumers",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "profile",
                table: "Users",
                newName: "Profile");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Users",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Unities",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Unities",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "house_number",
                table: "Unities",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "additional_info",
                table: "Unities",
                newName: "AdditionalInfo");

            migrationBuilder.RenameColumn(
                name: "unity_id",
                table: "Unities",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Specialties",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "speciality_id",
                table: "Specialties",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Rooms",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "floor",
                table: "Rooms",
                newName: "Floor");

            migrationBuilder.RenameColumn(
                name: "unity_id",
                table: "Rooms",
                newName: "UnityID");

            migrationBuilder.RenameColumn(
                name: "room_id",
                table: "Rooms",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_unity_id",
                table: "Rooms",
                newName: "IX_Rooms_UnityID");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Employeies",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Employeies",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Employeies",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "house_number",
                table: "Employeies",
                newName: "HouseNumber");

            migrationBuilder.RenameColumn(
                name: "additional_info",
                table: "Employeies",
                newName: "AdditionalInfo");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employeies",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_employeies_user_id",
                table: "Employeies",
                newName: "IX_Employeies_UserID");

            migrationBuilder.RenameColumn(
                name: "crm",
                table: "Doctors",
                newName: "CRM");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Doctors",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Doctors",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "doctor_id",
                table: "Doctors",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_user_id",
                table: "Doctors",
                newName: "IX_Doctors_UserID");

            migrationBuilder.RenameColumn(
                name: "unity_id",
                table: "Appointments",
                newName: "UnityID");

            migrationBuilder.RenameColumn(
                name: "doctor_id",
                table: "Appointments",
                newName: "DoctorID");

            migrationBuilder.RenameColumn(
                name: "date_time",
                table: "Appointments",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Appointments",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "appointment_id",
                table: "Appointments",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_unity_id",
                table: "Appointments",
                newName: "IX_Appointments_UnityID");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_doctor_id",
                table: "Appointments",
                newName: "IX_Appointments_DoctorID");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_customer_id",
                table: "Appointments",
                newName: "IX_Appointments_CustomerID");

            migrationBuilder.RenameColumn(
                name: "doctor_id",
                table: "DoctorUnities",
                newName: "DoctorID");

            migrationBuilder.RenameColumn(
                name: "unity_id",
                table: "DoctorUnities",
                newName: "UnityID");

            migrationBuilder.RenameIndex(
                name: "IX_doctor_unity_doctor_id",
                table: "DoctorUnities",
                newName: "IX_DoctorUnities_DoctorID");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Customers",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "insurance_plan",
                table: "Customers",
                newName: "InsurancePlan");

            migrationBuilder.RenameColumn(
                name: "insurance_company",
                table: "Customers",
                newName: "InsuranceCompany");

            migrationBuilder.RenameColumn(
                name: "insurance_card_number",
                table: "Customers",
                newName: "InsuranceCardNumber");

            migrationBuilder.RenameColumn(
                name: "custumer_id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_custumers_user_id",
                table: "Customers",
                newName: "IX_Customers_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(12)",
                oldMaxLength: 12)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Unities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Unities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldMaxLength: 8)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HouseNumber",
                table: "Unities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalInfo",
                table: "Unities",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Specialties",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Employeies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Employeies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldMaxLength: 8)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "HouseNumber",
                table: "Employeies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalInfo",
                table: "Employeies",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CRM",
                table: "Doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Doctors",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UnityID",
                table: "Doctors",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "InsurancePlan",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceCompany",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceCardNumber",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Unities",
                table: "Unities",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeies",
                table: "Employeies",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorUnities",
                table: "DoctorUnities",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "DoctorSpecialties",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DoctorID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SpecialtyID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecialties", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialties_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialties_Specialties_SpecialtyID",
                        column: x => x.SpecialtyID,
                        principalTable: "Specialties",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UnityID",
                table: "Doctors",
                column: "UnityID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorUnities_UnityID",
                table: "DoctorUnities",
                column: "UnityID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialties_DoctorID",
                table: "DoctorSpecialties",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialties_SpecialtyID",
                table: "DoctorSpecialties",
                column: "SpecialtyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerID",
                table: "Appointments",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Unities_UnityID",
                table: "Appointments",
                column: "UnityID",
                principalTable: "Unities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Users_UserID",
                table: "Customers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Unities_UnityID",
                table: "Doctors",
                column: "UnityID",
                principalTable: "Unities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_UserID",
                table: "Doctors",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorUnities_Doctors_DoctorID",
                table: "DoctorUnities",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorUnities_Unities_UnityID",
                table: "DoctorUnities",
                column: "UnityID",
                principalTable: "Unities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employeies_Users_UserID",
                table: "Employeies",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Unities_UnityID",
                table: "Rooms",
                column: "UnityID",
                principalTable: "Unities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

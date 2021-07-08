using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class employeetypofix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeies_users_user_id",
                table: "employeies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employeies",
                table: "employeies");

            migrationBuilder.RenameTable(
                name: "employeies",
                newName: "employees");

            migrationBuilder.RenameIndex(
                name: "IX_employeies_user_id",
                table: "employees",
                newName: "IX_employees_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "employee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_users_user_id",
                table: "employees",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_users_user_id",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "employeies");

            migrationBuilder.RenameIndex(
                name: "IX_employees_user_id",
                table: "employeies",
                newName: "IX_employeies_user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeies",
                table: "employeies",
                column: "employee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employeies_users_user_id",
                table: "employeies",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

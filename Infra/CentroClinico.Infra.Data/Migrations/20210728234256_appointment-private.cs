using Microsoft.EntityFrameworkCore.Migrations;

namespace CentroClinico.Infra.Data.Migrations
{
    public partial class appointmentprivate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "private",
                table: "appointments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "private",
                table: "appointments");
        }
    }
}

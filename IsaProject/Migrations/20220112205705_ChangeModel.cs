using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class ChangeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointmentSeparates");

            migrationBuilder.DropColumn(
                name: "ChoosenByUser",
                table: "AppointmentTag");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "isScheduled",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "isSeparated",
                table: "Appointments");

            migrationBuilder.AddColumn<long>(
                name: "ScheduleAppointmentId",
                table: "AppointmentTag",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScheduleAppointmentId",
                table: "AppointmentTag");

            migrationBuilder.AddColumn<bool>(
                name: "ChoosenByUser",
                table: "AppointmentTag",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isScheduled",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSeparated",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "appointmentSeparates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentID = table.Column<long>(type: "bigint", nullable: false),
                    AppointmentNewID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointmentSeparates", x => x.Id);
                });
        }
    }
}

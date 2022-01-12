using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class ChangeModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ScheduledAppointmentId",
                table: "AppointmentTag",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "scheduledAppointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityID = table.Column<long>(type: "bigint", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduledAppointments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentTag_ScheduledAppointmentId",
                table: "AppointmentTag",
                column: "ScheduledAppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentTag_scheduledAppointments_ScheduledAppointmentId",
                table: "AppointmentTag",
                column: "ScheduledAppointmentId",
                principalTable: "scheduledAppointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentTag_scheduledAppointments_ScheduledAppointmentId",
                table: "AppointmentTag");

            migrationBuilder.DropTable(
                name: "scheduledAppointments");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentTag_ScheduledAppointmentId",
                table: "AppointmentTag");

            migrationBuilder.DropColumn(
                name: "ScheduledAppointmentId",
                table: "AppointmentTag");
        }
    }
}

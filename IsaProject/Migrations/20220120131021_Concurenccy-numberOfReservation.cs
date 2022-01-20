using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class ConcurenccynumberOfReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Appointments_AppointmentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppointmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "numberOfReservation",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberOfReservation",
                table: "Appointments");

            migrationBuilder.AddColumn<long>(
                name: "AppointmentId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppointmentId",
                table: "AspNetUsers",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Appointments_AppointmentId",
                table: "AspNetUsers",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

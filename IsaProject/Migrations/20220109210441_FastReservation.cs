using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class FastReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_CottageAppointmentDTOId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "CottageAppointmentDTOId",
                table: "Tags",
                newName: "AppointmentDTOId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_CottageAppointmentDTOId",
                table: "Tags",
                newName: "IX_Tags_AppointmentDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentTag_AppointmentID",
                table: "AppointmentTag",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentTag_Appointments_AppointmentID",
                table: "AppointmentTag",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_AppointmentDTOId",
                table: "Tags",
                column: "AppointmentDTOId",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentTag_Appointments_AppointmentID",
                table: "AppointmentTag");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_AppointmentDTOId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentTag_AppointmentID",
                table: "AppointmentTag");

            migrationBuilder.RenameColumn(
                name: "AppointmentDTOId",
                table: "Tags",
                newName: "CottageAppointmentDTOId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_AppointmentDTOId",
                table: "Tags",
                newName: "IX_Tags_CottageAppointmentDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_CottageAppointmentDTOId",
                table: "Tags",
                column: "CottageAppointmentDTOId",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

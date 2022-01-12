using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag");

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentDTOID",
                table: "AppointmentTag",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag",
                column: "AppointmentDTOID",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag");

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentDTOID",
                table: "AppointmentTag",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag",
                column: "AppointmentDTOID",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

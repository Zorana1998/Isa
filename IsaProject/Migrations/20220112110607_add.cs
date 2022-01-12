using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_AppointmentDTOId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_AppointmentDTOId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "AppointmentDTOId",
                table: "Tags");

            migrationBuilder.AddColumn<long>(
                name: "AppointmentDTOID",
                table: "AppointmentTag",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentTag_AppointmentDTOID",
                table: "AppointmentTag",
                column: "AppointmentDTOID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag",
                column: "AppointmentDTOID",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentTag_cottageAppointmentDTOs_AppointmentDTOID",
                table: "AppointmentTag");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentTag_AppointmentDTOID",
                table: "AppointmentTag");

            migrationBuilder.DropColumn(
                name: "AppointmentDTOID",
                table: "AppointmentTag");

            migrationBuilder.AddColumn<long>(
                name: "AppointmentDTOId",
                table: "Tags",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_AppointmentDTOId",
                table: "Tags",
                column: "AppointmentDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_cottageAppointmentDTOs_AppointmentDTOId",
                table: "Tags",
                column: "AppointmentDTOId",
                principalTable: "cottageAppointmentDTOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

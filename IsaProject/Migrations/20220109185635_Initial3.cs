using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Appointments_AppointmentID",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "isChoosen",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "AppointmentID",
                table: "Tags",
                newName: "AppointmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_AppointmentID",
                table: "Tags",
                newName: "IX_Tags_AppointmentId");

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentId",
                table: "Tags",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Appointments_AppointmentId",
                table: "Tags",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Appointments_AppointmentId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Tags",
                newName: "AppointmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_AppointmentId",
                table: "Tags",
                newName: "IX_Tags_AppointmentID");

            migrationBuilder.AlterColumn<long>(
                name: "AppointmentID",
                table: "Tags",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isChoosen",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Appointments_AppointmentID",
                table: "Tags",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

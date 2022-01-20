using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class ConcurenccyRowVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AppointmentId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Appointments",
                type: "rowversion",
                rowVersion: true,
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Appointments");
        }
    }
}

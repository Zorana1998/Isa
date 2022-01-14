using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class deleteProfileChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileDelete_AspNetUsers_UserId",
                table: "ProfileDelete");

            migrationBuilder.DropIndex(
                name: "IX_ProfileDelete_UserId",
                table: "ProfileDelete");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProfileDelete",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProfileDelete",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileDelete_UserId",
                table: "ProfileDelete",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileDelete_AspNetUsers_UserId",
                table: "ProfileDelete",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace IsaProject.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EnginePower",
                table: "Entities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstructorDescription",
                table: "Entities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxSpeed",
                table: "Entities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ship_FishingEquipment",
                table: "Entities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnginePower",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "InstructorDescription",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "MaxSpeed",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "Ship_FishingEquipment",
                table: "Entities");
        }
    }
}

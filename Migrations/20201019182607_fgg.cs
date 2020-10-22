using Microsoft.EntityFrameworkCore.Migrations;

namespace Task6.Migrations
{
    public partial class fgg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosX",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosY",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Width",
                table: "Notes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "PosX",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "PosY",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Notes");
        }
    }
}

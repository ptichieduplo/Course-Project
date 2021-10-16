using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class c1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CorrectAnswer",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedAnswer1",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedAnswer2",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedAnswer3",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "EstimatedAnswer1",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "EstimatedAnswer2",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "EstimatedAnswer3",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "tasks");
        }
    }
}

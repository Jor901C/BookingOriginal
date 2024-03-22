using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingOriginal.WEB.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "_Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "_Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "_Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "_Surname",
                table: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Tasks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                table: "Sites",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ShiftId",
                table: "Shifts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "Materials",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CrewId",
                table: "Crews",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tasks",
                newName: "TaskId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sites",
                newName: "SiteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Shifts",
                newName: "ShiftId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Materials",
                newName: "MaterialId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Crews",
                newName: "CrewId");
        }
    }
}

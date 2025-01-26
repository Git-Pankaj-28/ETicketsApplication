using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicketsApplication.Migrations
{
    /// <inheritdoc />
    public partial class updateDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "Cinemas",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Decription");
        }
    }
}

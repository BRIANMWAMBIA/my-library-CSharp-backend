using Microsoft.EntityFrameworkCore.Migrations;

namespace moviesData.Migrations
{
    public partial class updatedbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Books",
                newName: "Pages");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Books",
                newName: "About");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pages",
                table: "Books",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "Books",
                newName: "Description");
        }
    }
}

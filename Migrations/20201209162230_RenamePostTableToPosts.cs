using Microsoft.EntityFrameworkCore.Migrations;

namespace WikinimousMVC.Migrations
{
    public partial class RenamePostTableToPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Post", newName: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(name: "Posts", newName: "Post");
        }
    }
}

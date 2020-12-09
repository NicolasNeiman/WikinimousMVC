using Microsoft.EntityFrameworkCore.Migrations;

namespace WikinimousMVC.Migrations
{
    public partial class RenamePostTableToPostsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                    ALTER TABLE Post
                    RENAME TO Posts;
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                            ALTER TABLE Posts
                            RENAME TO Post;
                        ");
        }
    }
}

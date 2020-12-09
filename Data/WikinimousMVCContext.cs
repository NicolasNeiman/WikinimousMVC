using Microsoft.EntityFrameworkCore;
using WikinimousMVC.Models;

namespace WikinimousMVC.Data
{
    public class WikinimousMVCContext : DbContext
    {
        public WikinimousMVCContext (DbContextOptions<WikinimousMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
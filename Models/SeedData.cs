using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WikinimousMVC.Data;
using System;
using System.Linq;

namespace WikinimousMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WikinimousMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WikinimousMVCContext>>()))
            {
                // Look for any Posts.
                if (context.Posts.Any())
                {
                    return;   // DB has been seeded
                }

                context.Posts.AddRange(
                    new Post
                    {
                        Title = "Apple goes bankrupt",
                        PostDate = DateTime.Parse("2020-12-07"),
                        Content = "This is the most surprising news of this very strange year ..."
                    },

                    new Post
                    {
                        Title = "Criteo takes over Amazon",
                        PostDate = DateTime.Parse("2020-12-07"),
                        Content = "Not a surprise given the talents at Criteo ..."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
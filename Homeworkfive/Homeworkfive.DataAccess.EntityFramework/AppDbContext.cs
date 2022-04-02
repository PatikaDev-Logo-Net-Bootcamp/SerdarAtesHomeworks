using Homeworkfive.DataAccess.EntityFramework.Configurations;
using Homeworkfive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Homeworkfive.DataAccess.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PostConfigurations());
        }
    }
}

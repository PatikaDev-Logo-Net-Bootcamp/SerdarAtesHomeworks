
using Microsoft.EntityFrameworkCore;
using Homeworkfour.DataAcces.EntityFramework.Configurations;
using Homeworkfour.Domain.Entities;

namespace Homeworkfour.DataAcces.EntityFramework
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
   
}

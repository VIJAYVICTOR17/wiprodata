using CmsCore.Models;
using Microsoft.EntityFrameworkCore;


namespace CmsCore.Models
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext() { }

        public CmsDbContext(DbContextOptions<CmsDbContext> options) : base(options)
        {
        }

        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
        public DbSet<Customer> Customer { get; set; }
    }
}

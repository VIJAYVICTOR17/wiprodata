using Microsoft.EntityFrameworkCore;

namespace RajorExamples.Models
{
    public class EFcoreDbContext : DbContext
    {
        public EFcoreDbContext(DbContextOptions<EFcoreDbContext> options) : base(options)
        {

        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MSI;Database=wiprojuly;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employ>().ToTable("Employ");
        }

        public DbSet<Employ> Employees { get; set; }
    }
}

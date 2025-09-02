using Microsoft.EntityFrameworkCore;

namespace SmartHomeDbProject.Models
{
    public class SmartHomeDbContext : DbContext
    {
        //Constructor calling the Base DbContext Class Constructor
        public SmartHomeDbContext(DbContextOptions<SmartHomeDbContext> options) : base(options)
        {
        }
        //OnConfiguring() method is used to select and configure the data source
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Devices>().ToTable("Devices");
            modelBuilder.Entity<SensorsData>().ToTable("SensorsData");
            modelBuilder.Entity<ControlLog>().ToTable("ControlLog");
            modelBuilder.Entity<Notifications>().ToTable("Notifications");

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Devices> Devices { get; set; }

        public DbSet<SensorsData> SensorsData { get; set; }
        public DbSet<ControlLog> ControlLog { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
    }
}

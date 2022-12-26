using Microsoft.EntityFrameworkCore;
using turkey_address.model;

namespace turkey_address.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }    
        public DbSet<SemtMahalle> SemtMah { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sehir>().HasNoKey();
            modelBuilder.Entity<SemtMahalle>().HasNoKey();
            modelBuilder.Entity<Ilce>().HasNoKey();
        }
    }
}

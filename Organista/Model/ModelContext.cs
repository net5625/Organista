using Microsoft.EntityFrameworkCore;

namespace Organista.Model
{
    internal class ModelContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Canto> Cantos { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<SetName> SetNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rejestr.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().ToTable("Activities");
            modelBuilder.Entity<Canto>().ToTable("Cantos");
            modelBuilder.Entity<Set>().ToTable("Sets");
            modelBuilder.Entity<SetName>().ToTable("SetNames");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MobileStore.Domain.EntityConfigurations;
using MobileStore.Domain.Models;

namespace MobileStore.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<MyOperatingSystem> OperatingSystems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new MobilePhoneConfiguration());
            modelBuilder.ApplyConfiguration(new CPUConfiguration());
            modelBuilder.ApplyConfiguration(new MyOperatingSystemConfiguration());
        }
    }
}

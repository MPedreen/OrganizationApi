using Microsoft.EntityFrameworkCore;
using Organization.Domain.Entities;

namespace Organization.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<OrganizationItem> Organizations { get; set; }

        //mapeamento do banco
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationItem>().ToTable("Organization");
            modelBuilder.Entity<OrganizationItem>().Property(x => x.Id);
            modelBuilder.Entity<OrganizationItem>().Property(x => x.User).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<OrganizationItem>().Property(x => x.Title).HasMaxLength(160).HasColumnType("varchar(160)");
            modelBuilder.Entity<OrganizationItem>().Property(x => x.Done).HasColumnType("bit");
            modelBuilder.Entity<OrganizationItem>().Property(x => x.Date);
            modelBuilder.Entity<OrganizationItem>().HasIndex(b => b.User);
        }
    }
}
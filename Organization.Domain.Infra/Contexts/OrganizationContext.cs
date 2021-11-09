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
    }
}
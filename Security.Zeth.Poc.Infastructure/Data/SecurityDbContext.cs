using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Security.Zeth.Poc.Shared.Entities;

namespace Security.Zeth.Poc.Infastructure.Data
{
    public class SecurityDbContext : DbContext
    {
        public SecurityDbContext(DbContextOptions<SecurityDbContext> options): base(options)
        {

        }

        public DbSet<SecurityOnboarding> Onboardings => Set<SecurityOnboarding>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}

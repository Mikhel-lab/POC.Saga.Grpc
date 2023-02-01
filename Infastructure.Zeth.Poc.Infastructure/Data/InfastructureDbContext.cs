using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Security.Zeth.Poc.Shared.Entities;

namespace Infastructure.Zeth.Poc.Infastructure.Data
{
    public class InfastructureDbContext : DbContext
    {
        public InfastructureDbContext(DbContextOptions<InfastructureDbContext> options) : base(options)
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

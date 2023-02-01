using Hr.Zeth.Poc.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hr.Zeth.Poc.Infastructure.Data
{
    public class HrDbContext : DbContext
    {
        public HrDbContext(DbContextOptions<HrDbContext> options): base(options)
        {

        }

        public DbSet<HrOnboarding> Onboardings => Set<HrOnboarding>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}

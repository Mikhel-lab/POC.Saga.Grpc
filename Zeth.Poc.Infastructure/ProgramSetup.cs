using Hr.Zeth.Poc.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hr.Zeth.Poc.Infastructure
{
    public static class ProgramSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
     services.AddDbContext<HrDbContext>(options =>
         options.UseSqlServer(connectionString));
    }
}

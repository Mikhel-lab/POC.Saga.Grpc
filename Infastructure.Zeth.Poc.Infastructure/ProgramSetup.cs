using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Infastructure.Zeth.Poc.Infastructure.Data;

namespace Infastructure.Zeth.Poc.Infastructure
{
    public static class ProgramSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
     services.AddDbContext<InfastructureDbContext>(options =>
         options.UseSqlServer(connectionString));
    }
}

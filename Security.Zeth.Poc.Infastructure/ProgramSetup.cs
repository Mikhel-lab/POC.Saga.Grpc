using Security.Zeth.Poc.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Security.Zeth.Poc.Infastructure
{
    public static class ProgramSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
     services.AddDbContext<SecurityDbContext>(options =>
         options.UseSqlServer(connectionString));
    }
}

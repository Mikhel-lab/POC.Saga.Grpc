using Infastructure.Zeth.Poc.Core.Interfaces;
using Infastructure.Zeth.Poc.Infastructure.Data;
using Infastructure.Zeth.Poc.Infastructure.Service.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infastructure.Zeth.Poc.Infastructure
{
    public static class InfastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InfastructureDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("HRConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IInfastructure, InfrastructureService>();


            return services;
        }
    }
}

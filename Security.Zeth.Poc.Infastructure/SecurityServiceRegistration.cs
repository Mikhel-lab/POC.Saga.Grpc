using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Security.Zeth.Poc.Core.Interfaces;
using Security.Zeth.Poc.Infastructure.Data;
using Security.Zeth.Poc.Infastructure.Service.Implementation;

namespace Security.Zeth.Poc.Infastructure
{
    public static class SecurityServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SecurityDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("HRConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IValidateCredentials, ValidateCredentials>();


            return services;
        }
    }
}

using Hr.Zeth.Poc.Core.Interfaces;
using Hr.Zeth.Poc.Infastructure.Data;
using Hr.Zeth.Poc.Infastructure.Service.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.Zeth.Poc.Infastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HrDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CustomerConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IHrRepository, HrRepository>();


            return services;
        }
    }
}

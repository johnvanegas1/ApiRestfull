using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoriesEFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<BancoDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BancoTest")));
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICuentaRepository, CuentaRepository>();
            services.AddScoped<IMovimientoRepository, MovimientoRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presenters;
using RepositoriesEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases;

namespace ApiRest.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddRepositories(configuration);
            services.AddPresenters();
            services.AddUseCases();

            return services;
        }
    }
}

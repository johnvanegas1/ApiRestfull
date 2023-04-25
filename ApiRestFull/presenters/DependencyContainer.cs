using Entities.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoriesEFCore.Repositories;
using RepositoriesEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.CreaciónUsuario;
using UsesCases.CreaciónCuenta;
using UsesCases.AgregarMovimientos;
using UsesCases.ObtenerClientes;
using UsesCases.ActualizarClientes;

namespace Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateClientOutputPort, CrearCliente>();
            services.AddScoped<ICreateAccountOutputPort, CrearCuenta>();
            services.AddScoped<IAddMovementsOutputPort, AgregarMovimiento>();
            services.AddScoped<IGetClientsOutputPort, ObtenerClientes>();
            services.AddScoped<IUpdateClientOutputPort, ActualizarCliente>();
            

            return services;
        }
    }
}

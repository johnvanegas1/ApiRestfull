using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.ActualizarClientes;
using UsesCases.AgregarMovimientos;
using UsesCases.CreaciónCuenta;
using UsesCases.CreaciónUsuario;
using UsesCases.ObtenerClientes;
using UsesCases.Reportes;

namespace UsesCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCases(this IServiceCollection service)
        {
            service.AddScoped<IAddMovementsInputPort, AddMovements>();
            service.AddScoped<ICreateAccountIntputPort, CreateAccount>();
            service.AddScoped<ICreateClientInputPort, CreateClient>();
            service.AddScoped<IListMovementsByDateInputPort, ListMovementsByDate>();
            service.AddScoped<IGetClientsInputPort, GetClients>();
            service.AddScoped<IUpdateClientInputPort, UpdateClient>();
            return service;
        }
    }
}

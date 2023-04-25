using DTO_s;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.ActualizarClientes
{
    public class UpdateClient : IUpdateClientInputPort
    {
        readonly IUpdateClientOutputPort outputPort;
        readonly IClienteRepository clienteRepository;
        readonly IUnitOfWork unitOfWork;

        public UpdateClient(IUpdateClientOutputPort outputPort, IClienteRepository clienteRepository, IUnitOfWork unitOfWork)
        {
            this.outputPort = outputPort;
            this.clienteRepository = clienteRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Handler(int id, ClienteDTO cliente)
        {

            var client = clienteRepository.GetById(id).Single();

            client.Identificacion = cliente.Identificacion == 0 || cliente.Identificacion == client.Identificacion ? client.Identificacion : cliente.Identificacion;
            client.Estado = cliente.Estado == client.Estado ? client.Estado : cliente.Estado;
            client.Contraseña = string.IsNullOrEmpty(cliente.Contraseña) || cliente.Contraseña == client.Contraseña ? client.Contraseña : cliente.Contraseña;
            client.Direccion = cliente.Direccion;
            client.Edad = cliente.Edad;
            client.Genero = cliente.Genero;
            client.Nombre = cliente.Nombre;
            client.Telefono = cliente.Telefono;

            clienteRepository.Update(client);
            await unitOfWork.SaveChange();
            await outputPort.Handler(new ClienteOutDTO()
            {
                Direccion = client.Direccion,
                Estado = client.Estado,
                Nombre = client.Nombre,
                Telefono = client.Telefono
            });
        }
    }
}

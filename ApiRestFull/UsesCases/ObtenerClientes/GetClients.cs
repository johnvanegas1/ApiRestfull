using DTO_s;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.ObtenerClientes
{
    public class GetClients : IGetClientsInputPort
    {
        readonly IGetClientsOutputPort _getClientsOutputPort;
        readonly IClienteRepository _clienteRepository;

        public GetClients(IGetClientsOutputPort getClientsOutputPort, IClienteRepository clienteRepository)
        {
            _getClientsOutputPort = getClientsOutputPort;
            _clienteRepository = clienteRepository;
        }

        public async Task Handler()
        {
            try
            {
                var clientOutDTO = _clienteRepository.GetAll().Select(c =>
                {
                    return new ClienteOutDTO
                    {
                        Estado = c.Estado,
                        Direccion = c.Direccion,
                        Nombre = c.Nombre,
                        Telefono = c.Telefono,
                    };
                });

                await _getClientsOutputPort.Handler(clientOutDTO);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task Handler(int Id)
        {
            try
            {
                var clientOutDTO = _clienteRepository.GetById(Id).Select(c =>
                {
                    return new ClienteOutDTO
                    {
                        Estado = c.Estado,
                        Direccion = c.Direccion,
                        Nombre = c.Nombre,
                        Telefono = c.Telefono,
                    };
                });
                await _getClientsOutputPort.Handler(clientOutDTO);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

using DTO_s;
using Entities;
using Entities.Interfaces;

namespace UsesCases.CreaciónUsuario
{
    public class CreateClient : ICreateClientInputPort
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IClienteRepository _clienteRepository;
        readonly ICreateClientOutputPort _outputPort;

        public CreateClient(IUnitOfWork unitOfWork, IClienteRepository clienteRepository, ICreateClientOutputPort outputPort)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _outputPort = outputPort;
        }

        public async Task Handler(ClienteDTO cliente)
        {
            try
            {
                var newClient = new Cliente
                {
                    Contraseña = cliente.Contraseña,
                    Direccion = cliente.Direccion,
                    Edad = cliente.Edad,
                    Estado = cliente.Estado,
                    Genero = cliente.Genero,
                    Identificacion = cliente.Identificacion,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono
                };
                _clienteRepository.Add(newClient);
                await _unitOfWork.SaveChange();
                await _outputPort.Handler(new ClienteOutDTO
                {
                    Estado = newClient.Estado,
                    Direccion = newClient.Direccion,
                    Nombre = newClient.Nombre,
                    Telefono = newClient.Telefono
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

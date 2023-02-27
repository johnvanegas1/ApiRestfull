using DTOs;
using Entities;
using Entities.Interfaces;

namespace UsesCases
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

        public async Task Handler(CreateClientDTO cliente)
        {
            try
            {
                var newClient = new Cliente
                {

                    Contraseña = cliente.Contraseña
                };
                _clienteRepository.Add(newClient);
                await _unitOfWork.SaveChange();
                await _outputPort.Handler(new GetClientDTO()
                {
                    Contraseña = cliente.Contraseña,
                    Estado = cliente.Estado,
                    persona = cliente.persona
                });

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

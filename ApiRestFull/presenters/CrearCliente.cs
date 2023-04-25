using DTO_s;
using Entities;
using Entities.Interfaces;
using Presenters;
using UsesCases.CreaciónUsuario;

namespace Presenters
{
    public class CrearCliente : ICreateClientOutputPort, IPresenters<ClienteOutDTO>
    {
        public ClienteOutDTO Content { get; private set; }

        

        public Task Handler(ClienteOutDTO cliente)
        {
            Content = cliente;
            return Task.CompletedTask;
        }
    }
}
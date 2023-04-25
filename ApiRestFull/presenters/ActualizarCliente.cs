using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.ActualizarClientes;

namespace Presenters
{
    public class ActualizarCliente : IUpdateClientOutputPort, IPresenters<ClienteOutDTO>
    {
        public ClienteOutDTO Content { get; private set; }

        public Task Handler(ClienteOutDTO cliente)
        {
            Content = cliente;
            return Task.CompletedTask;
        }
    }
}

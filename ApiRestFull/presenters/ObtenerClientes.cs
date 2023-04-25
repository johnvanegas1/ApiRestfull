using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.ObtenerClientes;

namespace Presenters
{
    public class ObtenerClientes : IGetClientsOutputPort, IPresenters<IEnumerable<ClienteOutDTO>>
    {
        public IEnumerable<ClienteOutDTO> Content { get; private set; }

        public Task Handler(IEnumerable<ClienteOutDTO> cliente)
        {
            Content = cliente;
            return Task.CompletedTask;
        }
    }
}

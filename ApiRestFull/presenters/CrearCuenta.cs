using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.CreaciónCuenta;

namespace Presenters
{
    public class CrearCuenta : ICreateAccountOutputPort, IPresenters<CuentaOutDTO>
    {
        public CuentaOutDTO Content { get; private set; }

        public Task Handler(CuentaOutDTO cuenta)
        {
            Content = cuenta;
            return Task.CompletedTask;
        }
    }
}

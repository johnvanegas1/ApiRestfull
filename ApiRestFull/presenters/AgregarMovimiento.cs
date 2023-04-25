using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.AgregarMovimientos;

namespace Presenters
{
    public class AgregarMovimiento : IAddMovementsOutputPort, IPresenters<MovimientoOutDTO>

    {
        public MovimientoOutDTO Content { get; private set; }

        public Task Handler(MovimientoOutDTO movimiento)
        {
            Content = movimiento;
            return Task.CompletedTask;
        }
    }
}

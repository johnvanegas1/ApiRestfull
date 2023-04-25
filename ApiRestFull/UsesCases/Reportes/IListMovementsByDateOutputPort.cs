using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Reportes
{
    public interface IListMovementsByDateOutputPort
    {
        Task Handler(IEnumerable<MovimientosOutDTO> movimientos);
    }
}

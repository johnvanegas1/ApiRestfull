using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IMovimientoRepository
    {
        void Add(Movimiento cliente);
        IEnumerable<Movimiento> GetAll();
        IEnumerable<Movimiento> GetByDate(DateTime date, int ClientId);
    }
}

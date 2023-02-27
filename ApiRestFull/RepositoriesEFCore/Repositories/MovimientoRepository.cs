using Entities;
using Entities.Interfaces;

namespace RepositoriesEFCore.Repositories
{
    public class MovimientoRepository : IMovimientoRepository
    {
        readonly Context _context;

        public MovimientoRepository(Context context)
        {
            _context = context;
        }

        public void Add(Movimiento movimiento)
        {
            _context.Add(movimiento);
        }

        public IEnumerable<Movimiento> GetAll()
        {
            return _context.Movimiento;
        }
    }
}
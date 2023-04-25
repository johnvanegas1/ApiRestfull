using DTO_s;
using Entities;
using Entities.Interfaces;

namespace RepositoriesEFCore.Repositories
{
    public class MovimientoRepository : IMovimientoRepository
    {
        readonly BancoDbContext _context;

        public MovimientoRepository(BancoDbContext context)
        {
            _context = context;
        }

        public void Add(Movimiento movimiento)
        {
            _context.Add(movimiento);
        }

        public IEnumerable<Movimiento> GetAll()
        {
            return _context.Movimientos;
        }

        public IEnumerable<Movimiento> GetByDate(DateTime date, int ClientId)
        {
            return _context.Movimientos.Where(m => m.Fecha >= date)
                                       .Where(m => m.Cuenta.Cliente.Id == ClientId);
        }
    }
}
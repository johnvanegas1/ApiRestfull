using Entities;
using Entities.Interfaces;

namespace RepositoriesEFCore.Repositories
{
    public class CuentaRepository : ICuentaRepository
    {
        readonly Context _context;

        public CuentaRepository(Context context)
        {
            _context = context;
        }

        public void Add(Cuenta cliente)
        {
            _context.Add(cliente);
        }

        public IEnumerable<Cuenta> GetAll()
        {
            return _context.Cuenta;
        }
    }
}
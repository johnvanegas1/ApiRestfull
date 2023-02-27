using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesEFCore.Repositories
{
    public class ClientetRepository : IClienteRepository
    {
        readonly Context _context;

        public ClientetRepository(Context context)
        {
            _context = context;
        }

        public void Add(Persona cliente)
        {
            _context.Add(cliente);
        }

        public IEnumerable<Persona> GetAll()
        {
            return _context.Cliente;
        }
    }
}

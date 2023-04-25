using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriesEFCore.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        readonly BancoDbContext _context;

        public ClienteRepository(BancoDbContext context)
        {
            _context = context;
        }

        public void Add(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            _context.Update(cliente);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes;
        }
        public IEnumerable<Cliente> GetById(int Id)
        {
            return _context.Clientes.Where(c => c.Id == Id);
                                    
        }
    }
}

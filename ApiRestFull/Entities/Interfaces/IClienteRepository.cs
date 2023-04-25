using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        IEnumerable<Cliente> GetAll();
        IEnumerable<Cliente> GetById(int Id);
    }
}

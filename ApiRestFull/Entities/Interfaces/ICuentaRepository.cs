using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface ICuentaRepository
    {
        void Add(Cuenta cliente);
        IEnumerable<Cuenta> GetAll();
    }
}

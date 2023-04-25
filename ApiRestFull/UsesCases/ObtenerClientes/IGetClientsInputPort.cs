using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.ObtenerClientes
{
    public interface IGetClientsInputPort
    {
        Task Handler();
        Task Handler(int Id);
    }
}

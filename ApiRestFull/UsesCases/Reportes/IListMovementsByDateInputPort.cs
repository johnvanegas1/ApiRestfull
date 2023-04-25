using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Reportes
{
    interface IListMovementsByDateInputPort
    {
        Task Handler(DateTime date, int clientId);
    }
}

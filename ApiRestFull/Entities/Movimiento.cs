using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movimiento
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
    }
}

using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }
        public int NumeroCuenta { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public int SaldoInicial { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set;}
        public ICollection<Movimiento> Movimientos { get; set;}
    }
}

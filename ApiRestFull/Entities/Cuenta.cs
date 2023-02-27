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
        public int CuentaId { get; set; }
        public int NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public int SaldoInicial { get; set; }
        public bool Estado { get; set; }
    }
}

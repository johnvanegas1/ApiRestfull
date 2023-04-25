using Entities;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_s
{
    public class CuentaDTO
    {
        public int NumeroCuenta { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public int SaldoInicial { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }
    }

    public class CuentaOutDTO
    {
        public int NumeroCuenta { get; set; }
        public string Tipo { get; set; }
        public int SaldoInicial { get; set; }
        public bool Estado { get; set; }
        //public ClienteOutDTO Cliente { get; set; } 
    }
}

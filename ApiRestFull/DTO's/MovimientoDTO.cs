using Entities;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_s
{
    public class MovimientoDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TipoMovimiento TipoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
        public int CuentaId { get; set; }
    }

    public class MovimientoOutDTO
    {
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
        public int CuentaId { get; set; }
    }

    public class MovimientosOutDTO
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public CuentaOutDTO Cuenta { get; set; }
        public int SaldoDisponible { get; set; }

    }
}
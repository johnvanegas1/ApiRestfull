using DTO_s;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.Reportes
{
    public class ListMovementsByDate : IListMovementsByDateInputPort
    {
        readonly IMovimientoRepository movimientoRepository;
        readonly IListMovementsByDateOutputPort movimientoOutputPort;

        public ListMovementsByDate(IMovimientoRepository movimientoRepository)
        {
            this.movimientoRepository = movimientoRepository;
            this.movimientoOutputPort = movimientoOutputPort;
        }

        public Task Handler(DateTime date, int clientId)
        {
            var movements = movimientoRepository.GetByDate(date, clientId).Select(m =>
            new MovimientosOutDTO()
            {
                Fecha = m.Fecha,
                Cliente = m.Cuenta.Cliente.Nombre,
                Cuenta = new CuentaOutDTO()
                {
                    NumeroCuenta = m.Cuenta.NumeroCuenta,
                    Tipo = m.Cuenta.TipoCuenta.ToString(),
                    SaldoInicial = m.Cuenta.SaldoInicial,
                    Estado = m.Cuenta.Estado
                },
                SaldoDisponible = m.Cuenta.SaldoInicial+m.Valor

            }
            );

            movimientoOutputPort.Handler(movements);
            return Task.CompletedTask;
        }
    }
}

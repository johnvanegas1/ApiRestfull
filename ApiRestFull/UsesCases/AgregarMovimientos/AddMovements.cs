using DTO_s;
using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.AgregarMovimientos
{
    public class AddMovements : IAddMovementsInputPort
    {
        IMovimientoRepository movimientoRepository;
        IUnitOfWork unitOfWork;

        public async Task Handler(MovimientoDTO movimiento)
        {
            var newMovimiento = new Movimiento()
            {
                Fecha = DateTime.UtcNow.Date,
                Saldo = movimiento.Saldo,
                TipoMovimiento = movimiento.TipoMovimiento,
                Valor = movimiento.TipoMovimiento == Enums.TipoMovimiento.Deposito ? movimiento.Valor : movimiento.Valor * (-1)
            };
            movimientoRepository.Add(newMovimiento);
            await unitOfWork.SaveChange();   
        }
    }
}

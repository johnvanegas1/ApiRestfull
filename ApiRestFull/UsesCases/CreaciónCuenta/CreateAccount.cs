using DTO_s;
using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.CreaciónCuenta
{
    public class CreateAccount : ICreateAccountIntputPort
    {
        readonly ICuentaRepository cuentaRepository;
        readonly IUnitOfWork unitOfWork;

        public CreateAccount(ICuentaRepository cuentaRepository, IUnitOfWork unitOfWork)
        {
            this.cuentaRepository = cuentaRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task Handler(CuentaDTO cuenta)
        {
            var newAccount = new Cuenta()
            {
                Estado = cuenta.Estado,
                NumeroCuenta = cuenta.NumeroCuenta,
                SaldoInicial = cuenta.SaldoInicial,
                TipoCuenta = cuenta.TipoCuenta
            };
            cuentaRepository.Add(newAccount);
            await unitOfWork.SaveChange();
        }
    }
}

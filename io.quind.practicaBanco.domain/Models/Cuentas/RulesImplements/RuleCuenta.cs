using io.quind.practicaBanco.domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io.quind.practicaBanco.domain.Models.Cuentas.Repositories;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;

namespace io.quind.practicaBanco.domain.Models.Cuentas.RulesImplements
{
    public class RuleCuenta : IRuleCuenta<Cuenta>

    {
        public readonly ICuentaRepository cuentaRepository;
        public RuleCuenta(ICuentaRepository cuentaRepository)
        {
            this.cuentaRepository = cuentaRepository;
        }

        Cuenta cuenta = new Cuenta();

        public void Validar(Cuenta model)
        {
            
        }
        public void ValidarEli(int id)
        {
            ValidarSaldoEliminar(id);
        }
        private void ValidarSaldoEliminar(int id) 
        {
           
            if (cuenta.Saldo == 0) 
            {
                cuentaRepository.Eliminar(id);
            } 
            else 
            { throw new ArgumentNullException("Tiene saldos pendientes"); }
        }
    }
}
       
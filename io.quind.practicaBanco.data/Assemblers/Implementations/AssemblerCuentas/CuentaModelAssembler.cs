using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.entity.CuentasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersCuentas
{
    public class CuentaModelAssembler : IAssembler<CuentaEntidad, Cuenta>
    {
        public Cuenta AssemblerObject(CuentaEntidad Tin)
        {
            return new Cuenta
            {
                TipoCuenta = (TipoCuentaBancaria)Tin.TipoCuenta,
                NumeroCuenta = Tin.NumeroCuenta,
                EstadoCuenta = (EstadoCuentaCliente)Tin.EstadoCuenta,
                Saldo = Tin.Saldo,
                ExentoGmf = Tin.ExentoGmf,
                FechaActualizacionCuenta = Tin.FechaActualizacionCuenta,
                FechaCreacionCuenta = Tin.FechaCreacionCuenta,
                ClienteId = Tin.ClienteId
            };
        }
    }
}

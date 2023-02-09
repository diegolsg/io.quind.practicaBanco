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
    public class CuentaEntityAssembler : IAssembler<Cuenta, CuentaEntidad>
    {
        public CuentaEntidad AssemblerObject(Cuenta Tin)
        {
            return new CuentaEntidad
            {
                TipoCuenta = (int)Tin.TipoCuenta,
                NumeroCuenta = Tin.NumeroCuenta,
                EstadoCuenta = (int)Tin.EstadoCuenta,
                Saldo = Tin.Saldo,
                ExentoGmf = Tin.ExentoGmf,
                FechaActualizacionCuenta = Tin.FechaActualizacionCuenta,
                FechaCreacionCuenta = Tin.FechaCreacionCuenta,
                ClienteId = Tin.ClienteId
            };
        }
    }
}

using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;
using io.quind.practicaBanco.DTO.CuentaDTOS;

namespace io.quind.practicaBanco.ap.Assemblers.Implementations
{
    public class CuentaImpDto : IAssembler<CuentaRequest, Cuenta>
    {
        public Cuenta AssemblerObject(CuentaRequest Tin)
        {
            return new Cuenta 
            {
                TipoCuenta = (TipoCuentaBancaria)Tin.TipoCuenta,
                NumeroCuenta = Tin.NumeroCuenta,
                EstadoCuenta=(EstadoCuentaCliente)Tin.EstadoCuenta, 
                Saldo=Tin.Saldo,   
                ExentoGmf=Tin.ExentoGmf,
                ClienteId = Tin.ClienteID,

            };

        }
    }
}

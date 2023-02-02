

using io.quind.banco.dominio.Models;
using io.quind.practicaBanco.domain.Models;
using io.quind.practicaBanco.entity.CuentasEntities;

namespace io.quind.practicaBanco.data.CuentaFactories
{
    public class CuentaFactory
    {
        public static CuentaEntidad DominioAEntidad(Cuenta cuenta)
        {
            return new CuentaEntidad
            {
               
                TipoCuenta = (int)cuenta.TipoCuenta,
                NumeroCuenta = cuenta.NumeroCuenta,
                EstadoCuenta = (int)cuenta.EstadoCuenta,
                Saldo = cuenta.Saldo,
                ExentoGmf = cuenta.ExentoGmf,
                FechaActualizacionCuenta = cuenta.FechaActualizacionCuenta,
                FechaCreacionCuenta = cuenta.FechaCreacionCuenta,
                ClienteId = cuenta.ClienteId
            };
        }

        public static Cuenta EntidadAdominio(CuentaEntidad cuenta)
        {
            return new Cuenta
            {

                TipoCuenta = (TipoCuentaBancaria)cuenta.TipoCuenta,
                NumeroCuenta = cuenta.NumeroCuenta,
                EstadoCuenta = (EstadoCuentaCliente)cuenta.EstadoCuenta,
                Saldo = cuenta.Saldo,
                ExentoGmf = cuenta.ExentoGmf,
                FechaActualizacionCuenta = cuenta.FechaActualizacionCuenta,
                FechaCreacionCuenta = cuenta.FechaCreacionCuenta,
                ClienteId = cuenta.ClienteId
            };
        }
    }
}

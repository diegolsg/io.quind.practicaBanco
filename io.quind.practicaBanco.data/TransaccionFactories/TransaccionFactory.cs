using io.quind.practicaBanco.entity.TransaccionesEntities;
using io.quind.practicaBanco.Models.Transacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.data.TransaccionFactories
{
    public class TransaccionFactory
    {
        public static TransaccionEntidad DominioEntidad(Transaccion transaccion)
        {
            return new TransaccionEntidad()
            {

                Monto = transaccion.Monto,
                CuentaDestino = transaccion.CuentaDestino,
                FechaTransaccion = transaccion.FechaTransaccion,
                CuentaId = transaccion.CuentaId
            };
        }
        public static Transaccion EntidadDominio(TransaccionEntidad transaccion)
        {
            return new Transaccion()
            {

                Monto = transaccion.Monto,
                CuentaDestino = transaccion.CuentaDestino,
                FechaTransaccion = transaccion.FechaTransaccion,
                CuentaId = transaccion.CuentaId
            };
        }
            
    }
}

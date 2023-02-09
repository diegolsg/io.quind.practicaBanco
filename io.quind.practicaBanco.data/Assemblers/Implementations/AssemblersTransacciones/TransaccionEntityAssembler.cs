using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.entity.TransaccionesEntities;

namespace io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersTransacciones
{
    public class TransaccionEntityAssembler : IAssembler<Transaccion, TransaccionEntidad>
    {
        public TransaccionEntidad AssemblerObject(Transaccion Tin)
        {
            return new TransaccionEntidad
            {
                Monto = Tin.Monto,
                CuentaDestino = Tin.CuentaDestino,
                FechaTransaccion = Tin.FechaTransaccion,
                TipoTransaccion = (int)Tin.TipoTransaccion,
                CuentaId = Tin.CuentaId,
            };
        }
    }
}

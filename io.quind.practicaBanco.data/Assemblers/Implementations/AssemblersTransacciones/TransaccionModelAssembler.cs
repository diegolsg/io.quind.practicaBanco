
using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.entity.TransaccionesEntities;

namespace io.quind.practicaBanco.data.Assemblers.Implementations.AssemblersTransacciones
{
    public class TransaccionModelAssembler : IAssembler<TransaccionEntidad, Transaccion>
    {
        public Transaccion AssemblerObject(TransaccionEntidad Tin)
        {
            return new Transaccion
            {
                   Monto= Tin.Monto,
                   CuentaDestino = Tin.CuentaDestino,
                   FechaTransaccion = Tin.FechaTransaccion,
                   TipoTransaccion =(TipoTransaccionCliente) Tin.TipoTransaccion,
                   CuentaId = Tin.CuentaId,
            };
        }
    }
}

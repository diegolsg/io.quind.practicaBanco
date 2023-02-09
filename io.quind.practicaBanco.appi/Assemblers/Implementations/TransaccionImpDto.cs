using io.quind.practicaBanco.domain.Assemblers;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.DTO.TransaccionDTOS;

namespace io.quind.practicaBanco.ap.Assemblers.Implementations
{
    public class TransaccionImpDto : IAssembler<TransaccionRequestDto, Transaccion>
    {
        public Transaccion AssemblerObject(TransaccionRequestDto Tin)
        {
            return new Transaccion
            {
                Monto = Tin.Monto,
                CuentaDestino = Tin.CuentaDestino,
                FechaTransaccion = Tin.FechaTransaccion,
                TipoTransaccion = (TipoTransaccionCliente)Tin.TipoTransaccion,
                CuentaId = Tin.CuentaId,
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using io.quind.practicaBanco.domain.Models.Transacciones;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;

namespace io.quind.practicaBanco.DTO.TransaccionDTOS
{
    public class TransaccionResponseDto
    {
        

        public decimal Monto { get; set; }

        public string CuentaDestino { get; set; }

        public DateTime? FechaTransaccion { get; set; }

        public int CuentaId { get; set; }
        public string? TipoTransaccion { get; set; }
        public static TransaccionResponseDto Of(Transaccion transaccion) 
        {
            return new TransaccionResponseDto
            {
                
                Monto=transaccion.Monto,
                CuentaDestino=transaccion.CuentaDestino,
                FechaTransaccion=transaccion.FechaTransaccion,
                TipoTransaccion = transaccion.TipoTransaccion.ToString(),
                CuentaId = transaccion.CuentaId
                
            };
        }
    }
}

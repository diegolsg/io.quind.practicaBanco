using io.quind.practicaBanco.Models.Transacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace io.quind.practicaBanco.DTO.TransaccionDTOS
{
    public class TransaccionRequestDto
    {
        public int TipoTransaccion { get; set; }

        public decimal Monto { get; set; }

        public string CuentaDestino { get; set; }

        public DateTime? FechaTransaccion { get; set; }

        public int CuentaId { get; set; }
        public Transaccion obtenerTransaccion() 
        {
            return new Transaccion(TipoTransaccion,Monto,CuentaDestino,FechaTransaccion,CuentaId);
        }
    }
}

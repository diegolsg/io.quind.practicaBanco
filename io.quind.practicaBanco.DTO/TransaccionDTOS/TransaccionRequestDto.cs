

namespace io.quind.practicaBanco.DTO.TransaccionDTOS
{
    public class TransaccionRequestDto
    {
        public decimal Monto { get; set; }

        public string CuentaDestino { get; set; }

        public DateTime? FechaTransaccion { get; set; }

        public int CuentaId { get; set; }
        public int TipoTransaccion { get; set; }
       
    }
}

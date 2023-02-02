

using io.quind.practicaBanco.domain.Models;

namespace io.quind.practicaBanco.DTO.CuentaDTOS
{
    public class CuentaRequest
    {
       
        public int TipoCuenta { get; set; }

        public int NumeroCuenta { get; set; }

        public int EstadoCuenta { get; set; }

        public decimal Saldo { get; set; }

        public int ExentoGmf { get; set; }
        public DateTime? FechaCreacionCuenta { get; set; } = null;

        public DateTime? FechaActualizacionCuenta { get; set; }=null;
        public int ClienteID { get; set; }


        public Cuenta obtenerCuenta()
        {
            return new Cuenta(TipoCuenta, NumeroCuenta, EstadoCuenta, Saldo, ExentoGmf, ClienteID);
        }
    }
}

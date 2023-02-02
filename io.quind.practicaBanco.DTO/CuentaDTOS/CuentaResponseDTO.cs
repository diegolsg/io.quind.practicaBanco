

using io.quind.practicaBanco.domain.Models;

namespace io.quind.practicaBanco.DTO.CuentaDTOS
{
    public class CuentaResponseDTO
    {
        public int ClienteId { get; set; }

        public string TipoCuenta { get; set; }

        public int? NumeroCuenta { get; set; }

        public string EstadoCuenta { get; set; }

        public decimal Saldo { get; set; }

        public int ExentoGmf { get; set; }

        public DateTime? FechaCreacionCuanta { get; set; }

        public DateTime? FechaActualizacionCuanta { get; set; }
        public static CuentaResponseDTO of(Cuenta cuenta)
        {
            return new CuentaResponseDTO
            {
                
                TipoCuenta = cuenta.TipoCuenta.ToString(),
                NumeroCuenta = cuenta.NumeroCuenta,
                EstadoCuenta = cuenta.EstadoCuenta.ToString(),
                Saldo = cuenta.Saldo,
                ExentoGmf = cuenta.ExentoGmf,
                FechaCreacionCuanta = cuenta.FechaCreacionCuenta,
                FechaActualizacionCuanta = cuenta.FechaActualizacionCuenta,
                ClienteId = cuenta.ClienteId
            };
        }
    }
}

using io.quind.banco.dominio.Models;

namespace io.quind.banco.dto.CuentaDTOS
{
    public class CuentaResponseDTO
    {


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
                TipoCuenta = cuenta.TiposCuentas.ToString(),
                NumeroCuenta = cuenta.NumCuanta,
                EstadoCuenta = cuenta.EstadoCuenta.ToString(),
                Saldo = cuenta.Saldo,
                ExentoGmf = cuenta.ExentoGmf,
                FechaCreacionCuanta = cuenta.FechaCreacionCuanta,
                FechaActualizacionCuanta = cuenta.FechaActualizacionCuanta
            };
        }
    }
}

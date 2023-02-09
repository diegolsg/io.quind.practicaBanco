
namespace io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;

public class Transaccion
{
    public int Id { get; set; }
    public TipoTransaccionCliente TipoTransaccion { get; set; }

    public decimal Monto { get; set; }

    public string CuentaDestino { get; set; }

    public DateTime? FechaTransaccion { get; set; }

    public int CuentaId { get; set; }

    //private void RealizarMovimiento(int id)
    //{
    //    var cuenta = cuentaService.BuscarPorNumCuen(id);
    //    decimal saldo = cuenta.Saldo;

    //    switch (TipoTransaccion)
    //    {
    //        case (TipoTransaccionCliente)1:

    //            saldo = saldo + Monto;

    //            break;
    //        case (TipoTransaccionCliente)2:

    //            saldo = saldo - Monto;
    //            break;
    //        case (TipoTransaccionCliente)3:
    //            break;
    //    }
    //}


}

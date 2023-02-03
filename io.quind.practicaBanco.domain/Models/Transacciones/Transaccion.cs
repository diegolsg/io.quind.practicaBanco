using io.quind.practicaBanco.domain.Models.Transacciones;
using System;
using System.Collections.Generic;


namespace io.quind.practicaBanco.Models.Transacciones;

public  class Transaccion
{
    public Transaccion()
    {
    }

    public Transaccion(int tipoTransaccion, decimal monto,
        string cuentaDestino, DateTime? fechaTransaccion, int cuentaId)
    {
        TipoTransaccion =(TipoTransaccionCliente) tipoTransaccion;
        Monto = monto;
        CuentaDestino = cuentaDestino;
        FechaTransaccion = fechaTransaccion;
        CuentaId = cuentaId;
    }

    public int Id { get; set; }
    public TipoTransaccionCliente TipoTransaccion { get; set; }

    public decimal Monto { get; set; }

    public string CuentaDestino { get; set; } 

    public DateTime? FechaTransaccion { get; set; }

    public int CuentaId { get; set; }

   
}

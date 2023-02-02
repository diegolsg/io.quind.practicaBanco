using System;
using System.Collections.Generic;


namespace io.quind.practicaBanco.Models.Transacciones;

public  class Transaccion
{
    public int Id { get; set; }

    public decimal Monto { get; set; }

    public string CuentaDestino { get; set; } 

    public DateTime? FechaTransaccion { get; set; }

    public int CuentaId { get; set; }

   
}

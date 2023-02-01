using System;
using System.Collections.Generic;


namespace io.quind.practicaBanco.entity.CuentasEntiies;

public  class Cuenta
{
    public int Id { get; set; }

    public int TipoCuenta { get; set; }

    public int NumeroCuenta { get; set; }

    public int EstadoCuenta { get; set; }

    public decimal Saldo { get; set; }

    public int ExentoGmf { get; set; }

    public DateTime? FechaCreacionCuenta { get; set; }

    public DateTime? FechaActualizacionCuenta { get; set; }

    public int ClienteId { get; set; }

}
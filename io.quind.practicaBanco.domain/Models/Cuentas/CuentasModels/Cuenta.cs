﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;

public class Cuenta
{
   
    public int Id { get; set; }

    public TipoCuentaBancaria TipoCuenta { get; set; }

    public int NumeroCuenta { get; set; }

    public EstadoCuentaCliente EstadoCuenta { get; set; }

    public decimal Saldo { get; set; }

    public int ExentoGmf { get; set; }

    public DateTime? FechaCreacionCuenta { get; set; }

    public DateTime? FechaActualizacionCuenta { get; set; }

    public int ClienteId { get; set; }

    //private void CrearNumeroCuenta(int tCuenta)
    //{
    //    Random random = new Random();
    //    if (tCuenta == 1)
    //    {
    //        NumeroCuenta = random.Next(53000000, 53999999);
    //        EstadoCuenta = (EstadoCuentaCliente)1;
    //    }
    //    if (tCuenta == 2)
    //    {
    //        NumeroCuenta = random.Next(33000000, 33999999);
    //        EstadoCuenta = (EstadoCuentaCliente)1;
    //    }
    //}
    //private void validarSaldoCA()
    //{
    //    if (TipoCuenta == (TipoCuentaBancaria)1 && Saldo < 0)
    //    {
    //        throw new Exception("no tiene saldo suficiente");
    //    }
    //}

}



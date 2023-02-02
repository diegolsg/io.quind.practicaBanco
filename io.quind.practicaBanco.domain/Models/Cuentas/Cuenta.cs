using io.quind.banco.dominio.Models;
using System;
using System.Collections.Generic;


namespace io.quind.practicaBanco.domain.Models;

public  class Cuenta
{
    public Cuenta()
    {
    }

    public Cuenta(int tipoCuenta, int numeroCuenta, int estadoCuenta, decimal saldo, int exentoGmf, int clienteId)
    {
        
        TipoCuenta = (TipoCuentaBancaria)tipoCuenta;
        NumeroCuenta = numeroCuenta;
        EstadoCuenta = (EstadoCuentaCliente)estadoCuenta;
        Saldo = saldo;
        ExentoGmf = exentoGmf;
        FechaCreacionCuenta = DateTime.Now;
        FechaActualizacionCuenta = DateTime.Now;
        ClienteId = clienteId;
    }

    public int Id { get; set; }

    public TipoCuentaBancaria TipoCuenta { get; set; }

    public int NumeroCuenta { get; set; }

    public  EstadoCuentaCliente  EstadoCuenta{ get; set; }

    public decimal Saldo { get; set; }

    public int ExentoGmf { get; set; }

    public DateTime? FechaCreacionCuenta { get; set; }

    public DateTime? FechaActualizacionCuenta { get; set; }

    public int ClienteId { get; set; }

}
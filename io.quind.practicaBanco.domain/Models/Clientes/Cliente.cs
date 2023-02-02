using System;
using System.Collections.Generic;
using io.quind.practicaBanco.domain.Models;
using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.Models.Clientes;

public  class Cliente
{
    public Cliente()
    {
    }

    public Cliente( int tiposIdentificacion, int numeroIdentificacion,
        string nombre, string apellido, string email, DateTime fechaNacimiento)
    {
        
        TiposIdentificacion = (TipoIdentificacionCliente)tiposIdentificacion;
        NumeroIdentificacion = numeroIdentificacion;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        FechaNacimiento = fechaNacimiento;
        FechaCreacionRegistro = DateTime.Now;
        FechaActualizacionRegistro = DateTime.Now;

 
        
    }

    public int Id { get; set; }

    public TipoIdentificacionCliente TiposIdentificacion { get; set; }

    public int NumeroIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaCreacionRegistro { get; set; }

    public DateTime? FechaActualizacionRegistro { get; set; }

    
}

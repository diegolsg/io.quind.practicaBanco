using System;
using System.Collections.Generic;
using io.quind.practicaBanco.domain.Models.Clientes;
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
        validarMayorEdad(fechaNacimiento);
        validarNumeroIdentificacion(numeroIdentificacion);
        validarCaracteres(nombre);

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
    private void validarMayorEdad(DateTime fechanacimiento)
    {
        if (((DateTime.Now - fechanacimiento).Days / 365.25) < 18)
        {
            throw new ClienteException("cliente menor de edad");
        }
    }
    private void validarNumeroIdentificacion(int numer)
    {
        try
        {
            int b = (numer) + 0;
        }

        catch
        {
            throw new ClienteException("numero de caracteres en apellido o nombre incorrecto");

        }
    }
    private void validarCaracteres(string cliente)
    {
        if (cliente == null) { throw new ArgumentNullException("cracteres icorrectos"); };
    }



}

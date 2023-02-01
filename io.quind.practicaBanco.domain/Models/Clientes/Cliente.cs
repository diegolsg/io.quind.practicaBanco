using System;
using System.Collections.Generic;
using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.Models.Clientes;

public  class Cliente
{
    public Cliente(int id, int tiposIdentificacion, int numeroIdentificacion,
        string nombre, string apellido, string email, DateTime? fechaNacimiento,
        DateTime? fechaCreacionRegistro, DateTime? fechaActualizacionRegistro)
    {
        Id = id;
        TiposIdentificacion = tiposIdentificacion;
        NumeroIdentificacion = numeroIdentificacion;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        FechaNacimiento = fechaNacimiento;
        FechaCreacionRegistro = fechaCreacionRegistro;
        FechaActualizacionRegistro = fechaActualizacionRegistro;
        
    }

    public int Id { get; set; }

    public int TiposIdentificacion { get; set; }

    public int NumeroIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public DateTime? FechaCreacionRegistro { get; set; }

    public DateTime? FechaActualizacionRegistro { get; set; }

    public virtual ICollection<CuentaEntidad> CuentaEntidads { get; } = new List<CuentaEntidad>();
}

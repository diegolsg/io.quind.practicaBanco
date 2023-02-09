using System;
using System.Collections.Generic;

namespace io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;

public class Cliente
{
    public int Id { get; set; }

    public TipoIdentificacionCliente TiposIdentificacion { get; set; }

    public int NumeroIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public DateTime? FechaCreacionRegistro { get; set; }

    public DateTime? FechaActualizacionRegistro { get; set; }
}
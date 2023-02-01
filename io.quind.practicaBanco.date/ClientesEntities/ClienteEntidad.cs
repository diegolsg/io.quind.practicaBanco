using System;
using System.Collections.Generic;
using io.quind.practicaBanco.entity.CuentasEntiies;

namespace io.quind.practicaBanco.entity.ClientesEntities;

public partial class ClienteEntidad
{
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

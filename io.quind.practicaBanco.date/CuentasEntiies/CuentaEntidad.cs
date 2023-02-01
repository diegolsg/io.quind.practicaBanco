using System;
using System.Collections.Generic;
using io.quind.practicaBanco.entity.ClientesEntities;
using io.quind.practicaBanco.entity.TransaccionesEntities;

namespace io.quind.practicaBanco.entity.CuentasEntiies;

public partial class CuentaEntidad
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

    public virtual ClienteEntidad Cliente { get; set; } = null!;

    public virtual ICollection<TransaccionEntidad> TransaccionEntidads { get; } = new List<TransaccionEntidad>();
}

using System;
using System.Collections.Generic;
using io.quind.practicaBanco.entity.CuentasEntiies;

namespace io.quind.practicaBanco.entity.TransaccionesEntities;

public partial class TransaccionEntidad
{
    public int Id { get; set; }

    public decimal Monto { get; set; }

    public string CuentaDestino { get; set; } = null!;

    public DateTime? FechaTransaccion { get; set; }

    public int CuentaId { get; set; }

    public virtual CuentaEntidad Cuenta { get; set; } = null!;
}

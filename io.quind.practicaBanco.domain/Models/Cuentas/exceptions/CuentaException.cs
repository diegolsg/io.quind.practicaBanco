using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Models.Cuentas.exceptions
{
    public class CuentaException : ApplicationException
    {
        public CuentaException(string? message) : base(message)
        {
        }
    }
}

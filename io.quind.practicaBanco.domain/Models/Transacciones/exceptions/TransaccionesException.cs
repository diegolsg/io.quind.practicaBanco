using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Models.Transaccioness.exceptions
{
    public class TransaccionesException : ApplicationException
    {
        public TransaccionesException(string? message) : base(message)
        {
        }
    }
}

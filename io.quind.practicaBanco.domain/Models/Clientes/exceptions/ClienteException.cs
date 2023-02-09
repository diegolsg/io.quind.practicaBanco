using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Models.Clientes.exceptions
{
    public class ClienteException : ApplicationException
    {
        public ClienteException(string? message) : base(message)
        {
        }
    }
}

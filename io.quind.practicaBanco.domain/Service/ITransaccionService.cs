using io.quind.practicaBanco.domain.Models;
using io.quind.practicaBanco.Models.Transacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Service
{
    public interface ITransaccionService
    {
        Transaccion findById(int id);
        bool Crear(Transaccion transaccion);
    }
}

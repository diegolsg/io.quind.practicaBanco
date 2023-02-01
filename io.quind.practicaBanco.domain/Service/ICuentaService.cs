
using io.quind.practicaBanco.Models.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Service
{
     public interface ICuentaService
    {
        Cliente findById(int id);
        bool Crear(Cliente cliente);
        bool Eliminar(int id);
        bool Editar(Cliente cliente);
    }
}

using io.quind.practicaBanco.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Service
{
    public interface ICuentaService
    {
            Cuenta findById(int id);
            bool Crear(Cuenta cliente);
            bool Eliminar(int id);
            bool Editar(Cuenta cuenta);
        }
}



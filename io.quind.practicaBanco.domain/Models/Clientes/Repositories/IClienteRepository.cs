using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Models.Clientes.Repositories
{
    public interface IClienteRepository
    {
        Cliente BuscarPorNumIden(int numero);
        void Save(Cliente cliente);
        bool Editar(Cliente cliente);
        bool Eliminar(int id);
    }
}

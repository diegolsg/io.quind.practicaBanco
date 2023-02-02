using io.quind.practicaBanco.Models.Clientes;

namespace io.quind.practicaBanco.domain.Service
{
    public interface IClienteService
    {
        Cliente findById(int id);
        bool Crear(Cliente cliente);
        bool Eliminar(int id);
        bool Editar(Cliente cliente);
    }
}

using io.quind.practicaBanco.domain.Models.Clientes.ClientesModels;

namespace io.quind.practicaBanco.domain.Models.Clientes.Services
{
    public interface IClienteService
    {
        Cliente BuscarPorNumIden(int numero);
        void Crear(Cliente cliente);
        bool Eliminar(int numero);
        bool Editar(Cliente cliente);
    }
}

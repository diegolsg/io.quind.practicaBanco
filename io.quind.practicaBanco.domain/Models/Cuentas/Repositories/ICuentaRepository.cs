using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;

namespace io.quind.practicaBanco.domain.Models.Cuentas.Repositories
{
    public interface ICuentaRepository
    {
        Cuenta BuscarPorNumCuen(int numero);
        void Save(Cuenta cuenta);
        void Eliminar(int id);
        bool Editar(Cuenta cuenta);
        
    }
}

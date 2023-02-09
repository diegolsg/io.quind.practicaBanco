using io.quind.practicaBanco.domain.Models.Cuentas.CuentasModels;

namespace io.quind.practicaBanco.domain.Models.Cuentas.Services
{
    public interface ICuentaService
    {
        Cuenta BuscarPorNumCuen(int numero);
        void Crear(Cuenta cuenta);
        void Eliminar(int id);
        bool Editar(Cuenta cuenta);
    }
}

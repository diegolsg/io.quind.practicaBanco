using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;

namespace io.quind.practicaBanco.domain.Models.Transacciones.Services
{
    public interface ITransaccionService
    {
        Transaccion BuscarPorNumCuen(int numero);
        void Crear(Transaccion transaccion);
       
    }
}

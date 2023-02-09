using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;

namespace io.quind.practicaBanco.domain.Models.Transacciones.Repositories
{
    public interface ITransaccionRepository
    {
        Transaccion? BuscarPorNumCuen(int numero);
        //void Save(Transaccion transaccion);
    }
}

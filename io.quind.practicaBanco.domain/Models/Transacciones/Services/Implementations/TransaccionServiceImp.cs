using io.quind.practicaBanco.domain.Models.Transacciones.Repositories;
using io.quind.practicaBanco.domain.Models.Transacciones.RulesImplements;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.domain.Rules;

namespace io.quind.practicaBanco.domain.Models.Transacciones.Services.Implementations;
public class TransaccionServiceImp : ITransaccionService
{ 

    private readonly IRuleTransaccion<Transaccion> rule;
    private readonly ITransaccionRepository transaccionRepository;
    public TransaccionServiceImp(ITransaccionRepository transaccionRepository,RuleTransaccion rule)
    {
        this.rule = rule;
        this.transaccionRepository = transaccionRepository;

    }

    public Transaccion BuscarPorNumCuen(int numero)
    {
        throw new NotImplementedException();
    }

    public void Crear(Transaccion transaccion)
    {
        throw new NotImplementedException();
    }
}

   



using io.quind.practicaBanco.domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io.quind.practicaBanco.domain.Models.Cuentas.Repositories;
using io.quind.practicaBanco.domain.Models.Transacciones.TransaccionModels;
using io.quind.practicaBanco.domain.Models.Transacciones.Repositories;

namespace io.quind.practicaBanco.domain.Models.Transacciones.RulesImplements
{
    public class RuleTransaccion : IRuleTransaccion<Transaccion>

    {
        public readonly ITransaccionRepository transaccionRepository;
        public RuleTransaccion(ITransaccionRepository transaccionRepository)
        {
            this.transaccionRepository = transaccionRepository;
        }

        public void Validar(Transaccion model)
        {
            throw new NotImplementedException();
        }
    }
}
       
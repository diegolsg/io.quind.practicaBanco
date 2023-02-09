using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Rules
{
    public interface IRuleTransaccion<T>
    {
        void Validar(T model);
    }
}

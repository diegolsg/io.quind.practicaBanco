using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Rules
{
    public interface IRuleCuenta<T>
    {
        void Validar(T model);
        void ValidarEli(int  id);
    }
}

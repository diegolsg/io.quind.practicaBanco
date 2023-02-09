using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.quind.practicaBanco.domain.Assemblers
{
    public interface IAssembler<Tin, Rout>
    {
        Rout AssemblerObject(Tin Tin);
    }
}

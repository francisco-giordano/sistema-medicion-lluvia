using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public interface IABM<T>
    {
        bool Alta(T objeto);
        bool Baja(T objeto);
        bool Modificacion(T objeto);
    }
}

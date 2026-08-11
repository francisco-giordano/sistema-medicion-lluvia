using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia.seguridad
{
    public class Acceso
    {
        public static bool EsClaveSegura(string clave)
        {
            if (clave.Length < 8) return false;
            if (!char.IsUpper(clave[0])) return false;
            bool TieneNUmero = false;
            bool TieneEspecial = false;
            foreach (char C in clave)
            {
                if (char.IsDigit(C)) TieneNUmero = true;
                if (!char.IsLetterOrDigit(C)) TieneEspecial = true;

                if (TieneNUmero && TieneEspecial) break;
            }
            return TieneNUmero && TieneEspecial;
        }


    }
}

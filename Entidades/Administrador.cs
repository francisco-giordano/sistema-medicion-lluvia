using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public class Administrador : Usuario
    {

        public Familia MiFamilia { get; set; }

        public Administrador(string nombre, string clave, string pais, Familia familia)
            : base(nombre, clave, pais)
        {
            MiFamilia = familia;

        }

    }
}

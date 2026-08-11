using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public abstract class Medicion
    {
        public DateTime FechaHora { get; set; }

        public string Localidad { get; set; }

        public string Responsable { get; set; }

        public abstract double obtenerValor();

    }
}

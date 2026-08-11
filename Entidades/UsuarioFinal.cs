using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public class UsuarioFinal : Usuario, ICloneable
    {
        public DateTime FechaRegistro { get; set; }

        


        public UsuarioFinal(
            string nombre,
            string clave,
            string pais
           )
            : base(nombre, clave, pais)
        {
            FechaRegistro = DateTime.Now;
        }
        public object Clone()
        {
            // MemberwiseClone crea una copia superficial del objeto
            UsuarioFinal clon = (UsuarioFinal)this.MemberwiseClone();

            // Nota: Como 'MiFamilia' es un objeto, la copia superficial hace que ambos 
            // compartan la misma familia.
            return clon;
        }

    }
}

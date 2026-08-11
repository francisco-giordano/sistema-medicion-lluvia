using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public abstract class Usuario
    {
        public string NombreUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public string Pais { get; set; }
        public Familia MiFamilia { get; set; } = new Familia();

        protected Usuario(string nombre, string clave, string pais)
        {
            NombreUsuario = nombre;
            ClaveUsuario = clave;
            Pais = pais;
        }

        public void AsignarFamilia(Familia familia)
        {
            MiFamilia = familia;
        }
    }
}

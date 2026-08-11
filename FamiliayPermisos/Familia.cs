using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public class Familia:IABM<Permisos>
    {
        public int _IdFamilia { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        private List<Permisos> LPermisos { get; set; }

        public Familia()
        {
            LPermisos =
                new List<Permisos>();
        }
        public bool Alta(Permisos nuevoPermiso)
        {
            if (nuevoPermiso != null)
            {
                AgregaPermiso(nuevoPermiso);
                return true;
            }
            return false;
        }

        // 3. BAJA
        public bool Baja(Permisos permisoAEliminar)
        {
            return LPermisos.Remove(permisoAEliminar);
        }

        // 4. MODIFICACION
        public bool Modificacion(Permisos permisoModificado)
        {
            foreach (Permisos p in LPermisos)
            {
                if (p._IdPermisos == permisoModificado._IdPermisos)
                {
                    p.Descripcion = permisoModificado.Descripcion;
                    p.Estado = permisoModificado.Estado;
                    return true;
                }
            }
            return false;
        }

        private void AgregaPermiso(
            Permisos cual)
        {
            LPermisos.Add(cual);
        }


    }
}

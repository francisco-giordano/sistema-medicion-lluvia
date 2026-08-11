using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia.seguridad
{
    public static class Bitacora
    {   // 1. El que ya tenés: Registro simple
        public static void Registrar(string mensaje)
        {

            string linea = DateTime.Now.ToString() + " - " + mensaje;

            GestorArchivos.EscribirBitacora("Bitacora.txt", linea);

        }
        // 2. La SOBRECARGA: Registro con etiqueta de tipo (ej: "[ERROR] Falló el login")
        public static void Registrar(string mensaje, string tipo)
        {
            string linea = DateTime.Now.ToString() + " - [" + tipo.ToUpper() + "] " + mensaje;
            GestorArchivos.EscribirBitacora("Bitacora.txt", linea);
        }
    }
}
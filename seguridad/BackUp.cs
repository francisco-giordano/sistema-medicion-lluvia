using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyeto_Medicios_de_LLuvia.seguridad
{
    public class BackUp
    {

        public static class Backup
        {
            public static void RealizarBackup()
            {
                string archivoOriginal = "usuario.csv";
               
                string archivoDestino = $"backup_usuario_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (File.Exists(archivoOriginal))
                {
                    File.Copy(archivoOriginal, archivoDestino, true);
                    Bitacora.Registrar($"SISTEMA: Backup realizado en {archivoDestino}");
                }
            }
        }

    }
}

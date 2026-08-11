using Proyeto_Medicios_de_LLuvia.seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyeto_Medicios_de_LLuvia.seguridad
{
    public class Restore
    {
      
        
            // Le pasamos por parámetro la ruta (el camino completo) del archivo de backup que queremos usar
            public static bool RestaurarBaseDeDatos(string rutaArchivoBackup)
            {
                // Este es el nombre del archivo principal que usa tu sistema para leer (asegurate de usar el mismo nombre)
                string archivoPrincipal = "usuarios.csv";

                try
                {
                    // 1. Verificamos que el archivo viejo que nos pasaron realmente exista
                    if (File.Exists(rutaArchivoBackup))
                    {
                        // 2. ¡LA MAGIA! Copiamos el backup y pisamos el archivo principal. 
                        // El "true" al final le da permiso a C# para sobreescribir sin preguntar.
                        File.Copy(rutaArchivoBackup, archivoPrincipal, true);

                        // 3. Dejamos un registro en la bitácora de quién y cuándo hizo esto
                        Bitacora.Registrar($"[SISTEMA] Base de datos restaurada usando el archivo: {rutaArchivoBackup}");

                        return true;
                    }
                    else
                    {
                        Bitacora.Registrar($"[ERROR] Intento de Restore fallido. No se encontró el archivo: {rutaArchivoBackup}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    // Si el archivo está abierto en otra parte o Windows no nos deja, capturamos el error para que no explote el programa
                    Bitacora.Registrar($"[ERROR CRÍTICO] Falló el Restore: {ex.Message}");
                    return false;
                }
            }
     }

 }

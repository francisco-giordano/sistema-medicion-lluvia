using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Proyeto_Medicios_de_LLuvia
{
    public class GestorArchivos
    {
        public string leer(string nombre, string queBusco)
        {
            if (File.Exists("usuarios.csv"))
            {
                FileStream fs = new FileStream("usuarios.csv", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string linea;
                
                
                linea = sr.ReadLine();
                linea = sr.ReadLine();
                while (linea != null)
                {
                    
                    string[] vl=linea.Split(';');
                    
                    if (nombre == vl[0])
                    {
                        return "nombre" + vl[0]+"Edad"+vl[1]+"Pais"+vl[2];
                    }

                    linea = sr.ReadLine();
                }

                return "no encontrado";
            }
            return null;
        }


        public void escribir(string nombre, string texto)
        {
            
                FileStream fs = new FileStream(nombre, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
               
                sw.WriteLine(texto);

                sw.Close();
                fs.Close();
            
        }

        public static void EscribirBitacora(string nombreArchivo, string linea)
        {
            using (StreamWriter sw = new StreamWriter( nombreArchivo, true))
            {
                sw.WriteLine(linea);
            }
        }

        public string Buscar(string nombre, string queBusco)
        {
            string x = "";

            return x;
        }
        public void CargarUsuariosMemoria()
        {
            GestionUsuarios.listaTotal.Clear();
            // Verificamos el nombre correcto del archivo
            if (File.Exists("usuarios.csv"))
            {
                // File.ReadAllLines lee todo el archivo de golpe y lo separa en un arreglo
                string[] lineas = File.ReadAllLines("usuarios.csv");

                foreach (string linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    string[] vl = linea.Split(';');

                    // Si la línea tiene los 4 datos (Nombre, Clave, Pais, Familia)
                    if (vl.Length >= 4)
                    {
                        UsuarioFinal usuarioCargado = new UsuarioFinal(vl[0], vl[1], vl[2]);

                        // Le asignamos la familia que guardamos
                        Familia seleccionada = GestionRoles.Familias.FirstOrDefault(f => f.Descripcion == vl[3]);
                        usuarioCargado.MiFamilia = seleccionada;

                        // IMPORTANTE: Aquí debes agregarlo a la lista RAM de tu sistema
                        // Reemplaza 'listaTotal' por el nombre real de tu lista en GestionUsuarios
                        GestionUsuarios.listaTotal.Add(usuarioCargado);
                    }
                }
            }
        }
    }
}

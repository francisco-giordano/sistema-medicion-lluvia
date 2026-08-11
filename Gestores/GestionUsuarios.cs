using Proyeto_Medicios_de_LLuvia.seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Proyeto_Medicios_de_LLuvia
{
    public static class GestionUsuarios
    {
        public static List<Usuario> listaTotal = new List<Usuario>();

        public static void Agregar(Usuario nuevo)
        {
            listaTotal.Add(nuevo);
        }
        // 1. El que ya tenés: Busca por nombre
        public static Usuario Buscar(string nombre)
        {
            foreach (Usuario user in listaTotal)
            {
                if (user.NombreUsuario == nombre)
                {
                    return user;
                }
            }
            return null;
        }
        // 2. La SOBRECARGA: Se llama igual, pero busca por Familia (Rol)
        public static List<Usuario> Buscar(Familia rolBuscado)
        {
            List<Usuario> encontrados = new List<Usuario>();
            foreach (Usuario user in listaTotal)
            {
                if (user.MiFamilia != null && user.MiFamilia.Descripcion == rolBuscado.Descripcion)
                {
                    encontrados.Add(user);
                }
            }
            return encontrados;
        }

        public static bool ExisteUsuario(string nombre)
        {
            return Buscar(nombre) != null;
        }
        public static bool ValidarLogin(string nombre, string clave)
        {
            Usuario user = Buscar(nombre);
            if (user != null)
            {
                string claveEncriptada = EncriptarClave(clave);
                if (user.ClaveUsuario == claveEncriptada)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Registrar(Usuario nuevoUsuario)
        {
           
            if (!EsClaveSegura(
                nuevoUsuario.ClaveUsuario))
            {
                return false;
            }

            if (ExisteUsuario(
                nuevoUsuario.NombreUsuario))
            {
                return false;
            }

            nuevoUsuario.ClaveUsuario =
                EncriptarClave(
                    nuevoUsuario.ClaveUsuario);

            listaTotal.Add(nuevoUsuario);

            Bitacora.Registrar("Se registró el usuario " + nuevoUsuario.NombreUsuario);
            return true;

        }
       
        public static Usuario UsuarioLogueado { get; set; }
        public static void LogOut()
        {

            UsuarioLogueado = null;


        }
        public static string RecuperarClave(string nombre)
        {
            Usuario user = Buscar(nombre);

            if (user != null)
            {
                return user.ClaveUsuario;
            }
            return "Usuario no encontrado";
        }
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
        public static string EncriptarClave(string ClaveOriginal)
        {
            using (SHA256 sha256hasH = SHA256.Create())
            {
                byte[] bytes = sha256hasH.ComputeHash(Encoding.UTF8.GetBytes(ClaveOriginal));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}

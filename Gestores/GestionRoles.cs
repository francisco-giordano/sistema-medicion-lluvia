using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public static class GestionRoles
    {
        

        public static List<Familia> Familias =
            new List<Familia>();


        public static void IniciarRoles()
        {
            Familias.Clear();

            Permisos Agregar =
                new Permisos
                {
                    _IdPermisos = 1,
                    Descripcion = "Agregar",
                    Estado = true
                };

            Permisos Eliminar =
                new Permisos
                {
                    _IdPermisos = 2,
                    Descripcion = "Eliminar",
                    Estado = true
                };

            Permisos Modificar =
                new Permisos
                {
                    _IdPermisos = 3,
                    Descripcion = "Modificar",
                    Estado = true
                };

            Permisos MostrarList =
                new Permisos
                {
                    _IdPermisos = 4,
                    Descripcion = "MostrarList",
                    Estado = true
                };

            Permisos Buscar =
                new Permisos
                {
                    _IdPermisos = 5,
                    Descripcion = "Buscar",
                    Estado = true
                };


            
            Familia admin =
                new Familia
                {
                    _IdFamilia = 1,
                    Descripcion = "Administrador",
                    Estado = true
                };

            admin.Alta(Agregar);
            admin.Alta(Eliminar);  
            admin.Alta(Modificar);
            admin.Alta(MostrarList);
            admin.Alta(Buscar);


            

            Familia Usuario =
                new Familia
                {
                    _IdFamilia = 2,
                    Descripcion = "Usuario",
                    Estado = true
                };

            Usuario.Alta(Agregar);
            Usuario.Alta(Buscar);


            

            Familia SuperUsuario =
                new Familia
                {
                    _IdFamilia = 3,
                    Descripcion = "Superusuario",
                    Estado = true
                };

            SuperUsuario.Alta(Agregar);
            SuperUsuario.Alta(Buscar);
            SuperUsuario.Alta(MostrarList);



            Familia Visitante =
                new Familia
                {
                    _IdFamilia = 4,
                    Descripcion = "Visitante",
                    Estado = true
                };

            Visitante.Alta(Buscar);


           

            Familia Cliente =
                new Familia
                {
                    _IdFamilia = 5,
                    Descripcion = "Cliente",
                    Estado = true
                };

            Cliente.Alta(Buscar);
            Cliente.Alta(MostrarList);

            Familias.Add(admin);

            Familias.Add(Usuario);

            Familias.Add(SuperUsuario);

            Familias.Add(Visitante);

            Familias.Add(Cliente);
        }
    }
}

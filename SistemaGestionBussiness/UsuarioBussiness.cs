using SistemaGestionData;
using SistemaGestionEntities;
using System.Net.NetworkInformation;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ObtenerUsuarios()
        {
            return UsuarioData.ObtenerUsuario(1);
        }

        public static List<Usuario> ListarUsuario()
        {
            return UsuarioData.ListarUsuario();
        }

        public static List<Usuario> CrearUsuario(Usuario usuario)
        {
            return UsuarioData.CrearUsuario();
        }
        public static List<Usuario> ModificarUsuario(Usuario usuario)
        {
            return UsuarioData.ModificarUsuario();

        }
        public static List <Usuario> EliminarUsuario(int id) 
        {
            return UsuarioData.EliminarUsuario();
        }

        public static List<Usuario> Login (string NombreUsuario, string Contrasena)
        {
            var login = SistemaGestionData.UsuarioData.ListarUsuario();
            bool control = false;
            if (login != null)
            {
                foreach (var item in login)
                {
                    if (item.Contrasena == Contrasena && item.NombreUsuario == NombreUsuario) 
                    {
                    control = true;
                        break;
                    }

                }
                if (control)
                {
                    return login;  
                }
                else
                {
                    return null;
                }
            }
            return login;
        }
       
    }

}
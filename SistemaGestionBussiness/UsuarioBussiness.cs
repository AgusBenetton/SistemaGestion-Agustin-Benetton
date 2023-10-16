using SistemaGestionData;
using SistemaGestionEntities;

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

        public static List<Usuario> CrearUsuario()
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
    }

}
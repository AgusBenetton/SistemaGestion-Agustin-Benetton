
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioNameBussiness
    {
        public static List<UsuarioName> ObtenerUsuarioNombre()
        {
            return UsuarioData.ObtenerNombre(1);
        }


    }
} 

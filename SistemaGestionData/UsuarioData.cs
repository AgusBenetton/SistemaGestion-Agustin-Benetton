using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class UsuarioData
    {

        public static List<Usuario> ObtenerUsuario(int IdUsuario)
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Name,Apellido,NombreUsuario,Contrasena,Mail FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdUsuario;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["ID"]);
                                usuario.Name = Convert.ToString(dr["Name"]);
                                usuario.Apellido = Convert.ToString(dr["Apellido"]);
                                usuario.NombreUsuario = Convert.ToString(dr["NombreUsuario"]);
                                usuario.Contrasena = Convert.ToString(dr["Contrasena"]);
                                usuario.Mail = Convert.ToString(dr["Mail"]);
                                lista.Add(usuario);

                            }
                        }
                    }
                }

            }
            return lista;
        }

        public static List<UsuarioName> ObtenerNombre(int IdUsuario)
        {
            List<UsuarioName> lista = new List<UsuarioName>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Name FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdUsuario;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new UsuarioName();
                                usuario.Id = Convert.ToInt32(dr["ID"]);
                                usuario.Name = Convert.ToString(dr["Name"]);
                                usuario.Apellido = Convert.ToString(dr["Apellido"]);
                                lista.Add(usuario);

                            }
                        }
                    }
                }

            }
            return lista;
        }


        public static List<Usuario> ListarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Name,Apellido,NombreUsuario,Contrasena,Mail FROM Usuario";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["ID"]);
                                usuario.Name = Convert.ToString(dr["Name"]);
                                usuario.Apellido = Convert.ToString(dr["Apellido"]);
                                usuario.NombreUsuario = Convert.ToString(dr["NombreUsuario"]);
                                usuario.Contrasena = Convert.ToString(dr["Contrasena"]);
                                usuario.Mail = Convert.ToString(dr["Contrasena"]);
                                lista.Add(usuario);

                            }

                        }
                    }
                }

            }
            return lista;
        }




        public static List<Usuario> CrearUsuario(Usuario Usuario)
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "INSERT INTO usuario (Id,Name,Apellido,NombreUsuario,Contrasena,Mail FROM Usuario)" +
                           "VALUES(@Id,@Name,@Apellido,@NombreUsuario,@Contrasena,@mail)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Usuario.Id });
                    command.Parameters.Add(new SqlParameter("Name", SqlDbType.VarChar) { Value = Usuario.Name });
                    command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = Usuario.Apellido });
                    command.Parameters.Add(new SqlParameter("NombreUsusario", SqlDbType.VarChar) { Value = Usuario.NombreUsuario });
                    command.Parameters.Add(new SqlParameter("Contrasena", SqlDbType.VarChar) { Value = Usuario.Contrasena });
                    command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = Usuario.Mail });
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Usuario> ModificarUsuario(Usuario Usuario)
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";
            var query = "UPDATE Usuario" + "SET Id = @Id" + " , Name = @Name" + " , Apellido = @Apellido" +
                         " , NombreUsusario = @NombreUsuario" + ", contrasena = @Contrasena" + ", Mail = @Mail" + "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Usuario.Id });
                    command.Parameters.Add(new SqlParameter("Name", SqlDbType.VarChar) { Value = Usuario.Name });
                    command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = Usuario.Apellido });
                    command.Parameters.Add(new SqlParameter("NombreUsusario", SqlDbType.VarChar) { Value = Usuario.NombreUsuario });
                    command.Parameters.Add(new SqlParameter("Contrasena", SqlDbType.VarChar) { Value = Usuario.Contrasena });
                    command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = Usuario.Mail });
                }
                connection.Close();
            }
            return lista;
        }



        public static List<Usuario> EliminarUsuario(Usuario Usuario)
        {
            List<Usuario> lista = new List<Usuario>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            var query = "DELETE FROM usuario WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", SqlDbType.VarChar) { Value = Usuario.Id });
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Usuario> CrearUsuario()
        {
            throw new NotImplementedException();
        }

        public static List<Usuario> ModificarUsuario()
        {
            throw new NotImplementedException();
        }

        public static List<Usuario> EliminarUsuario()
        {
            throw new NotImplementedException();
        }
    }
}

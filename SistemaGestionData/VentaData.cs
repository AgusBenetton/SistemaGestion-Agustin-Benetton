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
    internal class VentaData
    {
        public static List<Venta> ObtenerVenta(int IdVenta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdVenta;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var Venta = new Venta();
                                Venta.Id = Convert.ToInt32(dr["ID"]);
                                Venta.Comentarios = Convert.ToString(dr["IdProducto"]);
                                Venta.IdUsuario = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(Venta);

                            }
                        }
                    }
                }

            }
            return lista;
        }

        public static List<Venta> ListarVenta()
        {
            List<Venta> lista = new List<Venta>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            var Venta = new Venta();
                            Venta.Id = Convert.ToInt32(dr["ID"]);
                            Venta.Comentarios = Convert.ToString(dr["IdProducto"]);
                            Venta.IdUsuario = Convert.ToInt32(dr["IdVenta"]);
                            lista.Add(Venta);

                        }
                    }
                }
            }
            return lista;
        }
        public static List<Venta> CrearVenta(Venta Venta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "INSERT INTO usuario (Id,Comentarios,IdUsuario FROM Venta)" +
                           "VALUES(@Id,@Comentarios,@IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Venta.Id });
                    command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = Venta.Comentarios });
                    command.Parameters.Add(new SqlParameter("IdUsuarios", SqlDbType.Int) { Value = Venta.IdUsuario });
                }
                connection.Close();
            }
            return lista; 

        }

        public static List<Venta> ModificarVenta(Venta Venta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            var query = "UPDATE Venta" + "SET Id = @Id" + " , Comentarios = @Comentarios" +
                             ", IdUsuario = @IdUsuario" + "WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Venta.Id });
                    command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = Venta.Comentarios });
                    command.Parameters.Add(new SqlParameter("IdUsuarios", SqlDbType.Int) { Value = Venta.IdUsuario });
                }
                connection.Close();
            }
            return lista;
        }

        public static List<Venta> EliminarVenta(Venta Venta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", SqlDbType.VarChar) { Value = Venta.Id });
                }
                connection.Close();
            }
            return lista;
        }
        
    }
}

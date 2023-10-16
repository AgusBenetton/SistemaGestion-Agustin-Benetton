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
    public class ProductoData
    {


        public static List<Producto> ObtenerProducto(int IdProducto)
        {
            List<Producto> lista = new List<Producto>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM producto";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProducto;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["ID"]);
                                producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                                producto.Costo = (float)dr["Costo"];
                                producto.PrecioVenta = (float)dr["PrecioVenta"];
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);

                            }
                        }
                    }
                }

            }
            return lista;
        }



        public static List<Producto> ListarProducto()
        {
            List<Producto> lista = new List<Producto>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUuario FROM producto";

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
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["ID"]);
                                producto.Descripcion = Convert.ToString(dr["Descripcion"]);
                                producto.Costo = (float)Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = (float)Convert.ToDecimal(dr["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);

                            }
                        }
                    }
                }

            }
            return lista;
        }




        public static List<Producto> CrearProducto(Producto Producto)
        {
            List<Producto> lista = new List<Producto>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "INSERT INTO usuario (Id,Descripcion,Costo,PrecioVenta,Stock,IdUuario FROM producto)" +
                           "VALUES(@Id,@Descripcion,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Producto.Id });
                    command.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = Producto.Descripcion });
                    command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = Producto.Costo });
                    command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = Producto.PrecioVenta });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = Producto.Stock });
                    command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = Producto.IdUsuario });
                }
                connection.Close();
            }
            return lista;
        }


        public static List<Producto> ModificarProducto(Producto Producto)
        {
            List<Producto> lista = new List<Producto>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";
            var query = "UPDATE Producto" + "SET Id = @Id" + " , Descripcion = @Descripcion" + " , Costo = @Costo" +
                         " , PrecioVenta = @PRecioVenta" + ", Stock = @Stock" + ", IdUsuario = @IdUsuario" + "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Producto.Id });
                    command.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = Producto.Descripcion });
                    command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = Producto.Costo });
                    command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = Producto.PrecioVenta });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = Producto.Stock });
                    command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = Producto.IdUsuario });
                }
                connection.Close();
            }
            return lista;
        }



        public static List<Producto> EliminarProducto(int Id )
        {
            List<Producto> lista = new List<Producto>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            var query = "DELETE FROM producto WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", SqlDbType.VarChar) { Value = Id });
                }
                connection.Close();
            }
            return lista;
        }
    }
}

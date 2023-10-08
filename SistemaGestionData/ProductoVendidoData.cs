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
    internal class ProductoVendidoData
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int IdProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProductoVendido;

                    command.Parameters.Add(parametro);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var ProductoVendido = new ProductoVendido();
                                ProductoVendido.Id = Convert.ToInt32(dr["ID"]);
                                ProductoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                ProductoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                ProductoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(ProductoVendido);

                            }
                        }
                    }
                }

            }
            return lista;
        }

        public static List<ProductoVendido> ListarProductoVendido()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido";

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
                                var ProductoVendido = new ProductoVendido();
                                ProductoVendido.Id = Convert.ToInt32(dr["ID"]);
                                ProductoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                ProductoVendido.Stock = Convert.ToInt32(dr["Stock"]);
                                ProductoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(ProductoVendido);

                            }
                        }
                    }
                }


               
            }
            return lista;
        }

        public static List<ProductoVendido> CrearProductoVendido(ProductoVendido ProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            string query = "INSERT INTO usuario (Id,IdProducto,Stock,IdVenta FROM ProductoVendido)" +
                           "VALUES(@Id,@IdProducto,@Stock,@IdVenta)";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = ProductoVendido.Id });
                    command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = ProductoVendido.IdProducto });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = ProductoVendido.Stock });
                    command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = ProductoVendido.IdVenta });
                }
                connection.Close();
            }
            return lista;
        }

        public static List<ProductoVendido> ModificarProductoVendido(ProductoVendido ProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";

            var query = "UPDATE ProductoVendido" + "SET Id = @Id" + " , IdProducto = @IdProducto" + " , Costo = @Costo" +
                             ", IdVenta = @IdVenta" + "WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = ProductoVendido.Id });
                    command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = ProductoVendido.IdProducto });
                    command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = ProductoVendido.Stock });
                    command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = ProductoVendido.IdVenta });
                }
                connection.Close();
            }
            return lista;
        }
        public static List<ProductoVendido> EiminarProductoVendido(ProductoVendido ProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionstring = @"Server=DESKTOP-PURSVAM;DataBase=gestion;trusted_connection=true";
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", SqlDbType.VarChar) { Value = ProductoVendido.Id });
                }
                connection.Close();
            }
            return lista;
        }
    }
}

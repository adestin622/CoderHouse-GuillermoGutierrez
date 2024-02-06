using Desafio2_GuillermoMGutierrez.Clases;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_GuillermoMGutierrez.ClasesData
{
    public static class ProductoVendidoData
    {
        private const string conexionString = @"Server=GUILLERMO\SQLCODERHOUSE;Trusted_Connection=True";

        public static List<ProductoVendido> ListarProdVendido()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[ProductoVendido]";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    List<ProductoVendido> list = new List<ProductoVendido>();
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ProductoVendido prodVendido = new ProductoVendido();
                        prodVendido.Id = Convert.ToInt32(dr["Id"]);
                        prodVendido.Stock = Convert.ToInt32(dr["Stock"]);
                        prodVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                        prodVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                        list.Add(prodVendido);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static List<ProductoVendido> BuscarProdVendido(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[ProductoVendido] WHERE id=@IdProdVend";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("IdProdVend", idSearch);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<ProductoVendido> list = new List<ProductoVendido>();
                    while (dr.Read())
                    {
                        ProductoVendido prodVend = new ProductoVendido();
                        prodVend.Id = Convert.ToInt32(dr["Id"]);
                        prodVend.Stock = Convert.ToInt32(dr["Stock"]);
                        prodVend.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                        prodVend.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                        list.Add(prodVend);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static bool AgregarProdVendido(int stock, int idProducto, int idVenta)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "INSERT INTO [coderhouse].[dbo].[ProductoVendido] (Stock, IdProducto, IdVenta) VALUES (@stock, @idProd, @idVent)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("stock", stock);
                    cmd.Parameters.AddWithValue("idProd", idProducto);
                    cmd.Parameters.AddWithValue("idVent", idVenta);

                    conexion.Open();
                    try
                    {
                        int intQuery = cmd.ExecuteNonQuery();
                        if (intQuery > 0)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static bool ModificarProdVendido(ProductoVendido prodVendido, int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "UPDATE [coderhouse].[dbo].[ProductoVendido] SET Stock=@stock, IdProducto=@idProd, IdVenta=@idVent WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch);
                    cmd.Parameters.AddWithValue("stock", prodVendido.Stock);
                    cmd.Parameters.AddWithValue("idProd", prodVendido.IdProducto);
                    cmd.Parameters.AddWithValue("idVent", prodVendido.IdVenta);

                    conexion.Open();
                    try
                    {
                        int intQuery = cmd.ExecuteNonQuery();
                        if (intQuery > 0)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        public static bool EliminarProductoVendido(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query_eliminar_prodVend = "DELETE FROM [coderhouse].[dbo].[ProductoVendido] WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query_eliminar_prodVend, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch); ;
                    conexion.Open();
                    try
                    {
                        int bandera = cmd.ExecuteNonQuery();
                        if (bandera > 0)
                        {
                            return true;
                        }
                        else { return false; }
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }
    }
}

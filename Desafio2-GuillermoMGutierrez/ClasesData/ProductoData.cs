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
    public static class ProductoData
    {
        private const string conexionString = @"Server=GUILLERMO\SQLCODERHOUSE;Trusted_Connection=True";

        public static List<Producto> ListarProductos()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Producto]";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    List<Producto> list = new List<Producto>();
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Producto product = new Producto();
                        product.Id = Convert.ToInt32(dr["Id"]);
                        product.Descripcion = dr["Descripciones"].ToString();
                        product.Costo = Convert.ToDouble(dr["Costo"]);
                        product.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                        product.Stock = Convert.ToInt32(dr["Stock"]);
                        product.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        list.Add(product);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static List<Producto> BuscarProducto(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Producto] WHERE id=@IdProd";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("IdProd", idSearch);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Producto> list = new List<Producto>();
                    while (dr.Read())
                    {
                        Producto product = new Producto();
                        product.Id = Convert.ToInt32(dr["Id"]);
                        product.Descripcion = dr["Descripciones"].ToString();
                        product.Costo = Convert.ToDouble(dr["Costo"]);
                        product.PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                        product.Stock = Convert.ToInt32(dr["Stock"]);
                        product.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        list.Add(product);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static bool AgregarProducto(string descrip, decimal cost, decimal precventa, int stocks, int iduser)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "INSERT INTO [coderhouse].[dbo].[Producto] (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@descrip, @cost, @precventa, @stocks, @iduser)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("descrip", descrip);
                    cmd.Parameters.AddWithValue("cost", cost);
                    cmd.Parameters.AddWithValue("precventa", precventa);
                    cmd.Parameters.AddWithValue("stocks", stocks);
                    cmd.Parameters.AddWithValue("iduser", iduser);
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

        public static bool ModificarProducto(Producto producto, int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "UPDATE [coderhouse].[dbo].[Producto] SET Descripciones=@descrip, Costo=@cost, PrecioVenta=@precventa, Stock=@stocks WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch);
                    cmd.Parameters.AddWithValue("descrip", producto.Descripcion);
                    cmd.Parameters.AddWithValue("cost", producto.Costo);
                    cmd.Parameters.AddWithValue("precventa", producto.PrecioVenta);
                    cmd.Parameters.AddWithValue("stocks", producto.Stock);
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

        public static bool EliminarProducto(int idSearch)
        {
            //se modifica la base de datos con la instruccion
            //"ALTER TABLE ProductoVendido ADD FOREIGN KEY (IdProducto) REFERENCES Producto(Id) ON DELETE CASCADE"
            //para dar lugar al DELETE de producto quitando el registro tambien de la tabla ProductoVendido
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query_eliminar_prod = "DELETE FROM [coderhouse].[dbo].[Producto] WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query_eliminar_prod, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch);;
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

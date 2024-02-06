using Desafio2_GuillermoMGutierrez.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_GuillermoMGutierrez.ClasesData
{
    public static class VentaData
    {
        private const string conexionString = @"Server=GUILLERMO\SQLCODERHOUSE;Trusted_Connection=True";

        public static List<Venta> ListarVenta()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Venta]";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    List<Venta> list = new List<Venta>();
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Venta vent = new Venta();
                        vent.Id = Convert.ToInt32(dr["Id"]);
                        vent.Comentarios = dr["Comentarios"].ToString();
                        vent.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                        list.Add(vent);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static List<Venta> BuscarVenta(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Venta] WHERE id=@IdVenta";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("IdVenta", idSearch);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Venta> list = new List<Venta>();
                    while (dr.Read())
                    {
                        Venta vent = new Venta();
                        vent.Id = Convert.ToInt32(dr["Id"]);
                        vent.Comentarios = dr["Comentarios"].ToString();
                        vent.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        
                        list.Add(vent);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static bool AgregarVenta(string comentario, int idUser)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "INSERT INTO [coderhouse].[dbo].[Venta] (Comentarios, IdUsuario) VALUES (@coment, @idVent)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("coment", comentario);
                    cmd.Parameters.AddWithValue("idVent", idUser);

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

        public static bool ModificarVenta(Venta vent, int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "UPDATE [coderhouse].[dbo].[Venta] SET Comentarios=@coment, IdUsuario=@idUser WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch);
                    cmd.Parameters.AddWithValue("coment", vent.Comentarios);
                    cmd.Parameters.AddWithValue("idUser", vent.IdUsuario);

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

        public static bool EliminarVenta(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query_eliminar_venta = "DELETE FROM [coderhouse].[dbo].[Venta] WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query_eliminar_venta, conexion))
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

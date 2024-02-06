using Desafio2_GuillermoMGutierrez.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_GuillermoMGutierrez.ClasesData
{
    public static class UsuarioData
    {
        private const string conexionString = @"Server=GUILLERMO\SQLCODERHOUSE;Trusted_Connection=True";
        
        public static List<Usuario> ListarUsuarios()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Usuario]";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    List<Usuario> list = new List<Usuario>();
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Usuario user = new Usuario();
                        user.Id = Convert.ToInt32(dr["Id"]);
                        user.Nombre = dr["Nombre"].ToString();
                        user.Apellido = dr["Apellido"].ToString();
                        user.NombreUsuario = dr["NombreUsuario"].ToString();
                        user.Contrasena = dr["Contraseña"].ToString();
                        user.Mail = dr["Mail"].ToString();
                        list.Add(user);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static List<Usuario> BuscarUsuario(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "SELECT * FROM [coderhouse].[dbo].[Usuario] WHERE id=@IdUser";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("IdUser", idSearch);
                    conexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Usuario> list = new List<Usuario>();
                    while (dr.Read())
                    {
                        Usuario user = new Usuario();
                        user.Id = Convert.ToInt32(dr["Id"]);
                        user.Nombre = dr["Nombre"].ToString();
                        user.Apellido = dr["Apellido"].ToString();
                        user.NombreUsuario = dr["NombreUsuario"].ToString();
                        user.Contrasena = dr["Contraseña"].ToString();
                        user.Mail = dr["Mail"].ToString();
                        list.Add(user);
                    }
                    conexion.Close();
                    return list;
                }
            }
        }

        public static bool AgregarUsuario(string nombre, string apellido, string nomusuario, string password, string email)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "INSERT INTO [coderhouse].[dbo].[Usuario] (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@nom, @apell, @nomUser, @pass, @email)";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("apell", apellido);
                    cmd.Parameters.AddWithValue("nomUser", nomusuario);
                    cmd.Parameters.AddWithValue("pass", password);
                    cmd.Parameters.AddWithValue("email", email);
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

        public static bool ModificarUsuario(Usuario user, int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query = "UPDATE [coderhouse].[dbo].[Usuario] SET Nombre=@nom, Apellido=@apell, NombreUsuario=@nomUser, Contraseña=@pass, Mail=@email WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("id", idSearch);
                    cmd.Parameters.AddWithValue("nom", user.Nombre);
                    cmd.Parameters.AddWithValue("apell", user.Apellido);
                    cmd.Parameters.AddWithValue("nomUser", user.NombreUsuario);
                    cmd.Parameters.AddWithValue("pass", user.Contrasena);
                    cmd.Parameters.AddWithValue("email", user.Mail);
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

        public static bool EliminarUsuario(int idSearch)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                const string query_eliminar_user= "DELETE FROM [coderhouse].[dbo].[Usuario] WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query_eliminar_user, conexion))
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

using SistemaGestionDataEntities.Database;
using SistemaGestionDataEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ListarUsuarios()
        {
            using (SGestionContext context = new())
            {
                return context.Usuarios.ToList();
            }
        }

        public static List<Usuario> BuscarUsuario(int idSearch)
        {
            using (SGestionContext context = new())
            {
                List<Usuario> userSearch = [context.Usuarios.Where(b => b.Id == idSearch).FirstOrDefault()];
                return userSearch;
            }
        }

        public static bool AgregarUsuario(Usuario newUser)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    context.Usuarios.Add(newUser);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la carga.\nError: {ex}");
                }
            }

        }

        public static bool ModificarUsuario(Usuario updatedUser, int idUpdate)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    Usuario userUpdate = BuscarUsuario(idUpdate).First();

                    if (userUpdate is not null)
                    {
                        userUpdate.Nombre = updatedUser.Nombre;
                        userUpdate.Apellido = updatedUser.Apellido;
                        userUpdate.NombreUsuario = updatedUser.NombreUsuario;
                        userUpdate.Contraseña = updatedUser.Contraseña;
                        userUpdate.Mail = updatedUser.Mail;

                        context.Usuarios.Update(userUpdate);
                        context.SaveChanges();
                        return true;
                    }
                    else { return false; }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al modificar la selección.\nError: {ex}");
                }
            }
        }

        public static bool EliminarUsuario(int idDelete)
        {
            using (SGestionContext context = new())
            {
                Usuario userDelete = context.Usuarios.Where(p => p.Id == idDelete).FirstOrDefault();

                if (userDelete is not null)
                {
                    try
                    {
                        context.Usuarios.Remove(userDelete);
                        context.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al elimminar la selección.\nError: {ex}");
                    }

                }
                else { return false; }
            }
        }

        public static Usuario InstanciaUsuario(string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            Usuario user = new();
            user.Nombre = nombre;
            user.Apellido = apellido;
            user.NombreUsuario = nombreUsuario;
            user.Contraseña = password;
            user.Mail = email;

            return user;
        }
    }
}

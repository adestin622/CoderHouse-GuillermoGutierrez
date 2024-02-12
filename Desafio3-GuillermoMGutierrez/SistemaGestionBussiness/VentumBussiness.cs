using SistemaGestionDataEntities.Database;
using SistemaGestionDataEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class VentumBussiness
    {
        public static List<Ventum> ListarVentas()
        {
            using (SGestionContext context = new())
            {
                return context.Venta.ToList();
            }
        }

        public static List<Ventum> BuscarVenta(int idSearch)
        {
            using (SGestionContext context = new())
            {
                List<Ventum> VentaSearch = [context.Venta.Where(b => b.Id == idSearch).FirstOrDefault()];
                return VentaSearch;
            }
        }

        public static bool AgregarVenta(Ventum newVenta)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    context.Venta.Add(newVenta);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la carga.\nError: {ex}");
                }
            }

        }

        public static bool ModificarVenta(Ventum updatedVenta, int idUpdate)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    Ventum ventaUpdate = BuscarVenta(idUpdate).First();

                    if (ventaUpdate is not null)
                    {
                        ventaUpdate.Comentarios = updatedVenta.Comentarios;
                        ventaUpdate.IdUsuario = updatedVenta.IdUsuario;

                        context.Venta.Update(ventaUpdate);
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

        public static bool EliminarVenta(int idDelete)
        {
            using (SGestionContext context = new())
            {
                Ventum ventaDelete = context.Venta.Where(p => p.Id == idDelete).FirstOrDefault();

                if (ventaDelete is not null)
                {
                    try
                    {
                        context.Venta.Remove(ventaDelete);
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

        public static Ventum InstanciaVenta(string comentario, int idUsuario)
        {
            Ventum venta = new();
            venta.Comentarios = comentario;
            venta.IdUsuario = Convert.ToInt32(idUsuario);

            return venta;
        }
    }
}

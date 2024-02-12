using SistemaGestionDataEntities.Database;
using SistemaGestionDataEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            using (SGestionContext context = new())
            {
                return context.ProductoVendidos.ToList();
            }
        }

        public static List<ProductoVendido> BuscarProductoVendido(int idSearch)
        {
            using (SGestionContext context = new())
            {
                List<ProductoVendido> producSearch = [context.ProductoVendidos.Where(b => b.Id == idSearch).FirstOrDefault()];
                return producSearch;
            }
        }

        public static bool AgregarProductoVendido(ProductoVendido newProducVend)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    context.ProductoVendidos.Add(newProducVend);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la carga.\nError: {ex}");
                }
            }

        }

        public static bool ModificarProductoVendido(ProductoVendido updatedProduc, int idUpdate)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    ProductoVendido producUpdate = BuscarProductoVendido(idUpdate).First();

                    if (producUpdate is not null)
                    {
                        producUpdate.Stock = updatedProduc.Stock;
                        producUpdate.IdProducto = updatedProduc.IdProducto;
                        producUpdate.IdVenta = updatedProduc.IdVenta;

                        context.ProductoVendidos.Update(producUpdate);
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

        public static bool EliminarProductoVendido(int idDelete)
        {
            using (SGestionContext context = new())
            {
                ProductoVendido producDelete = context.ProductoVendidos.Where(p => p.Id == idDelete).FirstOrDefault();

                if (producDelete is not null)
                {
                    try
                    {
                        context.ProductoVendidos.Remove(producDelete);
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

        public static ProductoVendido InstanciaProductoVendido(int stock, int idProducto, int idVenta)
        {
            ProductoVendido producVend = new();
            producVend.Stock = stock;
            producVend.IdProducto = idProducto;
            producVend.IdVenta = idVenta;

            return producVend;
        }
    }
}

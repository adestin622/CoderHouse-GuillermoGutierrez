using Microsoft.EntityFrameworkCore;
using SistemaGestionDataEntities.Database;
using SistemaGestionDataEntities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            using (SGestionContext context = new())
            {
                return context.Productos.ToList();
            }
        }

        public static List<Producto> BuscarProducto(int idSearch)
        {
            using (SGestionContext context = new())
            {
                List<Producto> producSearch = [context.Productos.Where(b => b.Id == idSearch).FirstOrDefault()];
                return producSearch;
            }
        }

        public static bool AgregarProducto(Producto newProduc)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    context.Productos.Add(newProduc);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en la carga.\nError: {ex}");
                }
            }
                
        }

        public static bool ModificarProducto(Producto updatedProduc, int idUpdate)
        {
            using (SGestionContext context = new())
            {
                try
                {
                    Producto producUpdate = BuscarProducto(idUpdate).First();

                    if (producUpdate is not null)
                    {
                        producUpdate.Descripciones = updatedProduc.Descripciones;
                        producUpdate.Costo = updatedProduc.Costo;
                        producUpdate.PrecioVenta = updatedProduc.PrecioVenta;
                        producUpdate.Stock = updatedProduc.Stock;
                        producUpdate.IdUsuario = updatedProduc.IdUsuario;

                        context.Productos.Update(producUpdate);
                        context.SaveChanges();
                        return true;
                    }
                    else { return false; }
                }catch(Exception ex) {
                    throw new Exception($"Error al modificar la selección.\nError: {ex}");
                }
            }
        }

        public static bool EliminarProducto(int idDelete)
        {
            using (SGestionContext context = new())
            {
                Producto producDelete = context.Productos.Where(p => p.Id == idDelete).FirstOrDefault();

                if (producDelete is not null)
                {
                    try
                    {
                        context.Productos.Remove(producDelete);
                        context.SaveChanges();
                        return true;
                    }catch(Exception ex)
                    {
                        throw new Exception($"Error al elimminar la selección.\nError: {ex}");
                    }
                    
                }
                else { return false; }
            }
        }
        
        public static Producto InstanciaProducto(string descrip, double costo, double precVenta, int stock, int idUsuario)
        {
            Producto produc = new();
            produc.Descripciones = descrip;
            produc.Costo = Convert.ToDecimal(costo);
            produc.PrecioVenta = Convert.ToDecimal(precVenta);
            produc.Stock = stock;
            produc.IdUsuario = idUsuario;

            return produc;
        }
    }
}

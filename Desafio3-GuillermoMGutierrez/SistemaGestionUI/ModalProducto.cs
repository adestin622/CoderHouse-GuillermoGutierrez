using SistemaGestionBussiness;
using SistemaGestionDataEntities.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class ModalProducto : Form
    {
        private int modalTipo { get; } //0 para modal "Agregar" y 1 para modal "Modificar", esto solo deshabilita el campo "IdUsuario" para evitar cambios en la FK de la BD
        private Producto producSeleccionado;

        public ModalProducto()
        {
            InitializeComponent();
        }

        public ModalProducto(int modalTipo) : this()
        {
            this.modalTipo = modalTipo;
        }

        public ModalProducto(int modalTipo, Producto producSeleccionado) : this()
        {
            this.modalTipo = modalTipo;
            this.producSeleccionado = producSeleccionado;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (modalTipo == 0)
            {
                try
                {
                    if (ProductoBussiness.AgregarProducto(ProductoBussiness.InstanciaProducto(TxtDescripcion.Text, Convert.ToDouble(TxtCosto.Text), Convert.ToDouble(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), Convert.ToInt32(TxtIdUsuario.Text))))
                    {
                        MessageBox.Show("Carga Exitosa", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error en la carga", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if (modalTipo == 1)
            {
                try
                {
                    if(ProductoBussiness.ModificarProducto(ProductoBussiness.InstanciaProducto(TxtDescripcion.Text, Convert.ToDouble(TxtCosto.Text), Convert.ToDouble(TxtPrecioVenta.Text), Convert.ToInt32(TxtStock.Text), Convert.ToInt32(TxtIdUsuario.Text)), producSeleccionado.Id))
                    {
                        MessageBox.Show("Actualización exitosa", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Error al modificar", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void LimpiarCampos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void ModalProducto_Load(object sender, EventArgs e)
        {
            if (modalTipo == 1)
            {
                TxtDescripcion.Text = producSeleccionado.Descripciones;
                TxtCosto.Text = producSeleccionado.Costo.ToString();
                TxtPrecioVenta.Text = producSeleccionado.PrecioVenta.ToString();
                TxtStock.Text = producSeleccionado.Stock.ToString();
                TxtIdUsuario.Text = producSeleccionado.IdUsuario.ToString();
                TxtIdUsuario.Enabled = false;
            }
        }
    }
}

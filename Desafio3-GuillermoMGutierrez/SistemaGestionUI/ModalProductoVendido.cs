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
    public partial class ModalProductoVendido : Form
    {
        private int modalTipo { get; } //0 para modal "Agregar" y 1 para modal "Modificar"
        private ProductoVendido producVendSeleccionado;

        public ModalProductoVendido()
        {
            InitializeComponent();
        }
        public ModalProductoVendido(int modalTipo) : this()
        {
            this.modalTipo = modalTipo;
        }

        public ModalProductoVendido(int modalTipo, ProductoVendido producVendSeleccionado) : this()
        {
            this.modalTipo = modalTipo;
            this.producVendSeleccionado = producVendSeleccionado;
        }

        private void ModalProductoVendido_Load(object sender, EventArgs e)
        {
            if (modalTipo == 1)
            {
                TxtStock.Text = producVendSeleccionado.Stock.ToString();
                TxtIdProducto.Text = producVendSeleccionado.IdProducto.ToString();
                TxtIdVenta.Text = producVendSeleccionado.IdVenta.ToString();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (modalTipo == 0)
            {
                try
                {
                    if (ProductoVendidoBussiness.AgregarProductoVendido(ProductoVendidoBussiness.InstanciaProductoVendido(Convert.ToInt32(TxtStock.Text), Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdVenta.Text))))
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
            }
            else if (modalTipo == 1)
            {
                try
                {
                    if (ProductoVendidoBussiness.ModificarProductoVendido(ProductoVendidoBussiness.InstanciaProductoVendido(Convert.ToInt32(TxtStock.Text), Convert.ToInt32(TxtIdProducto.Text), Convert.ToInt32(TxtIdVenta.Text)), producVendSeleccionado.Id))
                    {
                        MessageBox.Show("Actualización exitosa", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Error al modificar", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

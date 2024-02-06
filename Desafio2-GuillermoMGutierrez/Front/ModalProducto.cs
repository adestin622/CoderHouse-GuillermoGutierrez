using Desafio2_GuillermoMGutierrez.Clases;
using Desafio2_GuillermoMGutierrez.ClasesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_GuillermoMGutierrez.Front
{
    public partial class ModalProducto : Form
    {
        private int cargaModal;
        private Producto produc;
        
        public ModalProducto()
        {
            InitializeComponent();
        }
        public ModalProducto(int tipoModal, Producto produc) : this()
        {
            this.cargaModal = tipoModal;
            this.produc = produc;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (cargaModal == 0)
            {
                //Esto toma lugar cuando se quiere agregar un registro de Producto
                if (ProductoData.AgregarProducto(Txt_Descripcion.Text, Convert.ToDecimal(Txt_Costo.Text), Convert.ToDecimal(Txt_PrecVenta.Text), Convert.ToInt32(Txt_Stock.Text), Convert.ToInt32(Txt_IdUsuario.Text)))
                {
                    MessageBox.Show("Producto agregado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else { MessageBox.Show("Hubo un error al cargar el producto", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (cargaModal == 1)
            {
                //Esto toma lugar cuando se quiere modificar un registro de Producto
                Txt_IdUsuario.Enabled = false;
                if (ProductoData.ModificarProducto(updateProducto(), produc.Id))
                {
                    MessageBox.Show("Producto modificado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Hubo un error al modificar el producto", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

        }

        private void Limpiar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void CompletarCampos()
        {
            if (cargaModal == 1)
            {
                Txt_Descripcion.Text = produc.Descripcion;
                Txt_Costo.Text = produc.Costo.ToString();
                Txt_IdUsuario.Text = produc.IdUsuario.ToString();
                Txt_PrecVenta.Text = produc.PrecioVenta.ToString();
                Txt_Stock.Text = produc.Stock.ToString();
            }
        }
        private Producto updateProducto()
        {
            Producto updateProducto = new Producto();
            updateProducto.Descripcion = Txt_Descripcion.Text;
            updateProducto.Costo = Convert.ToDouble(Txt_Costo.Text);
            updateProducto.PrecioVenta = Convert.ToDouble(Txt_PrecVenta.Text);
            updateProducto.Stock = Convert.ToInt32(Txt_Stock.Text);
            return updateProducto;
        }

        private void ModalProducto_Load(object sender, EventArgs e)
        {
            CompletarCampos();
        }
    }
}

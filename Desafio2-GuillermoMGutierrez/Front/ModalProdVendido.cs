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
    public partial class ModalProdVendido : Form
    {
        private int cargaModal;
        private ProductoVendido prodVendido;
        
        public ModalProdVendido()
        {
            InitializeComponent();
        }
        public ModalProdVendido(int tipoModal, ProductoVendido prodVendido) : this()
        {
            this.cargaModal = tipoModal;
            this.prodVendido = prodVendido;
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
                if (ProductoVendidoData.AgregarProdVendido(Convert.ToInt32(Txt_Stock.Text), Convert.ToInt32(Txt_IdProducto.Text), Convert.ToInt32(Txt_IdVenta.Text)))
                {
                    MessageBox.Show("Producto Vendido agregado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else { MessageBox.Show("Hubo un error al cargar el producto vendido", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (cargaModal == 1)
            {
                //Esto toma lugar cuando se quiere modificar un registro de Producto
                if (ProductoVendidoData.ModificarProdVendido(updateProdVendido(), prodVendido.Id))
                {
                    MessageBox.Show("Producto Vendido modificado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Hubo un error al modificar el producto vendido", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
                Txt_Stock.Text = prodVendido.Stock.ToString();
                Txt_IdProducto.Text = prodVendido.IdProducto.ToString();
                Txt_IdVenta.Text = prodVendido.IdVenta.ToString();
            }
        }
        private ProductoVendido updateProdVendido()
        {
            ProductoVendido updateProdVendido = new ProductoVendido();
            updateProdVendido.Stock = Convert.ToInt32(Txt_Stock.Text);
            updateProdVendido.IdProducto = Convert.ToInt32(Txt_IdProducto.Text);
            updateProdVendido.IdVenta = Convert.ToInt32(Txt_IdVenta.Text);

            return updateProdVendido;
        }

        private void ModalProdVendido_Load(object sender, EventArgs e)
        {
            CompletarCampos();
        }
    }
}

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
    public partial class FrmProductoVendido : Form
    {
        private ProductoVendido prodVendSeleccionado;
        public FrmProductoVendido()
        {
            InitializeComponent();
        }

        private void FrmProductoVendido_Load(object sender, EventArgs e)
        {
            DgvProdVendido.DataSource = null;
            DgvProdVendido.DataSource = ProductoVendidoData.ListarProdVendido();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DgvProdVendido.DataSource = null;
            DgvProdVendido.DataSource = ProductoVendidoData.ListarProdVendido();
        }

        private void BtnBuscProdVendido_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_BuscarProdVendido.Text))
            {
                DgvProdVendido.DataSource = null;
                DgvProdVendido.DataSource = ProductoVendidoData.BuscarProdVendido(Convert.ToInt32(Txt_BuscarProdVendido.Text));
                Txt_BuscarProdVendido.Text = string.Empty;
            }
        }

        private void BtnAgregaProdVendido_Click(object sender, EventArgs e)
        {
            ModalProdVendido mdlProdVendido = new(0, prodVendSeleccionado);
            mdlProdVendido.ShowDialog();
        }

        private void BtnModifProdVendido_Click(object sender, EventArgs e)
        {
            ModalProdVendido mdlProdVendido = new(1, prodVendSeleccionado);
            mdlProdVendido.ShowDialog();
        }

        private void DgvProdVendido_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvProdVendido.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.prodVendSeleccionado = dato as ProductoVendido;
            }
        }

        private void BtnElimProdVendido_Click(object sender, EventArgs e)
        {
            if (ProductoVendidoData.EliminarProductoVendido(prodVendSeleccionado.Id))
            {
                MessageBox.Show("Registro seleccionado eliminado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { MessageBox.Show("Error al eliminar el registro seleccionado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}

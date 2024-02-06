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
    public partial class FrmProducto : Form
    {
        private Producto prodSeleccionado;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            DgvProducto.DataSource = null;
            DgvProducto.DataSource = ProductoData.ListarProductos();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DgvProducto.DataSource = null;
            DgvProducto.DataSource = ProductoData.ListarProductos();
        }

        private void BtnBuscProduc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_BuscarProduc.Text))
            {
                DgvProducto.DataSource = null;
                DgvProducto.DataSource = ProductoData.BuscarProducto(Convert.ToInt32(Txt_BuscarProduc.Text));
                Txt_BuscarProduc.Text = string.Empty;
            }
        }

        private void BtnAgregaProducto_Click(object sender, EventArgs e)
        {
            ModalProducto mdlProducto = new(0, prodSeleccionado);
            mdlProducto.ShowDialog();
        }

        private void BtnModifProducto_Click(object sender, EventArgs e)
        {
            ModalProducto mdlProducto = new(1, prodSeleccionado);
            mdlProducto.ShowDialog();
        }

        private void DgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvProducto.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.prodSeleccionado = dato as Producto;
            }
        }

        private void BtnElimProducto_Click(object sender, EventArgs e)
        {
            if (ProductoData.EliminarProducto(prodSeleccionado.Id))
            {
                MessageBox.Show("Registro seleccionado eliminado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { MessageBox.Show("Error al eliminar el registro seleccionado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
           FrmInicio inicio = new FrmInicio();
            inicio.FormProducto = null;
        }
    }
}

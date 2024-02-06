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
    public partial class FrmVenta : Form
    {
        private Venta ventaSeleccionada;
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            DgvVenta.DataSource = null;
            DgvVenta.DataSource = VentaData.ListarVenta();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DgvVenta.DataSource = null;
            DgvVenta.DataSource = VentaData.ListarVenta();
        }

        private void BtnBuscVenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_BuscarVenta.Text))
            {
                DgvVenta.DataSource = null;
                DgvVenta.DataSource = VentaData.BuscarVenta(Convert.ToInt32(Txt_BuscarVenta.Text));
                Txt_BuscarVenta.Text = string.Empty;
            }
        }

        private void BtnAgregaVenta_Click(object sender, EventArgs e)
        {
            ModalVenta mdlVenta = new(0, ventaSeleccionada);
            mdlVenta.ShowDialog();
        }

        private void BtnModifVenta_Click(object sender, EventArgs e)
        {
            ModalVenta mdlVenta = new(1, ventaSeleccionada);
            mdlVenta.ShowDialog();
        }

        private void DgvVenta_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvVenta.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.ventaSeleccionada = dato as Venta;
            }
        }

        private void BtnElimVenta_Click(object sender, EventArgs e)
        {
            if (VentaData.EliminarVenta(ventaSeleccionada.Id))
            {
                MessageBox.Show("Registro seleccionado eliminado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { MessageBox.Show("Error al eliminar el registro seleccionado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}

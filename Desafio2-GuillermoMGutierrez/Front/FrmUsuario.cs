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
    public partial class FrmUsuario : Form
    {
        private Usuario userSeleccionado;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            DgvUsuario.DataSource = null;
            DgvUsuario.DataSource = UsuarioData.ListarUsuarios();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DgvUsuario.DataSource = null;
            DgvUsuario.DataSource = UsuarioData.ListarUsuarios();
        }

        private void BtnBuscUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_BuscarUsuario.Text))
            {
                DgvUsuario.DataSource = null;
                DgvUsuario.DataSource = UsuarioData.BuscarUsuario(Convert.ToInt32(Txt_BuscarUsuario.Text));
                Txt_BuscarUsuario.Text = string.Empty;
            }
        }

        private void BtnAgregaUsuario_Click(object sender, EventArgs e)
        {
            ModalUsuario mdlUsuario = new(0, userSeleccionado);
            mdlUsuario.ShowDialog();
        }

        private void BtnModifUsuario_Click(object sender, EventArgs e)
        {
            ModalUsuario mdlUsuario = new(1, userSeleccionado);
            mdlUsuario.ShowDialog();
        }

        private void DgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvUsuario.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.userSeleccionado = dato as Usuario;
            }
        }

        private void BtnElimUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioData.EliminarUsuario(userSeleccionado.Id))
            {
                MessageBox.Show("Registro seleccionado eliminado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { MessageBox.Show("Error al eliminar el registro seleccionado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}

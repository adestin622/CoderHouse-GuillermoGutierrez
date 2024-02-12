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
    public partial class ModalVenta : Form
    {
        private int modalTipo { get; } //0 para modal "Agregar" y 1 para modal "Modificar"
        private Ventum ventaSeleccionada;

        public ModalVenta()
        {
            InitializeComponent();
        }
        public ModalVenta(int modalTipo) : this()
        {
            this.modalTipo = modalTipo;
        }
        public ModalVenta(int modalTipo, Ventum ventaSeleccionada) : this()
        {
            this.modalTipo = modalTipo;
            this.ventaSeleccionada = ventaSeleccionada;
        }

        private void ModalVenta_Load(object sender, EventArgs e)
        {
            if (modalTipo == 1)
            {
                TxtComentario.Text = ventaSeleccionada.Comentarios;
                TxtIdUsuario.Text = ventaSeleccionada.IdUsuario.ToString();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (modalTipo == 0)
            {
                try
                {
                    if (VentumBussiness.AgregarVenta(VentumBussiness.InstanciaVenta(TxtComentario.Text, Convert.ToInt32(TxtIdUsuario.Text))))
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
                    if (VentumBussiness.ModificarVenta(VentumBussiness.InstanciaVenta(TxtComentario.Text, Convert.ToInt32(TxtIdUsuario.Text)), ventaSeleccionada.Id))
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

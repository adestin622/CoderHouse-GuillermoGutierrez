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
    public partial class ModalVenta : Form
    {
        private int cargaModal;
        private Venta vent;
        
        public ModalVenta()
        {
            InitializeComponent();
        }
        public ModalVenta(int tipoModal, Venta vent) : this()
        {
            this.cargaModal = tipoModal;
            this.vent = vent;
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
                if (VentaData.AgregarVenta(Txt_Comentario.Text, Convert.ToInt32(Txt_IdUsuario.Text)))
                {
                    MessageBox.Show("Venta agregada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else { MessageBox.Show("Hubo un error al cargar la venta", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (cargaModal == 1)
            {
                //Esto toma lugar cuando se quiere modificar un registro de Producto
                if (VentaData.ModificarVenta(updateVenta(), vent.Id))
                {
                    MessageBox.Show("Venta modificada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Hubo un error al modificar la venta", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
                Txt_Comentario.Text = vent.Comentarios;
                Txt_IdUsuario.Text = vent.IdUsuario.ToString();
            }
        }
        private Venta updateVenta()
        {
            Venta updateVenta = new Venta();
            updateVenta.Comentarios = Txt_Comentario.Text;
            updateVenta.IdUsuario = Convert.ToInt32(Txt_IdUsuario.Text);
            
            return updateVenta;
        }

        private void ModalVenta_Load(object sender, EventArgs e)
        {
            CompletarCampos();
        }
    }
}

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
    public partial class ModalUsuario : Form
    {
        private int modalTipo { get; } //0 para modal "Agregar" y 1 para modal "Modificar", esto solo deshabilita el campo "IdUsuario" para evitar cambios en la FK de la BD
        private Usuario userSeleccionado;

        public ModalUsuario()
        {
            InitializeComponent();
        }
        public ModalUsuario(int modalTipo) : this()
        {
            this.modalTipo = modalTipo;
        }
        public ModalUsuario(int modalTipo, Usuario userSeleccionado) : this()
        {
            this.modalTipo = modalTipo;
            this.userSeleccionado = userSeleccionado;
        }

        private void ModalUsuario_Load(object sender, EventArgs e)
        {
            if (modalTipo == 1)
            {
                TxtNombre.Text = userSeleccionado.Nombre;
                TxtApellido.Text = userSeleccionado.Apellido;
                TxtNombreUsuario.Text = userSeleccionado.NombreUsuario;
                TxtPassword.Text = userSeleccionado.Contraseña;
                TxtEmail.Text = userSeleccionado.Mail;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (modalTipo == 0)
            {
                try
                {
                    if (UsuarioBussiness.AgregarUsuario(UsuarioBussiness.InstanciaUsuario(TxtNombre.Text, TxtApellido.Text, TxtNombreUsuario.Text, TxtPassword.Text, TxtEmail.Text)))
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
                    if (UsuarioBussiness.ModificarUsuario(UsuarioBussiness.InstanciaUsuario(TxtNombre.Text, TxtApellido.Text, TxtNombreUsuario.Text, TxtPassword.Text, TxtEmail.Text), userSeleccionado.Id))
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

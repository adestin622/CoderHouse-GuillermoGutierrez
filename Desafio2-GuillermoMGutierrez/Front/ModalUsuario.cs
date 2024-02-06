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
    public partial class ModalUsuario : Form
    {
        private int cargaModal;
        private Usuario usuario;
        
        public ModalUsuario()
        {
            InitializeComponent();
        }
        public ModalUsuario(int tipoModal, Usuario user) : this()
        {
            this.cargaModal = tipoModal;
            this.usuario = user;
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
                if (UsuarioData.AgregarUsuario(Txt_nombre.Text, Txt_apellido.Text, Txt_Usuario.Text, Txt_Password.Text, Txt_Email.Text))
                {
                    MessageBox.Show("Usuario agregado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else { MessageBox.Show("Hubo un error al cargar el usuario", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else if (cargaModal == 1)
            {
                //Esto toma lugar cuando se quiere modificar un registro de Producto

                if (UsuarioData.ModificarUsuario(updateUsuario(), usuario.Id))
                {
                    MessageBox.Show("Usuario modificado", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Hubo un error al modificar el usuario", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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
                Txt_nombre.Text = usuario.Nombre;
                Txt_apellido.Text = usuario.Apellido;
                Txt_Usuario.Text = usuario.NombreUsuario;
                Txt_Password.Text = usuario.Contrasena;
                Txt_Email.Text = usuario.Mail;
            }
        }
        private Usuario updateUsuario()
        {
            Usuario updateUsuario = new Usuario();
            updateUsuario.Nombre = Txt_nombre.Text;
            updateUsuario.Apellido = Txt_apellido.Text;
            updateUsuario.NombreUsuario = Txt_Usuario.Text;
            updateUsuario.Contrasena = Txt_Password.Text;
            updateUsuario.Mail = Txt_Email.Text;
            return updateUsuario;
        }

        private void ModalUsuario_Load(object sender, EventArgs e)
        {
            CompletarCampos();
        }
    }
}

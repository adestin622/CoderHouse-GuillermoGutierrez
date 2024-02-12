namespace SistemaGestionUI
{
    partial class ModalUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            TxtPassword = new TextBox();
            label3 = new Label();
            TxtNombreUsuario = new TextBox();
            label2 = new Label();
            TxtApellido = new TextBox();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            label1 = new Label();
            TxtNombre = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 210);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 23;
            label5.Text = "Email:";
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.Location = new Point(15, 228);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(136, 23);
            TxtEmail.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 161);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 22;
            label4.Text = "Contraseña:";
            // 
            // TxtPassword
            // 
            TxtPassword.BorderStyle = BorderStyle.FixedSingle;
            TxtPassword.Location = new Point(15, 179);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(136, 23);
            TxtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 21;
            label3.Text = "Nombre Usuario:";
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtNombreUsuario.Location = new Point(15, 131);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(136, 23);
            TxtNombreUsuario.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            TxtApellido.BorderStyle = BorderStyle.FixedSingle;
            TxtApellido.Location = new Point(15, 81);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(136, 23);
            TxtApellido.TabIndex = 13;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(187, 81);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 43);
            BtnCancelar.TabIndex = 20;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(187, 32);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(91, 43);
            BtnAceptar.TabIndex = 19;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Location = new Point(15, 32);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(136, 23);
            TxtNombre.TabIndex = 12;
            // 
            // ModalUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 265);
            Controls.Add(label5);
            Controls.Add(TxtEmail);
            Controls.Add(label4);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(TxtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(TxtApellido);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(label1);
            Controls.Add(TxtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coderhouse";
            Load += ModalUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtPassword;
        private Label label3;
        private TextBox TxtNombreUsuario;
        private Label label2;
        private TextBox TxtApellido;
        private Button BtnCancelar;
        private Button BtnAceptar;
        private Label label1;
        private TextBox TxtNombre;
    }
}
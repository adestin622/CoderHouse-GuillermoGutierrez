namespace Desafio2_GuillermoMGutierrez.Front
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
            Txt_nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txt_apellido = new TextBox();
            Txt_Usuario = new TextBox();
            label4 = new Label();
            Txt_Password = new TextBox();
            Btn_Aceptar = new Button();
            Btn_Cancelar = new Button();
            Txt_Email = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Txt_nombre
            // 
            Txt_nombre.BorderStyle = BorderStyle.FixedSingle;
            Txt_nombre.Location = new Point(12, 29);
            Txt_nombre.Name = "Txt_nombre";
            Txt_nombre.Size = new Size(100, 23);
            Txt_nombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre Usuario:";
            // 
            // Txt_apellido
            // 
            Txt_apellido.BorderStyle = BorderStyle.FixedSingle;
            Txt_apellido.Location = new Point(12, 78);
            Txt_apellido.Name = "Txt_apellido";
            Txt_apellido.Size = new Size(100, 23);
            Txt_apellido.TabIndex = 1;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            Txt_Usuario.Location = new Point(12, 127);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(100, 23);
            Txt_Usuario.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 9;
            label4.Text = "Contraseña:";
            // 
            // Txt_Password
            // 
            Txt_Password.BorderStyle = BorderStyle.FixedSingle;
            Txt_Password.Location = new Point(12, 176);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(100, 23);
            Txt_Password.TabIndex = 3;
            // 
            // Btn_Aceptar
            // 
            Btn_Aceptar.Location = new Point(132, 29);
            Btn_Aceptar.Name = "Btn_Aceptar";
            Btn_Aceptar.Size = new Size(75, 23);
            Btn_Aceptar.TabIndex = 5;
            Btn_Aceptar.Text = "Aceptar";
            Btn_Aceptar.UseVisualStyleBackColor = true;
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(132, 58);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(75, 23);
            Btn_Cancelar.TabIndex = 6;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // Txt_Email
            // 
            Txt_Email.BorderStyle = BorderStyle.FixedSingle;
            Txt_Email.Location = new Point(12, 225);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(100, 23);
            Txt_Email.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // ModalUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 258);
            Controls.Add(Txt_Email);
            Controls.Add(label5);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Aceptar);
            Controls.Add(Txt_Password);
            Controls.Add(label4);
            Controls.Add(Txt_Usuario);
            Controls.Add(Txt_apellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_nombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += ModalUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_apellido;
        private TextBox Txt_Usuario;
        private Label label4;
        private TextBox Txt_Password;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar;
        private TextBox Txt_Email;
        private Label label5;
    }
}
namespace SistemaGestionUI
{
    partial class ModalVenta
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
            label2 = new Label();
            TxtIdUsuario = new TextBox();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            label1 = new Label();
            TxtComentario = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 18;
            label2.Text = "Id Usuario:";
            // 
            // TxtIdUsuario
            // 
            TxtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtIdUsuario.Location = new Point(12, 77);
            TxtIdUsuario.Name = "TxtIdUsuario";
            TxtIdUsuario.Size = new Size(136, 23);
            TxtIdUsuario.TabIndex = 13;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(184, 77);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 43);
            BtnCancelar.TabIndex = 20;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(184, 28);
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
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 14;
            label1.Text = "Comentario:";
            // 
            // TxtComentario
            // 
            TxtComentario.BorderStyle = BorderStyle.FixedSingle;
            TxtComentario.Location = new Point(12, 28);
            TxtComentario.Name = "TxtComentario";
            TxtComentario.Size = new Size(136, 23);
            TxtComentario.TabIndex = 12;
            // 
            // ModalVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 265);
            Controls.Add(label2);
            Controls.Add(TxtIdUsuario);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(label1);
            Controls.Add(TxtComentario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += ModalVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox TxtIdUsuario;
        private Button BtnCancelar;
        private Button BtnAceptar;
        private Label label1;
        private TextBox TxtComentario;
    }
}
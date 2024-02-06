namespace Desafio2_GuillermoMGutierrez.Front
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
            Txt_Comentario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Txt_IdUsuario = new TextBox();
            Btn_Aceptar = new Button();
            Btn_Cancelar = new Button();
            SuspendLayout();
            // 
            // Txt_Comentario
            // 
            Txt_Comentario.BorderStyle = BorderStyle.FixedSingle;
            Txt_Comentario.Location = new Point(12, 29);
            Txt_Comentario.Name = "Txt_Comentario";
            Txt_Comentario.Size = new Size(100, 23);
            Txt_Comentario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Comentario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "IdUsuario:";
            // 
            // Txt_IdUsuario
            // 
            Txt_IdUsuario.BorderStyle = BorderStyle.FixedSingle;
            Txt_IdUsuario.Location = new Point(12, 78);
            Txt_IdUsuario.Name = "Txt_IdUsuario";
            Txt_IdUsuario.Size = new Size(100, 23);
            Txt_IdUsuario.TabIndex = 1;
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
            // ModalVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 130);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Aceptar);
            Controls.Add(Txt_IdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_Comentario);
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

        private TextBox Txt_Comentario;
        private Label label1;
        private Label label2;
        private TextBox Txt_IdUsuario;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar;
    }
}
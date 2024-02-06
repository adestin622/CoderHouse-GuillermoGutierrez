namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class ModalProducto
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
            Txt_Descripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txt_Costo = new TextBox();
            Txt_PrecVenta = new TextBox();
            label4 = new Label();
            Txt_Stock = new TextBox();
            Btn_Aceptar = new Button();
            Btn_Cancelar = new Button();
            Txt_IdUsuario = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Txt_Descripcion
            // 
            Txt_Descripcion.BorderStyle = BorderStyle.FixedSingle;
            Txt_Descripcion.Location = new Point(12, 29);
            Txt_Descripcion.Name = "Txt_Descripcion";
            Txt_Descripcion.Size = new Size(100, 23);
            Txt_Descripcion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Descripciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Costos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 6;
            label3.Text = "Precio Venta:";
            // 
            // Txt_Costo
            // 
            Txt_Costo.BorderStyle = BorderStyle.FixedSingle;
            Txt_Costo.Location = new Point(12, 78);
            Txt_Costo.Name = "Txt_Costo";
            Txt_Costo.Size = new Size(100, 23);
            Txt_Costo.TabIndex = 1;
            // 
            // Txt_PrecVenta
            // 
            Txt_PrecVenta.BorderStyle = BorderStyle.FixedSingle;
            Txt_PrecVenta.Location = new Point(12, 127);
            Txt_PrecVenta.Name = "Txt_PrecVenta";
            Txt_PrecVenta.Size = new Size(100, 23);
            Txt_PrecVenta.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Stock:";
            // 
            // Txt_Stock
            // 
            Txt_Stock.BorderStyle = BorderStyle.FixedSingle;
            Txt_Stock.Location = new Point(12, 176);
            Txt_Stock.Name = "Txt_Stock";
            Txt_Stock.Size = new Size(100, 23);
            Txt_Stock.TabIndex = 3;
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
            // Txt_IdUsuario
            // 
            Txt_IdUsuario.BorderStyle = BorderStyle.FixedSingle;
            Txt_IdUsuario.Location = new Point(12, 225);
            Txt_IdUsuario.Name = "Txt_IdUsuario";
            Txt_IdUsuario.Size = new Size(100, 23);
            Txt_IdUsuario.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 13;
            label5.Text = "Id Usuario:";
            // 
            // ModalProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 258);
            Controls.Add(Txt_IdUsuario);
            Controls.Add(label5);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Aceptar);
            Controls.Add(Txt_Stock);
            Controls.Add(label4);
            Controls.Add(Txt_PrecVenta);
            Controls.Add(Txt_Costo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_Descripcion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += ModalProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Descripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_Costo;
        private TextBox Txt_PrecVenta;
        private Label label4;
        private TextBox Txt_Stock;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar;
        private TextBox Txt_IdUsuario;
        private Label label5;
    }
}
namespace SistemaGestionUI
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
            TxtDescripcion = new TextBox();
            label1 = new Label();
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            label2 = new Label();
            TxtCosto = new TextBox();
            label3 = new Label();
            TxtPrecioVenta = new TextBox();
            label4 = new Label();
            TxtStock = new TextBox();
            label5 = new Label();
            TxtIdUsuario = new TextBox();
            SuspendLayout();
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TxtDescripcion.Location = new Point(12, 27);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(136, 23);
            TxtDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion:";
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(184, 27);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(91, 43);
            BtnAceptar.TabIndex = 5;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(184, 76);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 43);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Costo:";
            // 
            // TxtCosto
            // 
            TxtCosto.BorderStyle = BorderStyle.FixedSingle;
            TxtCosto.Location = new Point(12, 76);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(136, 23);
            TxtCosto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Precio Venta:";
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            TxtPrecioVenta.Location = new Point(12, 126);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Size = new Size(136, 23);
            TxtPrecioVenta.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Stock:";
            // 
            // TxtStock
            // 
            TxtStock.BorderStyle = BorderStyle.FixedSingle;
            TxtStock.Location = new Point(12, 174);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(136, 23);
            TxtStock.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 11;
            label5.Text = "Id Usuario:";
            // 
            // TxtIdUsuario
            // 
            TxtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtIdUsuario.Location = new Point(12, 223);
            TxtIdUsuario.Name = "TxtIdUsuario";
            TxtIdUsuario.Size = new Size(136, 23);
            TxtIdUsuario.TabIndex = 4;
            // 
            // ModalProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 265);
            Controls.Add(label5);
            Controls.Add(TxtIdUsuario);
            Controls.Add(label4);
            Controls.Add(TxtStock);
            Controls.Add(label3);
            Controls.Add(TxtPrecioVenta);
            Controls.Add(label2);
            Controls.Add(TxtCosto);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(label1);
            Controls.Add(TxtDescripcion);
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

        private TextBox TxtDescripcion;
        private Label label1;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private Label label2;
        private TextBox TxtCosto;
        private Label label3;
        private TextBox TxtPrecioVenta;
        private Label label4;
        private TextBox TxtStock;
        private Label label5;
        private TextBox TxtIdUsuario;
    }
}
namespace SistemaGestionUI
{
    partial class ModalProductoVendido
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
            label3 = new Label();
            TxtIdVenta = new TextBox();
            label2 = new Label();
            TxtIdProducto = new TextBox();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            label1 = new Label();
            TxtStock = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 21;
            label3.Text = "Id Venta:";
            // 
            // TxtIdVenta
            // 
            TxtIdVenta.BorderStyle = BorderStyle.FixedSingle;
            TxtIdVenta.Location = new Point(12, 123);
            TxtIdVenta.Name = "TxtIdVenta";
            TxtIdVenta.Size = new Size(136, 23);
            TxtIdVenta.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 18;
            label2.Text = "Id Producto:";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            TxtIdProducto.Location = new Point(12, 73);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(136, 23);
            TxtIdProducto.TabIndex = 13;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(184, 73);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(91, 43);
            BtnCancelar.TabIndex = 20;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(184, 24);
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
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Stock:";
            // 
            // TxtStock
            // 
            TxtStock.BorderStyle = BorderStyle.FixedSingle;
            TxtStock.Location = new Point(12, 24);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(136, 23);
            TxtStock.TabIndex = 12;
            // 
            // ModalProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 265);
            Controls.Add(label3);
            Controls.Add(TxtIdVenta);
            Controls.Add(label2);
            Controls.Add(TxtIdProducto);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(label1);
            Controls.Add(TxtStock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalProductoVendido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += ModalProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox TxtIdVenta;
        private Label label2;
        private TextBox TxtIdProducto;
        private Button BtnCancelar;
        private Button BtnAceptar;
        private Label label1;
        private TextBox TxtStock;
    }
}
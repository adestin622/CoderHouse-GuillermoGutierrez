namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class ModalProdVendido
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
            Txt_Stock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Txt_IdProducto = new TextBox();
            Btn_Aceptar = new Button();
            Btn_Cancelar = new Button();
            Txt_IdVenta = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Txt_Stock
            // 
            Txt_Stock.BorderStyle = BorderStyle.FixedSingle;
            Txt_Stock.Location = new Point(12, 29);
            Txt_Stock.Name = "Txt_Stock";
            Txt_Stock.Size = new Size(100, 23);
            Txt_Stock.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "IdProducto:";
            // 
            // Txt_IdProducto
            // 
            Txt_IdProducto.BorderStyle = BorderStyle.FixedSingle;
            Txt_IdProducto.Location = new Point(12, 78);
            Txt_IdProducto.Name = "Txt_IdProducto";
            Txt_IdProducto.Size = new Size(100, 23);
            Txt_IdProducto.TabIndex = 1;
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
            // Txt_IdVenta
            // 
            Txt_IdVenta.BorderStyle = BorderStyle.FixedSingle;
            Txt_IdVenta.Location = new Point(12, 125);
            Txt_IdVenta.Name = "Txt_IdVenta";
            Txt_IdVenta.Size = new Size(100, 23);
            Txt_IdVenta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "IdVenta:";
            // 
            // ModalProdVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 160);
            Controls.Add(Txt_IdVenta);
            Controls.Add(label3);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Aceptar);
            Controls.Add(Txt_IdProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_Stock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ModalProdVendido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += ModalProdVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Stock;
        private Label label1;
        private Label label2;
        private TextBox Txt_IdProducto;
        private Button Btn_Aceptar;
        private Button Btn_Cancelar;
        private TextBox Txt_IdVenta;
        private Label label3;
    }
}
namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class FrmVenta

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
            DgvVenta = new DataGridView();
            BtnActualizar = new Button();
            Txt_BuscarVenta = new TextBox();
            label1 = new Label();
            BtnBuscVenta = new Button();
            BtnAgregaVenta = new Button();
            BtnModifVenta = new Button();
            BtnElimVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvVenta).BeginInit();
            SuspendLayout();
            // 
            // DgvVenta
            // 
            DgvVenta.AllowUserToAddRows = false;
            DgvVenta.AllowUserToDeleteRows = false;
            DgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVenta.Location = new Point(167, 12);
            DgvVenta.Name = "DgvVenta";
            DgvVenta.ReadOnly = true;
            DgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvVenta.Size = new Size(621, 379);
            DgvVenta.TabIndex = 0;
            DgvVenta.SelectionChanged += DgvVenta_SelectionChanged;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(23, 12);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(106, 43);
            BtnActualizar.TabIndex = 1;
            BtnActualizar.Text = "Actualizar Lista";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // Txt_BuscarVenta
            // 
            Txt_BuscarVenta.Location = new Point(12, 132);
            Txt_BuscarVenta.Name = "Txt_BuscarVenta";
            Txt_BuscarVenta.PlaceholderText = "Id de la venta";
            Txt_BuscarVenta.Size = new Size(149, 23);
            Txt_BuscarVenta.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar Venta:";
            // 
            // BtnBuscVenta
            // 
            BtnBuscVenta.Location = new Point(12, 161);
            BtnBuscVenta.Name = "BtnBuscVenta";
            BtnBuscVenta.Size = new Size(50, 25);
            BtnBuscVenta.TabIndex = 4;
            BtnBuscVenta.Text = "Buscar";
            BtnBuscVenta.UseVisualStyleBackColor = true;
            BtnBuscVenta.Click += BtnBuscVenta_Click;
            // 
            // BtnAgregaVenta
            // 
            BtnAgregaVenta.Location = new Point(23, 250);
            BtnAgregaVenta.Name = "BtnAgregaVenta";
            BtnAgregaVenta.Size = new Size(106, 43);
            BtnAgregaVenta.TabIndex = 5;
            BtnAgregaVenta.Text = "Agregar";
            BtnAgregaVenta.UseVisualStyleBackColor = true;
            BtnAgregaVenta.Click += BtnAgregaVenta_Click;
            // 
            // BtnModifVenta
            // 
            BtnModifVenta.Location = new Point(23, 299);
            BtnModifVenta.Name = "BtnModifVenta";
            BtnModifVenta.Size = new Size(106, 43);
            BtnModifVenta.TabIndex = 6;
            BtnModifVenta.Text = "Modificar";
            BtnModifVenta.UseVisualStyleBackColor = true;
            BtnModifVenta.Click += BtnModifVenta_Click;
            // 
            // BtnElimVenta
            // 
            BtnElimVenta.Location = new Point(23, 348);
            BtnElimVenta.Name = "BtnElimVenta";
            BtnElimVenta.Size = new Size(106, 43);
            BtnElimVenta.TabIndex = 7;
            BtnElimVenta.Text = "Eliminar";
            BtnElimVenta.UseVisualStyleBackColor = true;
            BtnElimVenta.Click += BtnElimVenta_Click;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(BtnElimVenta);
            Controls.Add(BtnModifVenta);
            Controls.Add(BtnAgregaVenta);
            Controls.Add(BtnBuscVenta);
            Controls.Add(label1);
            Controls.Add(Txt_BuscarVenta);
            Controls.Add(BtnActualizar);
            Controls.Add(DgvVenta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvVenta;
        private Button BtnActualizar;
        private TextBox Txt_BuscarVenta;
        private Label label1;
        private Button BtnBuscVenta;
        private Button BtnAgregaVenta;
        private Button BtnModifVenta;
        private Button BtnElimVenta;
    }
}
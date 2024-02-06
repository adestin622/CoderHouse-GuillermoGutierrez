namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class FrmProductoVendido

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
            DgvProdVendido = new DataGridView();
            BtnActualizar = new Button();
            Txt_BuscarProdVendido = new TextBox();
            label1 = new Label();
            BtnBuscProdVendido = new Button();
            BtnAgregaProdVendido = new Button();
            BtnModifProdVendido = new Button();
            BtnElimProdVendido = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProdVendido).BeginInit();
            SuspendLayout();
            // 
            // DgvProdVendido
            // 
            DgvProdVendido.AllowUserToAddRows = false;
            DgvProdVendido.AllowUserToDeleteRows = false;
            DgvProdVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProdVendido.Location = new Point(167, 12);
            DgvProdVendido.Name = "DgvProdVendido";
            DgvProdVendido.ReadOnly = true;
            DgvProdVendido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdVendido.Size = new Size(621, 379);
            DgvProdVendido.TabIndex = 0;
            DgvProdVendido.SelectionChanged += DgvProdVendido_SelectionChanged;
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
            // Txt_BuscarProdVendido
            // 
            Txt_BuscarProdVendido.Location = new Point(12, 132);
            Txt_BuscarProdVendido.Name = "Txt_BuscarProdVendido";
            Txt_BuscarProdVendido.PlaceholderText = "Id del producto vendido";
            Txt_BuscarProdVendido.Size = new Size(149, 23);
            Txt_BuscarProdVendido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar Producto Vendido:";
            // 
            // BtnBuscProdVendido
            // 
            BtnBuscProdVendido.Location = new Point(12, 161);
            BtnBuscProdVendido.Name = "BtnBuscProdVendido";
            BtnBuscProdVendido.Size = new Size(50, 25);
            BtnBuscProdVendido.TabIndex = 4;
            BtnBuscProdVendido.Text = "Buscar";
            BtnBuscProdVendido.UseVisualStyleBackColor = true;
            BtnBuscProdVendido.Click += BtnBuscProdVendido_Click;
            // 
            // BtnAgregaProdVendido
            // 
            BtnAgregaProdVendido.Location = new Point(23, 250);
            BtnAgregaProdVendido.Name = "BtnAgregaProdVendido";
            BtnAgregaProdVendido.Size = new Size(106, 43);
            BtnAgregaProdVendido.TabIndex = 5;
            BtnAgregaProdVendido.Text = "Agregar";
            BtnAgregaProdVendido.UseVisualStyleBackColor = true;
            BtnAgregaProdVendido.Click += BtnAgregaProdVendido_Click;
            // 
            // BtnModifProdVendido
            // 
            BtnModifProdVendido.Location = new Point(23, 299);
            BtnModifProdVendido.Name = "BtnModifProdVendido";
            BtnModifProdVendido.Size = new Size(106, 43);
            BtnModifProdVendido.TabIndex = 6;
            BtnModifProdVendido.Text = "Modificar";
            BtnModifProdVendido.UseVisualStyleBackColor = true;
            BtnModifProdVendido.Click += BtnModifProdVendido_Click;
            // 
            // BtnElimProdVendido
            // 
            BtnElimProdVendido.Location = new Point(23, 348);
            BtnElimProdVendido.Name = "BtnElimProdVendido";
            BtnElimProdVendido.Size = new Size(106, 43);
            BtnElimProdVendido.TabIndex = 7;
            BtnElimProdVendido.Text = "Eliminar";
            BtnElimProdVendido.UseVisualStyleBackColor = true;
            BtnElimProdVendido.Click += BtnElimProdVendido_Click;
            // 
            // FrmProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(BtnElimProdVendido);
            Controls.Add(BtnModifProdVendido);
            Controls.Add(BtnAgregaProdVendido);
            Controls.Add(BtnBuscProdVendido);
            Controls.Add(label1);
            Controls.Add(Txt_BuscarProdVendido);
            Controls.Add(BtnActualizar);
            Controls.Add(DgvProdVendido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmProductoVendido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += FrmProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProdVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProdVendido;
        private Button BtnActualizar;
        private TextBox Txt_BuscarProdVendido;
        private Label label1;
        private Button BtnBuscProdVendido;
        private Button BtnAgregaProdVendido;
        private Button BtnModifProdVendido;
        private Button BtnElimProdVendido;
    }
}
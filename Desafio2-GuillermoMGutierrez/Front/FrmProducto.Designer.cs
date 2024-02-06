namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class FrmProducto
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
            DgvProducto = new DataGridView();
            BtnActualizar = new Button();
            Txt_BuscarProduc = new TextBox();
            label1 = new Label();
            BtnBuscProduc = new Button();
            BtnAgregaProducto = new Button();
            BtnModifProducto = new Button();
            BtnElimProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProducto).BeginInit();
            SuspendLayout();
            // 
            // DgvProducto
            // 
            DgvProducto.AllowUserToAddRows = false;
            DgvProducto.AllowUserToDeleteRows = false;
            DgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProducto.Location = new Point(167, 12);
            DgvProducto.Name = "DgvProducto";
            DgvProducto.ReadOnly = true;
            DgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProducto.Size = new Size(621, 379);
            DgvProducto.TabIndex = 0;
            DgvProducto.SelectionChanged += DgvProducto_SelectionChanged;
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
            // Txt_BuscarProduc
            // 
            Txt_BuscarProduc.Location = new Point(12, 132);
            Txt_BuscarProduc.Name = "Txt_BuscarProduc";
            Txt_BuscarProduc.PlaceholderText = "Id del producto";
            Txt_BuscarProduc.Size = new Size(149, 23);
            Txt_BuscarProduc.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar producto:";
            // 
            // BtnBuscProduc
            // 
            BtnBuscProduc.Location = new Point(12, 161);
            BtnBuscProduc.Name = "BtnBuscProduc";
            BtnBuscProduc.Size = new Size(50, 25);
            BtnBuscProduc.TabIndex = 4;
            BtnBuscProduc.Text = "Buscar";
            BtnBuscProduc.UseVisualStyleBackColor = true;
            BtnBuscProduc.Click += BtnBuscProduc_Click;
            // 
            // BtnAgregaProducto
            // 
            BtnAgregaProducto.Location = new Point(23, 250);
            BtnAgregaProducto.Name = "BtnAgregaProducto";
            BtnAgregaProducto.Size = new Size(106, 43);
            BtnAgregaProducto.TabIndex = 5;
            BtnAgregaProducto.Text = "Agregar";
            BtnAgregaProducto.UseVisualStyleBackColor = true;
            BtnAgregaProducto.Click += BtnAgregaProducto_Click;
            // 
            // BtnModifProducto
            // 
            BtnModifProducto.Location = new Point(23, 299);
            BtnModifProducto.Name = "BtnModifProducto";
            BtnModifProducto.Size = new Size(106, 43);
            BtnModifProducto.TabIndex = 6;
            BtnModifProducto.Text = "Modificar";
            BtnModifProducto.UseVisualStyleBackColor = true;
            BtnModifProducto.Click += BtnModifProducto_Click;
            // 
            // BtnElimProducto
            // 
            BtnElimProducto.Location = new Point(23, 348);
            BtnElimProducto.Name = "BtnElimProducto";
            BtnElimProducto.Size = new Size(106, 43);
            BtnElimProducto.TabIndex = 7;
            BtnElimProducto.Text = "Eliminar";
            BtnElimProducto.UseVisualStyleBackColor = true;
            BtnElimProducto.Click += BtnElimProducto_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(BtnElimProducto);
            Controls.Add(BtnModifProducto);
            Controls.Add(BtnAgregaProducto);
            Controls.Add(BtnBuscProduc);
            Controls.Add(label1);
            Controls.Add(Txt_BuscarProduc);
            Controls.Add(BtnActualizar);
            Controls.Add(DgvProducto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            FormClosed += FrmProducto_FormClosed;
            Load += FrmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvProducto;
        private Button BtnActualizar;
        private TextBox Txt_BuscarProduc;
        private Label label1;
        private Button BtnBuscProduc;
        private Button BtnAgregaProducto;
        private Button BtnModifProducto;
        private Button BtnElimProducto;
    }
}
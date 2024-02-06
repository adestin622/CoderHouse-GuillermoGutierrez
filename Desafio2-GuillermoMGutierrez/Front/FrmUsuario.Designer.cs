namespace Desafio2_GuillermoMGutierrez.Front
{
    partial class FrmUsuario

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
            DgvUsuario = new DataGridView();
            BtnActualizar = new Button();
            Txt_BuscarUsuario = new TextBox();
            label1 = new Label();
            BtnBuscUsuario = new Button();
            BtnAgregaUsuario = new Button();
            BtnModifUsuario = new Button();
            BtnElimUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // DgvUsuario
            // 
            DgvUsuario.AllowUserToAddRows = false;
            DgvUsuario.AllowUserToDeleteRows = false;
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuario.Location = new Point(167, 12);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.ReadOnly = true;
            DgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuario.Size = new Size(621, 379);
            DgvUsuario.TabIndex = 0;
            DgvUsuario.SelectionChanged += DgvUsuario_SelectionChanged;
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
            // Txt_BuscarUsuario
            // 
            Txt_BuscarUsuario.Location = new Point(12, 132);
            Txt_BuscarUsuario.Name = "Txt_BuscarUsuario";
            Txt_BuscarUsuario.PlaceholderText = "Id del Usuario";
            Txt_BuscarUsuario.Size = new Size(149, 23);
            Txt_BuscarUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar usuario:";
            // 
            // BtnBuscUsuario
            // 
            BtnBuscUsuario.Location = new Point(12, 161);
            BtnBuscUsuario.Name = "BtnBuscUsuario";
            BtnBuscUsuario.Size = new Size(50, 25);
            BtnBuscUsuario.TabIndex = 4;
            BtnBuscUsuario.Text = "Buscar";
            BtnBuscUsuario.UseVisualStyleBackColor = true;
            BtnBuscUsuario.Click += BtnBuscUsuario_Click;
            // 
            // BtnAgregaUsuario
            // 
            BtnAgregaUsuario.Location = new Point(23, 250);
            BtnAgregaUsuario.Name = "BtnAgregaUsuario";
            BtnAgregaUsuario.Size = new Size(106, 43);
            BtnAgregaUsuario.TabIndex = 5;
            BtnAgregaUsuario.Text = "Agregar";
            BtnAgregaUsuario.UseVisualStyleBackColor = true;
            BtnAgregaUsuario.Click += BtnAgregaUsuario_Click;
            // 
            // BtnModifUsuario
            // 
            BtnModifUsuario.Location = new Point(23, 299);
            BtnModifUsuario.Name = "BtnModifUsuario";
            BtnModifUsuario.Size = new Size(106, 43);
            BtnModifUsuario.TabIndex = 6;
            BtnModifUsuario.Text = "Modificar";
            BtnModifUsuario.UseVisualStyleBackColor = true;
            BtnModifUsuario.Click += BtnModifUsuario_Click;
            // 
            // BtnElimUsuario
            // 
            BtnElimUsuario.Location = new Point(23, 348);
            BtnElimUsuario.Name = "BtnElimUsuario";
            BtnElimUsuario.Size = new Size(106, 43);
            BtnElimUsuario.TabIndex = 7;
            BtnElimUsuario.Text = "Eliminar";
            BtnElimUsuario.UseVisualStyleBackColor = true;
            BtnElimUsuario.Click += BtnElimUsuario_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(BtnElimUsuario);
            Controls.Add(BtnModifUsuario);
            Controls.Add(BtnAgregaUsuario);
            Controls.Add(BtnBuscUsuario);
            Controls.Add(label1);
            Controls.Add(Txt_BuscarUsuario);
            Controls.Add(BtnActualizar);
            Controls.Add(DgvUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvUsuario;
        private Button BtnActualizar;
        private TextBox Txt_BuscarUsuario;
        private Label label1;
        private Button BtnBuscUsuario;
        private Button BtnAgregaUsuario;
        private Button BtnModifUsuario;
        private Button BtnElimUsuario;
    }
}
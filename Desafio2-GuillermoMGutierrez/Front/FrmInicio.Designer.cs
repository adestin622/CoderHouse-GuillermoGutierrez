namespace Desafio2_GuillermoMGutierrez
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            BtnUsers = new Button();
            BtnVentas = new Button();
            BtnProdVendidos = new Button();
            BtnProductos = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.logo;
            flowLayoutPanel1.Location = new Point(162, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(278, 278);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnUsers);
            panel1.Controls.Add(BtnVentas);
            panel1.Controls.Add(BtnProdVendidos);
            panel1.Controls.Add(BtnProductos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 69);
            panel1.TabIndex = 2;
            // 
            // BtnUsers
            // 
            BtnUsers.BackColor = Color.FromArgb(33, 33, 33);
            BtnUsers.Dock = DockStyle.Left;
            BtnUsers.FlatStyle = FlatStyle.Flat;
            BtnUsers.Font = new Font("Leelawadee UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsers.ForeColor = Color.White;
            BtnUsers.Location = new Point(450, 0);
            BtnUsers.Margin = new Padding(0);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Size = new Size(150, 69);
            BtnUsers.TabIndex = 3;
            BtnUsers.Text = "Usuarios";
            BtnUsers.UseVisualStyleBackColor = false;
            BtnUsers.Click += BtnUsers_Click;
            // 
            // BtnVentas
            // 
            BtnVentas.BackColor = Color.FromArgb(33, 33, 33);
            BtnVentas.Dock = DockStyle.Left;
            BtnVentas.FlatStyle = FlatStyle.Flat;
            BtnVentas.Font = new Font("Leelawadee UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVentas.ForeColor = Color.White;
            BtnVentas.Location = new Point(300, 0);
            BtnVentas.Margin = new Padding(0);
            BtnVentas.Name = "BtnVentas";
            BtnVentas.Size = new Size(150, 69);
            BtnVentas.TabIndex = 2;
            BtnVentas.Text = "Ventas";
            BtnVentas.UseVisualStyleBackColor = false;
            BtnVentas.Click += BtnVentas_Click;
            // 
            // BtnProdVendidos
            // 
            BtnProdVendidos.BackColor = Color.FromArgb(33, 33, 33);
            BtnProdVendidos.Dock = DockStyle.Left;
            BtnProdVendidos.FlatStyle = FlatStyle.Flat;
            BtnProdVendidos.Font = new Font("Leelawadee UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProdVendidos.ForeColor = Color.White;
            BtnProdVendidos.Location = new Point(150, 0);
            BtnProdVendidos.Margin = new Padding(0);
            BtnProdVendidos.Name = "BtnProdVendidos";
            BtnProdVendidos.Size = new Size(150, 69);
            BtnProdVendidos.TabIndex = 1;
            BtnProdVendidos.Text = "Productos Vendidos";
            BtnProdVendidos.UseVisualStyleBackColor = false;
            BtnProdVendidos.Click += BtnProdVendidos_Click;
            // 
            // BtnProductos
            // 
            BtnProductos.BackColor = Color.FromArgb(33, 33, 33);
            BtnProductos.Dock = DockStyle.Left;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Leelawadee UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProductos.ForeColor = Color.White;
            BtnProductos.Location = new Point(0, 0);
            BtnProductos.Margin = new Padding(0);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(150, 69);
            BtnProductos.TabIndex = 0;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = false;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(446, 387);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 3;
            label1.Text = "by Guillermo M. Gutierrez";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 411);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button BtnProductos;
        private Label label1;
        private Button BtnProdVendidos;
        private Button BtnUsers;
        private Button BtnVentas;
    }
}

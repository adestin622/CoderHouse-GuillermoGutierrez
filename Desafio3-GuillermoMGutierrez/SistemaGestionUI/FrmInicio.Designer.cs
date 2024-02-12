namespace SistemaGestionUI
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
            DgvProductos = new DataGridView();
            Btn_ListarProductos = new Button();
            TxtIdProduc = new TextBox();
            Btn_buscarProduc = new Button();
            Btn_AgregarProduc = new Button();
            Btn_ModifProduc = new Button();
            Btn_DeleteProduc = new Button();
            label1 = new Label();
            PanelProducto = new Panel();
            PanelProducVendido = new Panel();
            DgvProductoVendido = new DataGridView();
            BtnListarProducVend = new Button();
            TxtIdProdVend = new TextBox();
            BtnBuscarProducVend = new Button();
            BtnAgregarProdVend = new Button();
            BtnModProdVend = new Button();
            BtnDeleteProdVend = new Button();
            label2 = new Label();
            PanelUsuario = new Panel();
            DgvVentas = new DataGridView();
            BtnListarVentas = new Button();
            TxtIdVenta = new TextBox();
            BtnBuscarVenta = new Button();
            BtnAgregarVenta = new Button();
            BtnModificarVenta = new Button();
            BtnEliminarVenta = new Button();
            label3 = new Label();
            PanelVentas = new Panel();
            DgvUsuarios = new DataGridView();
            BtnListarUsuarios = new Button();
            TxtIdUsuario = new TextBox();
            BtnBuscarUsuario = new Button();
            BtnAgregarUsuario = new Button();
            BtnModifUsuario = new Button();
            BtnEliminarUsuario = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvProductos).BeginInit();
            PanelProducto.SuspendLayout();
            PanelProducVendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductoVendido).BeginInit();
            PanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).BeginInit();
            PanelVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // DgvProductos
            // 
            DgvProductos.AllowUserToAddRows = false;
            DgvProductos.AllowUserToDeleteRows = false;
            DgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductos.Location = new Point(118, 32);
            DgvProductos.MultiSelect = false;
            DgvProductos.Name = "DgvProductos";
            DgvProductos.ReadOnly = true;
            DgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProductos.Size = new Size(531, 272);
            DgvProductos.TabIndex = 0;
            DgvProductos.SelectionChanged += DgvProductos_SelectionChanged;
            // 
            // Btn_ListarProductos
            // 
            Btn_ListarProductos.FlatStyle = FlatStyle.Popup;
            Btn_ListarProductos.Location = new Point(118, 5);
            Btn_ListarProductos.Name = "Btn_ListarProductos";
            Btn_ListarProductos.Size = new Size(106, 23);
            Btn_ListarProductos.TabIndex = 1;
            Btn_ListarProductos.Text = "Listar Productos";
            Btn_ListarProductos.UseVisualStyleBackColor = true;
            Btn_ListarProductos.Click += Btn_ListarProductos_Click;
            // 
            // TxtIdProduc
            // 
            TxtIdProduc.BorderStyle = BorderStyle.FixedSingle;
            TxtIdProduc.Location = new Point(437, 5);
            TxtIdProduc.Name = "TxtIdProduc";
            TxtIdProduc.PlaceholderText = "Id producto ";
            TxtIdProduc.Size = new Size(100, 23);
            TxtIdProduc.TabIndex = 2;
            TxtIdProduc.TextAlign = HorizontalAlignment.Right;
            // 
            // Btn_buscarProduc
            // 
            Btn_buscarProduc.FlatStyle = FlatStyle.Popup;
            Btn_buscarProduc.Location = new Point(543, 5);
            Btn_buscarProduc.Name = "Btn_buscarProduc";
            Btn_buscarProduc.Size = new Size(106, 23);
            Btn_buscarProduc.TabIndex = 3;
            Btn_buscarProduc.Text = "Buscar Producto";
            Btn_buscarProduc.UseVisualStyleBackColor = true;
            Btn_buscarProduc.Click += Btn_buscarProduc_Click;
            // 
            // Btn_AgregarProduc
            // 
            Btn_AgregarProduc.FlatStyle = FlatStyle.Popup;
            Btn_AgregarProduc.Location = new Point(6, 33);
            Btn_AgregarProduc.Name = "Btn_AgregarProduc";
            Btn_AgregarProduc.Size = new Size(106, 42);
            Btn_AgregarProduc.TabIndex = 4;
            Btn_AgregarProduc.Text = "Agregar Producto";
            Btn_AgregarProduc.UseVisualStyleBackColor = true;
            Btn_AgregarProduc.Click += Btn_AgregarProduc_Click;
            // 
            // Btn_ModifProduc
            // 
            Btn_ModifProduc.FlatStyle = FlatStyle.Popup;
            Btn_ModifProduc.Location = new Point(6, 81);
            Btn_ModifProduc.Name = "Btn_ModifProduc";
            Btn_ModifProduc.Size = new Size(106, 42);
            Btn_ModifProduc.TabIndex = 5;
            Btn_ModifProduc.Text = "Modificar Producto";
            Btn_ModifProduc.UseVisualStyleBackColor = true;
            Btn_ModifProduc.Click += Btn_ModifProduc_Click;
            // 
            // Btn_DeleteProduc
            // 
            Btn_DeleteProduc.FlatStyle = FlatStyle.Popup;
            Btn_DeleteProduc.Location = new Point(6, 129);
            Btn_DeleteProduc.Name = "Btn_DeleteProduc";
            Btn_DeleteProduc.Size = new Size(106, 42);
            Btn_DeleteProduc.TabIndex = 6;
            Btn_DeleteProduc.Text = "Eliminar Producto";
            Btn_DeleteProduc.UseVisualStyleBackColor = true;
            Btn_DeleteProduc.Click += Btn_DeleteProduc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 3);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 7;
            label1.Text = "CRUD Producto";
            // 
            // PanelProducto
            // 
            PanelProducto.BorderStyle = BorderStyle.FixedSingle;
            PanelProducto.Controls.Add(DgvProductos);
            PanelProducto.Controls.Add(Btn_ListarProductos);
            PanelProducto.Controls.Add(TxtIdProduc);
            PanelProducto.Controls.Add(Btn_buscarProduc);
            PanelProducto.Controls.Add(Btn_AgregarProduc);
            PanelProducto.Controls.Add(Btn_ModifProduc);
            PanelProducto.Controls.Add(Btn_DeleteProduc);
            PanelProducto.Controls.Add(label1);
            PanelProducto.Location = new Point(12, 5);
            PanelProducto.Name = "PanelProducto";
            PanelProducto.Size = new Size(656, 334);
            PanelProducto.TabIndex = 32;
            // 
            // PanelProducVendido
            // 
            PanelProducVendido.BorderStyle = BorderStyle.FixedSingle;
            PanelProducVendido.Controls.Add(DgvProductoVendido);
            PanelProducVendido.Controls.Add(BtnListarProducVend);
            PanelProducVendido.Controls.Add(TxtIdProdVend);
            PanelProducVendido.Controls.Add(BtnBuscarProducVend);
            PanelProducVendido.Controls.Add(BtnAgregarProdVend);
            PanelProducVendido.Controls.Add(BtnModProdVend);
            PanelProducVendido.Controls.Add(BtnDeleteProdVend);
            PanelProducVendido.Controls.Add(label2);
            PanelProducVendido.Location = new Point(692, 5);
            PanelProducVendido.Name = "PanelProducVendido";
            PanelProducVendido.Size = new Size(656, 334);
            PanelProducVendido.TabIndex = 33;
            // 
            // DgvProductoVendido
            // 
            DgvProductoVendido.AllowUserToAddRows = false;
            DgvProductoVendido.AllowUserToDeleteRows = false;
            DgvProductoVendido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvProductoVendido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DgvProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductoVendido.Location = new Point(118, 32);
            DgvProductoVendido.MultiSelect = false;
            DgvProductoVendido.Name = "DgvProductoVendido";
            DgvProductoVendido.ReadOnly = true;
            DgvProductoVendido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProductoVendido.Size = new Size(531, 272);
            DgvProductoVendido.TabIndex = 0;
            DgvProductoVendido.SelectionChanged += DgvProductoVendido_SelectionChanged;
            // 
            // BtnListarProducVend
            // 
            BtnListarProducVend.FlatStyle = FlatStyle.Popup;
            BtnListarProducVend.Location = new Point(118, 5);
            BtnListarProducVend.Name = "BtnListarProducVend";
            BtnListarProducVend.Size = new Size(106, 23);
            BtnListarProducVend.TabIndex = 1;
            BtnListarProducVend.Text = "Listar Productos";
            BtnListarProducVend.UseVisualStyleBackColor = true;
            BtnListarProducVend.Click += BtnListarProducVend_Click;
            // 
            // TxtIdProdVend
            // 
            TxtIdProdVend.BorderStyle = BorderStyle.FixedSingle;
            TxtIdProdVend.Location = new Point(437, 5);
            TxtIdProdVend.Name = "TxtIdProdVend";
            TxtIdProdVend.PlaceholderText = "Id producto vendido ";
            TxtIdProdVend.Size = new Size(100, 23);
            TxtIdProdVend.TabIndex = 2;
            TxtIdProdVend.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBuscarProducVend
            // 
            BtnBuscarProducVend.FlatStyle = FlatStyle.Popup;
            BtnBuscarProducVend.Location = new Point(543, 5);
            BtnBuscarProducVend.Name = "BtnBuscarProducVend";
            BtnBuscarProducVend.Size = new Size(106, 23);
            BtnBuscarProducVend.TabIndex = 3;
            BtnBuscarProducVend.Text = "Buscar Producto";
            BtnBuscarProducVend.UseVisualStyleBackColor = true;
            BtnBuscarProducVend.Click += BtnBuscarProducVend_Click;
            // 
            // BtnAgregarProdVend
            // 
            BtnAgregarProdVend.FlatStyle = FlatStyle.Popup;
            BtnAgregarProdVend.Location = new Point(6, 33);
            BtnAgregarProdVend.Name = "BtnAgregarProdVend";
            BtnAgregarProdVend.Size = new Size(106, 42);
            BtnAgregarProdVend.TabIndex = 4;
            BtnAgregarProdVend.Text = "Agregar Producto";
            BtnAgregarProdVend.UseVisualStyleBackColor = true;
            BtnAgregarProdVend.Click += BtnAgregarProdVend_Click;
            // 
            // BtnModProdVend
            // 
            BtnModProdVend.FlatStyle = FlatStyle.Popup;
            BtnModProdVend.Location = new Point(6, 81);
            BtnModProdVend.Name = "BtnModProdVend";
            BtnModProdVend.Size = new Size(106, 42);
            BtnModProdVend.TabIndex = 5;
            BtnModProdVend.Text = "Modificar Producto";
            BtnModProdVend.UseVisualStyleBackColor = true;
            BtnModProdVend.Click += BtnModProdVend_Click;
            // 
            // BtnDeleteProdVend
            // 
            BtnDeleteProdVend.FlatStyle = FlatStyle.Popup;
            BtnDeleteProdVend.Location = new Point(6, 129);
            BtnDeleteProdVend.Name = "BtnDeleteProdVend";
            BtnDeleteProdVend.Size = new Size(106, 42);
            BtnDeleteProdVend.TabIndex = 6;
            BtnDeleteProdVend.Text = "Eliminar Producto";
            BtnDeleteProdVend.UseVisualStyleBackColor = true;
            BtnDeleteProdVend.Click += BtnDeleteProdVend_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 7);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 7;
            label2.Text = "CRUD Producto Vendido";
            // 
            // PanelUsuario
            // 
            PanelUsuario.BorderStyle = BorderStyle.FixedSingle;
            PanelUsuario.Controls.Add(DgvVentas);
            PanelUsuario.Controls.Add(BtnListarVentas);
            PanelUsuario.Controls.Add(TxtIdVenta);
            PanelUsuario.Controls.Add(BtnBuscarVenta);
            PanelUsuario.Controls.Add(BtnAgregarVenta);
            PanelUsuario.Controls.Add(BtnModificarVenta);
            PanelUsuario.Controls.Add(BtnEliminarVenta);
            PanelUsuario.Controls.Add(label3);
            PanelUsuario.Location = new Point(12, 345);
            PanelUsuario.Name = "PanelUsuario";
            PanelUsuario.Size = new Size(656, 334);
            PanelUsuario.TabIndex = 33;
            // 
            // DgvVentas
            // 
            DgvVentas.AllowUserToAddRows = false;
            DgvVentas.AllowUserToDeleteRows = false;
            DgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVentas.Location = new Point(118, 32);
            DgvVentas.MultiSelect = false;
            DgvVentas.Name = "DgvVentas";
            DgvVentas.ReadOnly = true;
            DgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvVentas.Size = new Size(531, 272);
            DgvVentas.TabIndex = 0;
            DgvVentas.SelectionChanged += DgvVentas_SelectionChanged;
            // 
            // BtnListarVentas
            // 
            BtnListarVentas.FlatStyle = FlatStyle.Popup;
            BtnListarVentas.Location = new Point(118, 5);
            BtnListarVentas.Name = "BtnListarVentas";
            BtnListarVentas.Size = new Size(106, 23);
            BtnListarVentas.TabIndex = 1;
            BtnListarVentas.Text = "Listar Ventas";
            BtnListarVentas.UseVisualStyleBackColor = true;
            BtnListarVentas.Click += BtnListarVentas_Click;
            // 
            // TxtIdVenta
            // 
            TxtIdVenta.BorderStyle = BorderStyle.FixedSingle;
            TxtIdVenta.Location = new Point(437, 5);
            TxtIdVenta.Name = "TxtIdVenta";
            TxtIdVenta.PlaceholderText = "Id venta ";
            TxtIdVenta.Size = new Size(100, 23);
            TxtIdVenta.TabIndex = 2;
            TxtIdVenta.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBuscarVenta
            // 
            BtnBuscarVenta.FlatStyle = FlatStyle.Popup;
            BtnBuscarVenta.Location = new Point(543, 5);
            BtnBuscarVenta.Name = "BtnBuscarVenta";
            BtnBuscarVenta.Size = new Size(106, 23);
            BtnBuscarVenta.TabIndex = 3;
            BtnBuscarVenta.Text = "Buscar Venta";
            BtnBuscarVenta.UseVisualStyleBackColor = true;
            BtnBuscarVenta.Click += BtnBuscarVenta_Click;
            // 
            // BtnAgregarVenta
            // 
            BtnAgregarVenta.FlatStyle = FlatStyle.Popup;
            BtnAgregarVenta.Location = new Point(6, 33);
            BtnAgregarVenta.Name = "BtnAgregarVenta";
            BtnAgregarVenta.Size = new Size(106, 42);
            BtnAgregarVenta.TabIndex = 4;
            BtnAgregarVenta.Text = "Agregar Venta";
            BtnAgregarVenta.UseVisualStyleBackColor = true;
            BtnAgregarVenta.Click += BtnAgregarVenta_Click;
            // 
            // BtnModificarVenta
            // 
            BtnModificarVenta.FlatStyle = FlatStyle.Popup;
            BtnModificarVenta.Location = new Point(6, 81);
            BtnModificarVenta.Name = "BtnModificarVenta";
            BtnModificarVenta.Size = new Size(106, 42);
            BtnModificarVenta.TabIndex = 5;
            BtnModificarVenta.Text = "Modificar Venta";
            BtnModificarVenta.UseVisualStyleBackColor = true;
            BtnModificarVenta.Click += BtnModificarVenta_Click;
            // 
            // BtnEliminarVenta
            // 
            BtnEliminarVenta.FlatStyle = FlatStyle.Popup;
            BtnEliminarVenta.Location = new Point(6, 129);
            BtnEliminarVenta.Name = "BtnEliminarVenta";
            BtnEliminarVenta.Size = new Size(106, 42);
            BtnEliminarVenta.TabIndex = 6;
            BtnEliminarVenta.Text = "Eliminar Venta";
            BtnEliminarVenta.UseVisualStyleBackColor = true;
            BtnEliminarVenta.Click += BtnEliminarVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 3);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 7;
            label3.Text = "CRUD Venta";
            // 
            // PanelVentas
            // 
            PanelVentas.BorderStyle = BorderStyle.FixedSingle;
            PanelVentas.Controls.Add(DgvUsuarios);
            PanelVentas.Controls.Add(BtnListarUsuarios);
            PanelVentas.Controls.Add(TxtIdUsuario);
            PanelVentas.Controls.Add(BtnBuscarUsuario);
            PanelVentas.Controls.Add(BtnAgregarUsuario);
            PanelVentas.Controls.Add(BtnModifUsuario);
            PanelVentas.Controls.Add(BtnEliminarUsuario);
            PanelVentas.Controls.Add(label4);
            PanelVentas.Location = new Point(692, 345);
            PanelVentas.Name = "PanelVentas";
            PanelVentas.Size = new Size(656, 334);
            PanelVentas.TabIndex = 33;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.AllowUserToAddRows = false;
            DgvUsuarios.AllowUserToDeleteRows = false;
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Location = new Point(118, 32);
            DgvUsuarios.MultiSelect = false;
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.ReadOnly = true;
            DgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuarios.Size = new Size(531, 272);
            DgvUsuarios.TabIndex = 0;
            DgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;
            // 
            // BtnListarUsuarios
            // 
            BtnListarUsuarios.FlatStyle = FlatStyle.Popup;
            BtnListarUsuarios.Location = new Point(118, 5);
            BtnListarUsuarios.Name = "BtnListarUsuarios";
            BtnListarUsuarios.Size = new Size(106, 23);
            BtnListarUsuarios.TabIndex = 1;
            BtnListarUsuarios.Text = "Listar Usuarios";
            BtnListarUsuarios.UseVisualStyleBackColor = true;
            BtnListarUsuarios.Click += BtnListarUsuarios_Click;
            // 
            // TxtIdUsuario
            // 
            TxtIdUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtIdUsuario.Location = new Point(437, 5);
            TxtIdUsuario.Name = "TxtIdUsuario";
            TxtIdUsuario.PlaceholderText = "Id usuario ";
            TxtIdUsuario.Size = new Size(100, 23);
            TxtIdUsuario.TabIndex = 2;
            TxtIdUsuario.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.FlatStyle = FlatStyle.Popup;
            BtnBuscarUsuario.Location = new Point(543, 5);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            BtnBuscarUsuario.Size = new Size(106, 23);
            BtnBuscarUsuario.TabIndex = 3;
            BtnBuscarUsuario.Text = "Buscar Usuario";
            BtnBuscarUsuario.UseVisualStyleBackColor = true;
            BtnBuscarUsuario.Click += BtnBuscarUsuario_Click;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.FlatStyle = FlatStyle.Popup;
            BtnAgregarUsuario.Location = new Point(6, 33);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(106, 42);
            BtnAgregarUsuario.TabIndex = 4;
            BtnAgregarUsuario.Text = "Agregar Usuario";
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // BtnModifUsuario
            // 
            BtnModifUsuario.FlatStyle = FlatStyle.Popup;
            BtnModifUsuario.Location = new Point(6, 81);
            BtnModifUsuario.Name = "BtnModifUsuario";
            BtnModifUsuario.Size = new Size(106, 42);
            BtnModifUsuario.TabIndex = 5;
            BtnModifUsuario.Text = "Modificar Usuario";
            BtnModifUsuario.UseVisualStyleBackColor = true;
            BtnModifUsuario.Click += BtnModifUsuario_Click;
            // 
            // BtnEliminarUsuario
            // 
            BtnEliminarUsuario.FlatStyle = FlatStyle.Popup;
            BtnEliminarUsuario.Location = new Point(6, 129);
            BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            BtnEliminarUsuario.Size = new Size(106, 42);
            BtnEliminarUsuario.TabIndex = 6;
            BtnEliminarUsuario.Text = "Eliminar Usuario";
            BtnEliminarUsuario.UseVisualStyleBackColor = true;
            BtnEliminarUsuario.Click += BtnEliminarUsuario_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(270, 3);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 7;
            label4.Text = "CRUD Usuarios";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 689);
            Controls.Add(PanelVentas);
            Controls.Add(PanelUsuario);
            Controls.Add(PanelProducVendido);
            Controls.Add(PanelProducto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoderHouse";
            Load += FrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProductos).EndInit();
            PanelProducto.ResumeLayout(false);
            PanelProducto.PerformLayout();
            PanelProducVendido.ResumeLayout(false);
            PanelProducVendido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvProductoVendido).EndInit();
            PanelUsuario.ResumeLayout(false);
            PanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).EndInit();
            PanelVentas.ResumeLayout(false);
            PanelVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvProductos;
        private Button Btn_ListarProductos;
        private TextBox TxtIdProduc;
        private Button Btn_buscarProduc;
        private Button Btn_AgregarProduc;
        private Button Btn_ModifProduc;
        private Button Btn_DeleteProduc;
        private Label label1;
        private Panel PanelProducto;
        private Panel PanelProducVendido;
        private DataGridView DgvProductoVendido;
        private Button BtnListarProducVend;
        private TextBox TxtIdProdVend;
        private Button BtnBuscarProducVend;
        private Button BtnAgregarProdVend;
        private Button BtnModProdVend;
        private Button BtnDeleteProdVend;
        private Label label2;
        private Panel PanelUsuario;
        private DataGridView DgvVentas;
        private Button BtnListarVentas;
        private TextBox TxtIdVenta;
        private Button BtnBuscarVenta;
        private Button BtnAgregarVenta;
        private Button BtnModificarVenta;
        private Button BtnEliminarVenta;
        private Label label3;
        private Panel PanelVentas;
        private DataGridView DgvUsuarios;
        private Button BtnListarUsuarios;
        private TextBox TxtIdUsuario;
        private Button BtnBuscarUsuario;
        private Button BtnAgregarUsuario;
        private Button BtnModifUsuario;
        private Button BtnEliminarUsuario;
        private Label label4;
    }
}

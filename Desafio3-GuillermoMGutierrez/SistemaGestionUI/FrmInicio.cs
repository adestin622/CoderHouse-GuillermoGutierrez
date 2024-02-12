using SistemaGestionBussiness;
using SistemaGestionDataEntities.Entidades;

namespace SistemaGestionUI
{
    public partial class FrmInicio : Form
    {
        private Producto producSeleccionado;
        private ProductoVendido producVendSeleccionado;
        private Ventum ventaSeleccionada;
        private Usuario userSeleccionado;

        public FrmInicio()
        {
            producSeleccionado = new();
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = ProductoBussiness.ListarProductos();

            DgvProductoVendido.DataSource = null;
            DgvProductoVendido.DataSource = ProductoVendidoBussiness.ListarProductosVendidos();

            DgvVentas.DataSource = null;
            DgvVentas.DataSource = VentumBussiness.ListarVentas();

            DgvUsuarios.DataSource = null;
            DgvUsuarios.DataSource = UsuarioBussiness.ListarUsuarios();
        }

        #region Producto
        private void Btn_buscarProduc_Click(object sender, EventArgs e)
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = ProductoBussiness.BuscarProducto(Convert.ToInt32(TxtIdProduc.Text));
            TxtIdProduc.Text = string.Empty;
        }

        private void Btn_ListarProductos_Click(object sender, EventArgs e)
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = ProductoBussiness.ListarProductos();
        }

        private void Btn_AgregarProduc_Click(object sender, EventArgs e)
        {
            ModalProducto newProduc = new(0);
            newProduc.ShowDialog();
        }

        private void Btn_ModifProduc_Click(object sender, EventArgs e)
        {
            ModalProducto newProduc = new(1, producSeleccionado);
            newProduc.ShowDialog();
            DgvProductos.DataSource = ProductoBussiness.ListarProductos();
        }

        private void Btn_DeleteProduc_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoBussiness.EliminarProducto(producSeleccionado.Id))
                {
                    MessageBox.Show("Selección eleminada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductoBussiness.ListarProductos();
                }
                else { MessageBox.Show("La selección no se encuentra en la BD", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar\n{ex.Message}", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvProductos.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.producSeleccionado = dato as Producto;
            }
        }

        #endregion


        #region ProductoVendido

        private void BtnListarProducVend_Click(object sender, EventArgs e)
        {
            DgvProductoVendido.DataSource = null;
            DgvProductoVendido.DataSource = ProductoVendidoBussiness.ListarProductosVendidos();
        }

        private void BtnBuscarProducVend_Click(object sender, EventArgs e)
        {
            DgvProductoVendido.DataSource = null;
            DgvProductoVendido.DataSource = ProductoVendidoBussiness.BuscarProductoVendido(Convert.ToInt32(TxtIdProdVend.Text));
            TxtIdProdVend.Text = string.Empty;
        }

        private void BtnAgregarProdVend_Click(object sender, EventArgs e)
        {
            ModalProductoVendido newProducVend = new(0);
            newProducVend.ShowDialog();
            DgvProductoVendido.DataSource = ProductoVendidoBussiness.ListarProductosVendidos();
        }

        private void BtnModProdVend_Click(object sender, EventArgs e)
        {
            ModalProductoVendido newProducVend = new(1, producVendSeleccionado);
            newProducVend.ShowDialog();
            DgvProductoVendido.DataSource = ProductoVendidoBussiness.ListarProductosVendidos();
        }

        private void BtnDeleteProdVend_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductoVendidoBussiness.EliminarProductoVendido(producVendSeleccionado.Id))
                {
                    MessageBox.Show("Selección eleminada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductoBussiness.ListarProductos();
                }
                else { MessageBox.Show("La selección no se encuentra en la BD", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar\n{ex.Message}", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvProductoVendido_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvProductoVendido.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.producVendSeleccionado = dato as ProductoVendido;
            }
        }
        #endregion


        #region Ventas
        private void BtnListarVentas_Click(object sender, EventArgs e)
        {
            DgvVentas.DataSource = null;
            DgvVentas.DataSource = VentumBussiness.ListarVentas();
        }

        private void BtnBuscarVenta_Click(object sender, EventArgs e)
        {
            DgvVentas.DataSource = null;
            DgvVentas.DataSource = VentumBussiness.BuscarVenta(Convert.ToInt32(TxtIdVenta.Text));
            TxtIdVenta.Text = string.Empty;
        }

        private void BtnAgregarVenta_Click(object sender, EventArgs e)
        {
            ModalVenta newVenta = new(0);
            newVenta.ShowDialog();
            DgvVentas.DataSource = VentumBussiness.ListarVentas();
        }

        private void BtnModificarVenta_Click(object sender, EventArgs e)
        {
            ModalVenta newVenta = new(1, ventaSeleccionada);
            newVenta.ShowDialog();
            DgvVentas.DataSource = VentumBussiness.ListarVentas();
        }

        private void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (VentumBussiness.EliminarVenta(ventaSeleccionada.Id))
                {
                    MessageBox.Show("Selección eleminada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VentumBussiness.ListarVentas();
                    DgvVentas.DataSource = VentumBussiness.ListarVentas();
                }
                else { MessageBox.Show("La selección no se encuentra en la BD", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar\n{ex.Message}", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvVentas.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.ventaSeleccionada = dato as Ventum;
            }
        }
        #endregion


        #region Usuarios
        private void BtnListarUsuarios_Click(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = null;
            DgvUsuarios.DataSource = UsuarioBussiness.ListarUsuarios();
        }

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            DgvUsuarios.DataSource = null;
            DgvUsuarios.DataSource = UsuarioBussiness.BuscarUsuario(Convert.ToInt32(TxtIdUsuario.Text));
            TxtIdUsuario.Text = string.Empty;
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ModalUsuario newUser= new(0);
            newUser.ShowDialog();
            DgvUsuarios.DataSource = UsuarioBussiness.ListarUsuarios();
        }

        private void BtnModifUsuario_Click(object sender, EventArgs e)
        {
            ModalUsuario newUser= new(1, userSeleccionado);
            newUser.ShowDialog();
            DgvUsuarios.DataSource = UsuarioBussiness.ListarUsuarios();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioBussiness.EliminarUsuario(userSeleccionado.Id))
                {
                    MessageBox.Show("Selección eleminada", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VentumBussiness.ListarVentas();
                    DgvUsuarios.DataSource = UsuarioBussiness.ListarUsuarios();
                }
                else { MessageBox.Show("La selección no se encuentra en la BD", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar\n{ex.Message}", "CoderHouse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = DgvUsuarios.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;
                this.userSeleccionado = dato as Usuario;
            }
        }
        #endregion
    }
}

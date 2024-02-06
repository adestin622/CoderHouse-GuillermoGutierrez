using Desafio2_GuillermoMGutierrez.Clases;
using Desafio2_GuillermoMGutierrez.ClasesData;
using Desafio2_GuillermoMGutierrez.Front;
using System.Diagnostics;

namespace Desafio2_GuillermoMGutierrez
{
    public partial class FrmInicio : Form
    {
        private FrmProducto formProducto;
        private FrmUsuario formUsuario;
        private FrmVenta formVenta;
        private FrmProductoVendido formProductoVendido;

        public FrmProducto FormProducto { get; set; }

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (formProducto == null)
            {
                formProducto = new FrmProducto();
                formProducto.Show();
            }
        }

        private void BtnProdVendidos_Click(object sender, EventArgs e)
        {
            if (formProductoVendido == null)
            {
                formProductoVendido = new FrmProductoVendido();
                formProductoVendido.Show();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            if (formVenta == null)
            {
                formVenta = new FrmVenta();
                formVenta.Show();
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            if (formUsuario == null)
            {
                formUsuario = new FrmUsuario();
                formUsuario.Show();
            }
        }
    }
}

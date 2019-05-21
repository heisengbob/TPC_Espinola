using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AppEscritorio
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo nuevoArticulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            nuevoArticulo = articulo;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (nuevoArticulo == null)
                    nuevoArticulo = new Articulo();

                nuevoArticulo.Codigo = int.Parse(txtCodigo.Text);
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                //nuevocliente.Marca = getMarca(txtMarca.Text);
                //nuevocliente.Tipo = getArticulo(txtTipo.Text);
                nuevoArticulo.Precio = float.Parse(txtPrecio.Text);
                nuevoArticulo.Costo = float.Parse(txtCosto.Text);
                nuevoArticulo.IVA = float.Parse(txtIVA.Text);
                nuevoArticulo.StockMin = int.Parse(txtStockMin.Text);

                negocio.agregarArticulo(nuevoArticulo);
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {

                //Opcional para combos
                //cboUniverso.DisplayMember = "Nombre";
                //cboUniverso.ValueMember = "Id";

                if (nuevoArticulo != null)
                {
                    txtCodigo.Text = nuevoArticulo.Codigo.ToString();
                    txtDescripcion.Text = nuevoArticulo.Descripcion;
                    //txtMarca.Text = nuevoArticulo.Marca.RazonSocial;
                    //txtTipo.Text = nuevoArticulo.Tipo.Descripcion;
                    txtPrecio.Text = nuevoArticulo.Precio.ToString();
                    txtCosto.Text = nuevoArticulo.Costo.ToString();
                    txtIVA.Text = nuevoArticulo.IVA.ToString();
                    txtStockMin.Text = nuevoArticulo.StockMin.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

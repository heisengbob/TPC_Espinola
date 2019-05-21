using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace AppEscritorio
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulosLocal;
        private void cargarGrilla()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulosLocal = negocio.listarArticulos();
                dgvArticulos.DataSource = listaArticulosLocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo frm_altaArticulo = new frmAltaArticulo();
            frm_altaArticulo.ShowDialog();
            cargarGrilla();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvArticulos.SelectedRows.Count != 0)
            {
                frmAltaArticulo modificarArticulo = new frmAltaArticulo((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
                modificarArticulo.ShowDialog();
                cargarGrilla();
            }
        }
    }
}

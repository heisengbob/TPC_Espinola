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
    public partial class frmClientes : Form
    {
        private List<Cliente> listaClientesLocal;
        public frmClientes()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                listaClientesLocal = negocio.listarClientes();
                dgvClientes.DataSource = listaClientesLocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAltaCliente frm_altaCliente = new frmAltaCliente();
            frm_altaCliente.ShowDialog();
            cargarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

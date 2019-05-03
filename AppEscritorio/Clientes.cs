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
    public partial class Clientes : Form
    {
        private List<Cliente> listaClientesLocal;
        public Clientes()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaCliente cliente = new frmAltaCliente();
            //client.BringToFront();
            cliente.ShowDialog();
            cargarGrilla();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}

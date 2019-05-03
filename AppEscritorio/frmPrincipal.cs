using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            client = Controls.OfType<MdiClient>().First();
            client.GotFocus += (s, e) => {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();
            };
        }
        MdiClient client;
        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras frm_compras = new frmCompras();
            frm_compras.MdiParent = this;
            client.BringToFront();
            frm_compras.MdiParent = this;
            frm_compras.ClientSize = new System.Drawing.Size(1300, 800);
            frm_compras.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_compras.Dock = DockStyle.Fill;
            frm_compras.Show();
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas frm_ventas = new frmVentas();
            frm_ventas.MdiParent = this;
            client.BringToFront();
            frm_ventas.MdiParent = this;
            frm_ventas.ClientSize = new System.Drawing.Size(1300, 800);
            frm_ventas.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_ventas.Dock = DockStyle.Fill;
            frm_ventas.Show();
        }
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos frm_articulos = new frmArticulos();
            frm_articulos.MdiParent = this;
            client.BringToFront();
            frm_articulos.MdiParent = this;
            frm_articulos.ClientSize = new System.Drawing.Size(1300, 800);
            frm_articulos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_articulos.Dock = DockStyle.Fill;
            frm_articulos.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm_clientes = new frmClientes();
            frm_clientes.MdiParent = this;
            client.BringToFront();
            frm_clientes.MdiParent = this;
            frm_clientes.ClientSize = new System.Drawing.Size(1300, 800);
            frm_clientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_clientes.Dock = DockStyle.Fill;
            frm_clientes.Show();
        }
    }
}

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
    public partial class Principal : Form
    {
        public Principal()
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
            Compras compras = new Compras();
            compras.MdiParent = this;
            client.BringToFront();
            compras.MdiParent = this;
            compras.ClientSize = new System.Drawing.Size(1300, 800);
            compras.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            compras.Dock = DockStyle.Fill;
            compras.Show();
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.MdiParent = this;
            client.BringToFront();
            ventas.MdiParent = this;
            ventas.ClientSize = new System.Drawing.Size(1300, 800);
            ventas.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ventas.Dock = DockStyle.Fill;
            ventas.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.MdiParent = this;
            client.BringToFront();
            articulos.MdiParent = this;
            articulos.ClientSize = new System.Drawing.Size(1300, 800);
            articulos.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            articulos.Dock = DockStyle.Fill;
            articulos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.MdiParent = this;
            client.BringToFront();
            clientes.MdiParent = this;
            clientes.ClientSize = new System.Drawing.Size(1300, 800);
            clientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            clientes.Dock = DockStyle.Fill;
            clientes.Show();
        }
    }
}

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
    public partial class frmAltaCliente : Form
    {
        private Cliente nuevocliente = null;
        public frmAltaCliente()
        {
            InitializeComponent();
        }
        public frmAltaCliente(Cliente cliente)
        {
            InitializeComponent();
            nuevocliente = cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Heroe heroe = new Heroe();
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable heroeLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (nuevocliente == null)
                    nuevocliente = new Cliente();

                nuevocliente.Nombre = txtNombre.Text;
                nuevocliente.Apellido = txtApellido.Text;
                nuevocliente.DNI = int.Parse(txtDNI.Text);
                nuevocliente.Direccion = txtDireccion.Text;
                nuevocliente.CodPostal = int.Parse(txtCodPostal.Text);
                nuevocliente.FNacimiento = dtpFNacimiento.Value;
                nuevocliente.Localidad = txtLocalidad.Text;
                nuevocliente.Mail = txtMail.Text;
                nuevocliente.Provincia = txtProvincia.Text;
                nuevocliente.Celular = txtCelular.Text;

                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.

                negocio.agregarCliente(nuevocliente);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

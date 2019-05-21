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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
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
                
                negocio.agregarCliente(nuevocliente);
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

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
              
            try
            {

                //Opcional para combos
                //cboUniverso.DisplayMember = "Nombre";
                //cboUniverso.ValueMember = "Id";

                if (nuevocliente != null)
                {
                    txtNombre.Text      = nuevocliente.Nombre;
                    txtApellido.Text    = nuevocliente.Apellido;
                    txtDNI.Text         = nuevocliente.DNI.ToString();
                    txtLocalidad.Text   = nuevocliente.Localidad;
                    txtProvincia.Text   = nuevocliente.Provincia;
                    txtMail.Text        = nuevocliente.Mail;
                    txtCelular.Text     = nuevocliente.Celular;
                    txtDireccion.Text   = nuevocliente.Direccion;
                    txtCodPostal.Text   = nuevocliente.CodPostal.ToString();
                    dtpFNacimiento.Value = nuevocliente.FNacimiento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

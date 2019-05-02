using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void agregarCliente(Cliente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into CLIENTES (Nombre, Apellido, DNI, Direccion, Provincia, Localidad, CodPostal, Fnacimiento, Celular, Mail) values";
                comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.DNI.ToString() + "', '" + nuevo.Direccion.ToString() + "'," +
                    nuevo.Provincia.ToString() + "'," + nuevo.Localidad.ToString() + "'," + nuevo.CodPostal.ToString() + "'," + nuevo.FNacimiento.Date.ToString() + "'," +
                    nuevo.Celular.ToString() + "'," + nuevo.Mail.ToString() + ")";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

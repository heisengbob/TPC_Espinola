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
        public List<Cliente> listarClientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select DNI, Nombre, Apellido, Direccion, CodPostal, FNacimiento, Localidad, Mail, Provincia, Celular  From CLIENTES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Cliente();
                    nuevo.DNI = lector.GetInt32(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Apellido = lector.GetString(2);
                    nuevo.Direccion = lector.GetString(3);
                    nuevo.CodPostal = lector.GetInt32(4);
                    nuevo.FNacimiento = lector.GetDateTime(5);
                    nuevo.Localidad = lector.GetString(6);
                    nuevo.Mail = lector.GetString(7);
                    nuevo.Provincia = lector.GetString(8);
                    nuevo.Celular = lector.GetString(9);
                    listado.Add(nuevo);
                }

                return listado;

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
                comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.DNI.ToString() + "', '" + nuevo.Direccion.ToString() + "','" +
                    nuevo.Provincia.ToString() + "','" + nuevo.Localidad.ToString() + "','" + nuevo.CodPostal.ToString() + "','" + nuevo.FNacimiento.Date.ToString() + "','" +
                    nuevo.Celular.ToString() + "','" + nuevo.Mail.ToString() + "')";
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

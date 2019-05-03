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
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> listado = new List<Articulo>();
            Articulo nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo,Descripcion,idMarca,idTipo,Precio,Costo,IVA,StockMin  From ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Articulo();
                    nuevo.Codigo = lector.GetInt32(0);
                    nuevo.Descripcion = lector.GetString(1);
                    //nuevo.Marca = traerMarca(lector.GetInt32(2));
                    //nuevo.Tipo = traerTipo(lector.GetInt32(3));
                    //nuevo.Precio = lector.GetFloat(4);
                    //nuevo.Costo = lector.GetFloat(5);
                    //nuevo.IVA = lector.GetFloat(6);
                    nuevo.StockMin = lector.GetInt32(7);
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
        public void agregarArticulo(Articulo nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into ARTICULOS (Codigo, Descripcion, idMarca, idTipo, Precio, Costo, IVA, StockMin) values";
                comando.CommandText += "('" + nuevo.Codigo + "', '" + nuevo.Descripcion + "', '" + nuevo.Marca + "', '" + nuevo.Tipo + "','" +
                    nuevo.Precio + "','" + nuevo.Costo + "','" + nuevo.IVA + "','" + nuevo.StockMin + "')";
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

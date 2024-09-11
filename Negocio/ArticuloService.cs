using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Dominio;
using System.Xml.Linq;



namespace Negocio
{
    public class ArticuloService
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;

                // Consulta combinada para ARTICULOS, MARCAS, CATEGORIAS e IMAGENES
                comando.CommandText = @"SELECT A.Codigo, A.Nombre, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl
                    FROM ARTICULOS A
                    LEFT JOIN MARCAS M ON A.Id = M.Id
                    LEFT JOIN CATEGORIAS C ON A.Id = C.Id
                    LEFT JOIN IMAGENES I ON A.Id = I.Id";


                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigoArticulo = Convert.ToString(lector["Codigo"]);
                    aux.nombre = Convert.ToString(lector["Nombre"]);
                    //aux.precio = Convert.ToDecimal(lector["Precio"]);
                    aux.precio = Convert.ToSingle(lector["Precio"]);
                    aux.marca = new Marca();
                    aux.marca.Descripcion = Convert.ToString(lector["Marca"]);
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = Convert.ToString(lector["Categoria"]);
                    aux.URLimagen = Convert.ToString(lector["ImagenUrl"]);
                    lista.Add(aux);
                }
                lector.Close();
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarProducto(Articulo _articulo)
        {
              AccesoDatos _accesoDatos= new AccesoDatos();

            try
            {
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Precio) VALUES ('" + _articulo.codigoArticulo + "','" + _articulo.nombre + "'," + _articulo.precio + ")");

                _accesoDatos.ejecutarAccion();

                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                _accesoDatos.cerrarConexion();
                
            }
        }
    }

}

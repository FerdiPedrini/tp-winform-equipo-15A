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
            AccesoDatos _accesoDatos = new AccesoDatos();
            
            List<Articulo> lista = new List<Articulo>();

            try
            {

                _accesoDatos.setearConsulta("SELECT Codigo,Nombre, A.Descripcion,Precio, M.Descripcion Marca,C.Descripcion Categoria, I.ImagenUrl From ARTICULOS A, MARCAS M, CATEGORIAS C,IMAGENES I Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                _accesoDatos.ejecutarLectura();

                while (_accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.codigoArticulo = (string)_accesoDatos.Lector["Codigo"];
                    aux.nombre = (string)_accesoDatos.Lector["Nombre"];
                    aux.descripcion = (string)_accesoDatos.Lector["Descripcion"];
                    aux.precio = Convert.ToSingle(_accesoDatos.Lector["Precio"]);
                    
                    aux.marca = new Marca();
                    aux.marca.Descripcion = (string)_accesoDatos.Lector["Marca"];
                    
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)_accesoDatos.Lector["Categoria"];
                 
                    aux.URLimagen = (string)_accesoDatos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }


                return lista;
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

        public void agregarProducto(Articulo _articulo)
        {
              AccesoDatos _accesoDatos= new AccesoDatos();

            try
            {
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Precio,Descripcion) VALUES ('" + _articulo.codigoArticulo + "','" + _articulo.nombre + "','" + _articulo.descripcion + "'," + _articulo.precio + ")");

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

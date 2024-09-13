using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Dominio;
using System.Xml.Linq;
using System.ComponentModel;



namespace Negocio
{
    public class ArticuloService
    {
        /*  public List<Articulo> listar()
          {
              AccesoDatos _accesoDatos = new AccesoDatos();

              List<Articulo> lista = new List<Articulo>();

              try
              {

                  _accesoDatos.setearConsulta("SELECT Codigo,Nombre, A.Descripcion,Precio, M.Descripcion Marca,C.Descripcion Categoria, I.ImagenUrl From ARTICULOS A, MARCAS M, CATEGORIAS C,IMAGENES I Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                  // _accesoDatos.setearConsulta("SELECT Codigo,Nombre, A.Descripcion,Precio, M.Descripcion Marca,C.Descripcion Categoria, I.ImagenUrl From ARTICULOS A, MARCAS M, CATEGORIAS C,IMAGENES I Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                  _accesoDatos.ejecutarLectura();

                  while (_accesoDatos.Lector.Read())
                  {
                      Articulo aux = new Articulo();

                      aux.codigoArticulo = (string)_accesoDatos.Lector["Codigo"];
                      aux.nombre = (string)_accesoDatos.Lector["Nombre"];
                      aux.descripcion = (string)_accesoDatos.Lector["Descripcion"];
                      aux.precio = Convert.ToDecimal( _accesoDatos.Lector["Precio"]);

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
                  //_accesoDatos.cerrarConexion();
              }

          }
        */

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                //_accesoDatos.setearConsulta("SELECT Codigo,Nombre, A.Descripcion,Precio, M.Descripcion Marca,C.Descripcion Categoria, I.ImagenUrl From ARTICULOS A, MARCAS M, CATEGORIAS C,IMAGENES I Where M.Id = A.IdMarca And C.Id = A.IdCategoria");
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Nombre_Marca, "
                    + "C.Descripcion Nombre_Categoria, M.Id Id_Marca, C.Id Id_Categoria, A.Precio, I.ImagenUrl UrlImagen FROM ARTICULOS A JOIN CATEGORIAS C " +
                    "ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id ORDER BY A.Id ASC");



                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {


                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    //Creacion de Marca y relacion en datagrid
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)accesoDatos.Lector["Nombre_Marca"];



                    //Creacion de Categoria y relacion en datagrid
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Nombre_Categoria"];


                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];

                    /*
                    if(!(accesoDatos.Lector.IsDBNull(accesoDatos.GetOrdinal("URLImagen"))));
                            articulo.UrlImagen = (string)accesoDatos.Lector["UrlImagen"];
                            //--------------//
                            if(!(accesoDatos.Lector["UrlImagen"] is DBNull))
                            articulo.UrlImagen=(string)accesoDatos.Lector["UrlImagen"];
                    **/
                    // si no tiene imagenes, no se cargan en el objeto


                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //accesoDatos.cerrarConexion();
            }
        }
        public void agregarProducto(Articulo _articulo)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();

            try
            {
                // _accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Precio,Descripcion, IdMarca,IdCategoria) VALUES ('" + _articulo.codigoArticulo + "','" + _articulo.nombre + "','" + _articulo.precio + "','" + _articulo.descripcion + "'" + _articulo.marca.Id + ","+ _articulo.categoria.Id + ")");
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria) VALUES(@codigo,@nombre,@precio,@descripcion,@IdMarca,@IdCategoria)");
                _accesoDatos.setearParametro("@codigo", _articulo.CodigoArticulo);
                _accesoDatos.setearParametro("@nombre", _articulo.Nombre);
                _accesoDatos.setearParametro("@precio",_articulo.Precio);
                _accesoDatos.setearParametro("@descripcion", _articulo.Descripcion);
                _accesoDatos.setearParametro("@IdMarca", _articulo.Marca.Id);
                _accesoDatos.setearParametro("@IdCategoria", _articulo.Categoria.Id);
                    
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
        public void eliminar(int id)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();
            try
            {

                _accesoDatos.setearConsulta("delete from Articulos where id = @id");
                _accesoDatos.setearParametro("@id", id);
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

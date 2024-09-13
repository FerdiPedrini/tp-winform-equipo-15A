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

        public void agregarProducto(Articulo _articulo)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();

            try
            {
                // _accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Precio,Descripcion, IdMarca,IdCategoria) VALUES ('" + _articulo.codigoArticulo + "','" + _articulo.nombre + "','" + _articulo.precio + "','" + _articulo.descripcion + "'" + _articulo.marca.Id + ","+ _articulo.categoria.Id + ")");
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria) VALUES(@codigo,@nombre,@precio,@descripcion,@IdMarca,@IdCategoria)");
                _accesoDatos.setearParametro("@codigo", _articulo.codigoArticulo);
                _accesoDatos.setearParametro("@nombre", _articulo.nombre);
                _accesoDatos.setearParametro("@precio",_articulo.precio);
                _accesoDatos.setearParametro("@descripcion", _articulo.descripcion);
                _accesoDatos.setearParametro("@IdMarca", _articulo.marca.Id);
                _accesoDatos.setearParametro("@IdCategoria", _articulo.categoria.Id);
                    
                    _accesoDatos.ejecutarAccion();



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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos _accesoDatos = new AccesoDatos();
                _accesoDatos.setearConsulta("delete from pokemons where id = @id");

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
    }
}

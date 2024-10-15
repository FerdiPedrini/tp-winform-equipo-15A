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
        public void modificar(Articulo articulo)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();
            try
            {
                _accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");


                _accesoDatos.setearParametro("@codigo", articulo.CodigoArticulo);
                _accesoDatos.setearParametro("@nombre", articulo.Nombre);
                _accesoDatos.setearParametro("@desc", articulo.Descripcion);
             
                _accesoDatos.setearParametro("@idCategoria", articulo.Categoria.Id);
                _accesoDatos.setearParametro("@precio", articulo.Precio);
                _accesoDatos.setearParametro("@idMarca", articulo.Marca.Id);
                _accesoDatos.setearParametro("@id", articulo.Id);

                _accesoDatos.ejecutarAccion();
            }

            catch(Exception ex) { throw ex;  }
            finally
            {
                _accesoDatos.cerrarConexion();
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            ImagenService imagenService = new ImagenService();

            try
            {
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Nombre_Marca,C.Descripcion Nombre_Categoria, M.Id Id_Marca, C.Id Id_Categoria, A.Precio FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id ORDER BY A.Id ASC");
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
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];

                    //Creacion de Categoria y relacion en datagrid
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];

                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];
                    
                    lista.Add(articulo);
                }

                foreach (var a in lista)
                {
                    List<Imagen> imagens = imagenService.listarPorIdArticulo(a.Id);
                    a.Imagenes = imagens;
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
                
            }
        }

        public int agregarProducto(Articulo _articulo)
        {
            AccesoDatos _accesoDatos = new AccesoDatos();
            ImagenService aux = new ImagenService();
         


            try
            {
                
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Precio, Descripcion, IdMarca, IdCategoria)OUTPUT inserted.Id VALUES(@codigo,@nombre,@precio,@descripcion,@IdMarca,@IdCategoria)");
                _accesoDatos.setearParametro("@codigo", _articulo.CodigoArticulo);
                _accesoDatos.setearParametro("@nombre", _articulo.Nombre);
                _accesoDatos.setearParametro("@precio",_articulo.Precio);
                _accesoDatos.setearParametro("@descripcion", _articulo.Descripcion);
                _accesoDatos.setearParametro("@IdMarca", _articulo.Marca.Id);
                _accesoDatos.setearParametro("@IdCategoria", _articulo.Categoria.Id);

                int IdArticuloNuevo = _accesoDatos.insertarYobtenerId();

                return IdArticuloNuevo;


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

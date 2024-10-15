using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenService
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id,IdArticulo,ImagenUrl FROM Imagenes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
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

                datos.cerrarConexion();
            }
        }

        public List<Imagen> listarPorIdArticulo(int id)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select * FROM IMAGENES WHERE IDArticulo=@id_articulo");
                datos.setearParametro("@id_articulo", id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
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

                datos.cerrarConexion();
            }
        }

            public void agregarImagen(Imagen imagen, int idArticulo)
        {
            AccesoDatos _accesodatos = new AccesoDatos();
            try
            {
                _accesodatos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @UrlImagen)");
                _accesodatos.setearParametro("@IdArticulo", idArticulo);
                _accesodatos.setearParametro("@UrlImagen", imagen.UrlImagen);
                _accesodatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _accesodatos.cerrarConexion();
            }
        }
    }
}

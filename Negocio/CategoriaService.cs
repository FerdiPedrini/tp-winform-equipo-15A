using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;

namespace Negocio
{
    public class CategoriaService
    {
        public List<Categoria> listar() {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
			{
                datos.setearConsulta("Select Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
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
        public void AgregarCategoria(string CategoriaNueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("INSERT INTO CATEGORIAS(Descripcion) VALUES(@categoria)");
                datos.setearParametro("@categoria", CategoriaNueva);
                datos.ejecutarAccion();
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

        public void EliminarCategoria(string CategoriaEliminada)
        {
            AccesoDatos datos=new AccesoDatos();
            try
            {
                datos.setearConsulta("delete CATEGORIAS from CATEGORIAS where Descripcion=@Descripcion");
                datos.setearParametro("@Descripcion",CategoriaEliminada);
                datos.ejecutarAccion();
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
    }
  


 }


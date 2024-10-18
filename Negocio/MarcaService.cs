using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaService
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Marca aux = new Marca();
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
                //esto estaba comentado... no se para que
                datos.cerrarConexion();
            }
        }

        public void AgregarMarca (string NuevaMarca)
        {
            AccesoDatos datos = new AccesoDatos ();
            try
            {
                datos.setearConsulta("INSERT INTO MARCAS(Descripcion) VALUES(@marcas)");
                datos.setearParametro("@marcas",NuevaMarca);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //esto estaba comentado... no se para que
                datos.cerrarConexion();
            }
        }
        public void EliminarMarca(string MarcaSeleccionada)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete Marcas from Marcas where Descripcion=@Descripcion");
                datos.setearParametro("@Descripcion", MarcaSeleccionada);
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

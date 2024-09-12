using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulo
    {
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; } 
        public Marca marca { get; set; } //(seleccionable de una lista desplegable).
        public Categoria categoria { get; set; } //(seleccionable de una lista desplegable.
        public float precio { get; set; }
        public string URLimagen {  get; set; }
  
    }
}

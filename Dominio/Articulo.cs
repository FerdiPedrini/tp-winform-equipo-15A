using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código de Artículo")]
        public string CodigoArticulo { get; set; }
        [DisplayName("Nombre Artículo")]
        public string Nombre { get; set; }
        [DisplayName("Descripcíon")]
        public string Descripcion { get; set; }
        [DisplayName("Marca Artículo")]
        public Marca Marca { get; set; }
        [DisplayName("Categoría Artículo")]
        public Categoria Categoria { get; set; }
        [DisplayName("Precio")]
        public decimal Precio { get; set; }


    }
}

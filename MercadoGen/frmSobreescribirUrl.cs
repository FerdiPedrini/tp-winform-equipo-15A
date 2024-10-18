using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class frmSobreescribirUrl : Form
    {
        public Articulo articulo { get; set; } = new Articulo();
        public Imagen imagenSeleccionada { get; set; } = new Imagen();

        public frmSobreescribirUrl()
        {
            InitializeComponent();
        }

        public frmSobreescribirUrl(Articulo articuloEntrante,Imagen ImagenSeleccionadaEntrante)
        {
            articulo = articuloEntrante;
            imagenSeleccionada = ImagenSeleccionadaEntrante;
            InitializeComponent();
        }

        private void btnSobreescribirUrl_Click(object sender, EventArgs e)
        {
            string ImagenUrl = txtSobreescribirUrl.Text;
            ImagenService imagenService = new ImagenService();
            Imagen imagen = new Imagen();

            imagen.UrlImagen = ImagenUrl;
            imagenService.eliminarImagen(imagenSeleccionada,articulo.Id);
            imagenService.agregarImagen(imagen,articulo.Id);
        }
    }
}


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
    public partial class frmModNuevaImg : Form
    {
        public Articulo articulo { get; set; } = new Articulo();

        public frmModNuevaImg()
        {
            InitializeComponent();
        }
        public frmModNuevaImg(Articulo articuloEntrante)
        {
            articulo= articuloEntrante;
            InitializeComponent();
        }
        private void frmModNuevaImg_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaIMG_Click(object sender, EventArgs e)
        {
            string ImagenUrl = txtUrlNuevaIMG.Text;
            ImagenService imagenService = new ImagenService();
            Imagen imagen = new Imagen();

            imagen.UrlImagen = ImagenUrl;
            imagenService.agregarImagen(imagen, articulo.Id);
        }
    }
}

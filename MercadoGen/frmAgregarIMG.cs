using Dominio;
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
    public partial class frmAgregarIMG : Form
    {
        public List<Imagen> listaImagen;
        
        
          
        

 
        public frmAgregarIMG()
        {
            listaImagen = new List<Imagen>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ImagenUrl = txtBoxUrLImg.Text;
            Imagen imagen = new Imagen();
            ImagenUrl = "https://next-images.123rf.com/index/_next/image/?url=https://assets-cdn.123rf.com/index/static/assets/top-section-bg.jpeg&w=3840&q=75";
            imagen.UrlImagen = ImagenUrl;

            listaImagen.Add(imagen);
         
            MemoriaArticulo.Instance().Articulo.Imagenes = listaImagen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

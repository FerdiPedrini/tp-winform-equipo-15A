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
    public partial class frmModificarImg : Form
    {
        public Articulo articulo { get; set; } = new Articulo();
        public List<Imagen> imagenesAmodificar { get; set; } = new List<Imagen>();
        public Imagen imagen { get; set; } = new Imagen();
        bool modificar = false;
        

        public frmModificarImg()
        {
            InitializeComponent();
        }

        public frmModificarImg(Articulo articulo,bool modificar)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.modificar = modificar;
            this.imagen = imagen;

        }

        private void frmModificarImg_Load(object sender, EventArgs e)
        {
            cargaDGVmodificarIMG();
        }

        public void cargaDGVmodificarIMG()
        {
            ImagenService imagenService = new ImagenService();
            imagenesAmodificar = imagenService.listarPorIdArticulo(articulo.Id);
            dgvModificarImg.DataSource= imagenesAmodificar;            
        }


        private void cargarImagen (string Urlimagen)
        {
            try
            {

                pbxModificarImg.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxModificarImg.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }
        }

        private void dgvModificarImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificarImg.CurrentRow != null)
            {
                Imagen seleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;

                cargarImagen(seleccionada.UrlImagen);
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            frmModNuevaImg frmModNuevaImg = new frmModNuevaImg(articulo);
            frmModNuevaImg.ShowDialog();
        }

        private void btnModificarImg_Click(object sender, EventArgs e)
        {
           Imagen ImagenSeleccionada=new Imagen();

            if (dgvModificarImg.CurrentRow != null)
            {
               ImagenSeleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;

                
            }
             ImagenSeleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;

            frmSobreescribirUrl frmSobreescribirUrl = new frmSobreescribirUrl(articulo, ImagenSeleccionada);
            frmSobreescribirUrl.ShowDialog();
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            Imagen ImagenSeleccionada = new Imagen();
            ImagenService imagenService = new ImagenService();
            if (dgvModificarImg.CurrentRow != null)
            {
                ImagenSeleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;


            }
            ImagenSeleccionada = (Imagen)dgvModificarImg.CurrentRow.DataBoundItem;
            imagenService.eliminarImagen(ImagenSeleccionada,articulo.Id);

        }
    }
}

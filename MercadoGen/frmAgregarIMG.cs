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
    public partial class frmAgregarIMG : Form
    {
        public List<Imagen> listaImagen = new List<Imagen>();
        public List<Imagen> listaImagen2 = new List<Imagen>();
        public Articulo articulo = new Articulo();
        public bool modificar = false;
       
        public frmAgregarIMG()
        {
            
            
            InitializeComponent();
        }
        public frmAgregarIMG(Articulo articuloEntrante,bool modificarEntrante)
        {
            
            modificar  = modificarEntrante;
            articulo = articuloEntrante;

            InitializeComponent();

        }


        public void cargaDataGridView()
        { 
            ImagenService imagenService = new ImagenService();
            

            if (modificar)
            {
                listaImagen = imagenService.listarPorIdArticulo(articulo.Id);
                dgvAgregarImg.DataSource = listaImagen;

            }
            else
            {
                listaImagen = imagenService.listar();
                dgvAgregarImg.DataSource = MemoriaArticulo.Instance().Articulo.Imagenes;
            }

            //Articulo ArticuloPrueba = new Articulo();
            //ArticuloPrueba = MemoriaArticulo.Instance().Articulo;
            ocultarColumnasImagen();
        }

        

        public void ocultarColumnasImagen()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ImagenUrl = txtBoxUrLImg.Text;
            Imagen imagen = new Imagen();
           // ImagenUrl = "https://next-images.123rf.com/index/_next/image/?url=https://assets-cdn.123rf.com/index/static/assets/top-section-bg.jpeg&w=3840&q=75";
            imagen.UrlImagen = ImagenUrl;

            listaImagen2.Add(imagen);
         
            articulo.Imagenes = listaImagen2;
            MemoriaArticulo.Instance().Articulo=articulo;

            MessageBox.Show("Imagen agregada con exito");
            txtBoxUrLImg.Text = "";
            cargaDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoriaArticulo.Instance().ReinicarMemoria();
            this.Close();
        }

        private void frmAgregarIMG_Load(object sender, EventArgs e)
        {
            cargaDataGridView();
        }

        private void dgvAgregarImg_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAgregarImg.CurrentRow != null)
            {
                Imagen seleccionado = (Imagen)dgvAgregarImg.CurrentRow.DataBoundItem;
                
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarImagen(string Urlimagen)
        {
            try
            {

                pbxAgregarImg.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxAgregarImg.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }


        }
    }
}

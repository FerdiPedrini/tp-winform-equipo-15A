using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Mercado
{
    public partial class frmAgregarImagen : Form
    {
        public List <Imagen> ListaUrl { get;} = new List <Imagen> ();

        public frmAgregarImagen()
        {
            InitializeComponent();
        }

        private void btnAgregarURL_Click(object sender, EventArgs e)
        {
            Imagen imagen = new Imagen();

            imagen.UrlImagen = txtUrlImagen.Text;
            
            

            ListaUrl.Add(imagen);

            txtUrlImagen.Clear();

            if (dgvListaImagenes.DataSource != null)
                dgvListaImagenes.DataSource = null;
            
            dgvListaImagenes.DataSource = ListaUrl;

            
        }
        /*
        public void cargaDataGrip()
        {
            ArticuloService articulo = new ArticuloService();

            listaArticulos = articulo.listar();
            dgvListaProd.DataSource = listaArticulos;
            dgvListaProd.Columns["Id"].Visible = false;
            cargarImagen(listaArticulos[0].listaImagenes);


        }
        private void dgvListaProd_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem; //DAME EL OBJ ENLAZADO //DEVUELVE UN OBJ 
                                                                                     //cargarImagen(seleccionado.URLimagen);


        }
        private void cargarImagen(List<Imagen> ListaImagenes)
        {
            try
            {
                //forEach//
                pbxArt.Load(ListaImagenes[0].UrlImagen);

            }
            catch (Exception ex)
            {

                pbxArt.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");

            }
        }
        */

        private void dgvListaImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

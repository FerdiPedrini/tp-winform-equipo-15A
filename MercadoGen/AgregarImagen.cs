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
        public List<Imagen> ListaIMG { get; }=new List<Imagen>();
        
        public bool Resultado { get; set; } = false;


        public frmAgregarImagen()
        {
            InitializeComponent();
            
        }
        public frmAgregarImagen(List<Imagen>listaImagenes)
        {
            if (listaImagenes.Count == 0)
            {
                InitializeComponent();
                return;
            }
            
            ListaIMG = listaImagenes;
            InitializeComponent();
             dgvListaImagenes.DataSource = ListaIMG;
            
            this.ocultarColumnas();
        }

        private void btnCargarIMG_Click(object sender, EventArgs e)
        {

            try
            {
                Imagen linkImagen = new Imagen();
                 linkImagen.UrlImagen= txtUrlImagen.Text;

                if (linkImagen.UrlImagen.Trim() == "")
                {
                    txtUrlImagen.Clear();
                    return;
                }

                ListaIMG.Add(linkImagen);
                txtUrlImagen.Clear();
                
                if (dgvListaImagenes.DataSource != null)
                    dgvListaImagenes.DataSource = null;

                dgvListaImagenes.DataSource = ListaIMG;
                
                this.ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
    
             
        }


        private void cargarImagen(string Urlimagen)
        {
            try

            {
                pbxListaImagenes.Load(Urlimagen);

            }
            catch (Exception ex)
            {

                pbxListaImagenes.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");

            }
        }
        private void ocultarColumnas ()
        {
            dgvListaImagenes.Columns["id"].Visible = false;
            dgvListaImagenes.Columns["idArticulo"].Visible = false;
        }

        private void dgvListaImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaImagenes.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                Imagen seleccionada = (Imagen)dgvListaImagenes.CurrentRow.DataBoundItem;
                //DAME EL OBJ ENLAZADO //DEVUELVE UN OBJ 
                cargarImagen(seleccionada.UrlImagen);

            }
            catch (Exception)
            {

                cargarImagen("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
            }       

        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Resultado = false;
            this.Close();
        }

        private void btnAgrImgAceptar_Click(object sender, EventArgs e)
        {
            Resultado = true;
            this.Close();
        }
    }
}

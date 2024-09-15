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
    public partial class Mercado : Form
    {
        private List<Articulo> listaArticulos;
       

        public Mercado()
        {
            InitializeComponent();
            
        }

        private void MercadoGen_Load(object sender, EventArgs e)
        {

            cargaDataGrip();            
           
        }
        public void cargaDataGrip()
        {   
            
            
            ArticuloService articuloService = new ArticuloService();
            try
            {
                listaArticulos = articuloService.listar();
                dgvListaProd.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].listaImagenes);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           


        }

        private void dgvListaProd_SelectionChanged(object sender, EventArgs e)
        {
          
        }
        private void cargarImagen ( List<Imagen> ListaImgArt,int indice = 0 , bool siguienteImagen = true   )
        {
          
           if (ListaImgArt.Count == 0)
            {
                pbxArt.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");

                return;
            }

            int i = indice;
            do
            {

                try
                {

                    pbxArt.Load(ListaImgArt[i].UrlImagen);

                    return;

                }
                catch (Exception)
                {

                    if (siguienteImagen)
                    {
                        if (i < ListaImgArt.Count - 1)
                            i++;
                        else
                            i = 0;

                    }
                    else
                    {
                        if (i != 0)
                            i--;
                        else
                            i = ListaImgArt.Count - 1;
                    }
                }
            } while (i != indice);

                pbxArt.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;
            
        }
        
        private void ocultarColumnas() 
        {
            dgvListaProd.Columns["Id"].Visible = false;

        }
        private void agregarProducto_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto alta = new FrmAgregarProducto();
            alta.ShowDialog();
            int index = dgvListaProd.TabIndex;
            if(index == 0)
            {
                dgvListaProd.TabIndex++;
            }
            else
            {
                dgvListaProd.TabIndex--;
            }
            cargaDataGrip();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ArticuloService service = new ArticuloService();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
                service.eliminar(seleccionado.Id);
                cargaDataGrip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void dgvListaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool modificar = true;

            Articulo seleccionado;
            seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;

            FrmAgregarProducto frmmodificar = new FrmAgregarProducto(seleccionado,modificar);
            frmmodificar.ShowDialog();
            cargaDataGrip();
        }
    }
}

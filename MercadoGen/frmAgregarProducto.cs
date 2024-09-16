using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class FrmAgregarProducto : Form
    {
        private Articulo articulo { get; set; } = new Articulo();
        private Imagen imagen { get; set; } =new Imagen();
        private bool modificar = false;

        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        public FrmAgregarProducto(Articulo articulo, bool modificar)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.modificar = modificar; 
            Text = "Modificar Articulo"; 
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloService ArticuloNuevo = new ArticuloService();
            ImagenService aux = new ImagenService();


            try
            {
                if (articulo == null && imagen == null)
                {
                    articulo = new Articulo();
                    imagen = new Imagen();
                }
            articulo.CodigoArticulo=textCodigo.Text;
            articulo.Nombre = textNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Precio = Convert.ToDecimal(textPrecio.Text);
            articulo.Marca = (Marca)cbMarca.SelectedItem;        
            articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
            imagen.UrlImagen = txtUrlImagen.Text;

                if (articulo.Id != 0)
                {
                    ArticuloNuevo.modificar(articulo);
                    MessageBox.Show("PRODUCTO MODIFICADO CON EXITO");
                }

                else
                {
                    
                    int idArt = ArticuloNuevo.agregarProducto(articulo);
                    aux.agregarImagen(imagen,idArt);

                    MessageBox.Show("PRODUCTO AGREGADO CON EXITO");
                }
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
 
        }


        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            CategoriaService categoria = new CategoriaService();
            MarcaService marca = new MarcaService();
           
            try
            {
                cbCategoria.DataSource = categoria.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = marca.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

               if(modificar)
               
                {

                    textCodigo.Text = articulo.CodigoArticulo;
                    textNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    textPrecio.Text = articulo.Precio.ToString();
                    cbMarca.Text = articulo.Marca.ToString();
                    cbCategoria.Text = articulo.Categoria.ToString();
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

            
        }

        

     
    }
}

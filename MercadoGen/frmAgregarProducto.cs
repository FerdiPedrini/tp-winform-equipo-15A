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
        private Articulo articulo = null;
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        public FrmAgregarProducto(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo"; 
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloService ArticuloNuevo = new ArticuloService();

            try
            {
                if (articulo == null)
                articulo = new Articulo();

            articulo.CodigoArticulo=textCodigo.Text;
            articulo.Nombre = textNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Precio = Convert.ToDecimal(textPrecio.Text);
            articulo.Marca = (Marca)cbMarca.SelectedItem;        
            articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                //articulo.Url = textURLimagen.Text;

                if (articulo.Id != 0)
                {
                    ArticuloNuevo.modificar(articulo);
                    MessageBox.Show("PRODUCTO MODIFICADO CON EXITO");
                }

                else
                {
                    ArticuloNuevo.agregarProducto(articulo);
                    MessageBox.Show("PRODUCTO AGREGADO CON EXITO");
                }
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
 
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

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
               

                if (articulo != null)
                {
                    textCodigo.Text = articulo.CodigoArticulo;
                    textNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    textPrecio.Text = articulo.Precio.ToString();
                    cbMarca.Text = articulo.Marca.ToString();
                    cbCategoria.Text = articulo.Categoria.ToString();
                    //hacer imagen dsp
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

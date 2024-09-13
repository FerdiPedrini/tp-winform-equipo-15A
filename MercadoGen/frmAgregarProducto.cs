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
        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            
            //Categoria categoria = new Categoria();
            //{
            //Descripcion = cbCategoria.Text;
            //}
            try
            {
             articulo.codigoArticulo=textCodigo.Text;
            articulo.nombre = textNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.precio = Convert.ToDecimal(textPrecio.Text);

            articulo.marca = (Marca)cbMarca.SelectedItem;        
            articulo.categoria = (Categoria)cbCategoria.SelectedItem;
            articulo.URLimagen = textURLimagen.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                ArticuloService ArticuloNuevo = new ArticuloService();
                
                ArticuloNuevo.agregarProducto(articulo);
                
                MessageBox.Show("PRODUCTO AGREGADA CON EXITO");

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
                cbMarca.DataSource = marca.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

            
        }
    }
}

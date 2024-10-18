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
        public Articulo articulo { get; set; } = new Articulo();
        public List<Imagen> ImagenesBuffer { get; set; } = new List<Imagen>();
        public Imagen imagen { get; set; } =new Imagen();
        public bool modificar = false;

        public static frmAgregarIMG instance;
       


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
            Articulo vistaarticulo = articulo;
            ArticuloService ArticuloNuevo = new ArticuloService();
            ImagenService imagenService = new ImagenService();
            decimal precio;
            bool esMoney = decimal.TryParse(textPrecio.Text, out precio) && precio >= 0;

            try
            {
                
            
                    if (articulo == null && imagen == null)
                    {
                        articulo = new Articulo();
                        imagen = new Imagen();
                    }

               
                    if (esMoney)
                    {
                        articulo.CodigoArticulo = textCodigo.Text;
                        articulo.Nombre = textNombre.Text;
                        articulo.Descripcion = txtDescripcion.Text;
                        articulo.Precio = Convert.ToDecimal(textPrecio.Text);
                        articulo.Marca = (Marca)cbMarca.SelectedItem;
                        articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                        articulo.Imagenes = MemoriaArticulo.Instance().Articulo.Imagenes;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un precio valido");
                    }
                

                if (modificar && esMoney)
                {
                    ArticuloNuevo.modificar(articulo);
                    MessageBox.Show("PRODUCTO MODIFICADO CON EXITO");
                }

                else if (esMoney)
                {                    
                    int idArt = ArticuloNuevo.agregarProducto(articulo);

                    MessageBox.Show("PRODUCTO AGREGADO CON EXITO");
                    MemoriaArticulo.Instance().ReinicarMemoria();
                }
                if (esMoney)
                {
                 Close();
                }

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
                    BTN_AgregarImagenes.Text = "Modificar";
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          

            
        }


        private void BTN_AgregarImagenes_Click(object sender, EventArgs e)
        {
            
            if (modificar == true)
            {
               
                frmModificarImg formModificar= new frmModificarImg(articulo,modificar);
                formModificar.ShowDialog();
                
            } else
            {
                frmAgregarIMG frmAgregarIMG = new frmAgregarIMG();
                frmAgregarIMG.ShowDialog();
            }
        }

        internal void recibirDatos(List<Imagen> listaImagen)
        {
            
            //articulo2.Imagenes = listaImagen;   
        }
    }
}

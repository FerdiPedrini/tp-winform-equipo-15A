﻿using Dominio;
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
            ArticuloService articuloService = new ArticuloService();
            ImagenService imagenService = new ImagenService();
            Articulo articulo = new Articulo();
            Imagen imagen = new Imagen();

            decimal precio;
            bool esPrecioValido = decimal.TryParse(textPrecio.Text, out precio) && precio >= 0;

            try
            {
             
                if (!ValidarCamposObligatorios())
                {
                    MessageBox.Show("Todos los campos son obligatorios y no pueden contener solo espacios.");
                    return;
                }

                if (!esPrecioValido)
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }

            
                articulo.CodigoArticulo = textCodigo.Text.Trim();
                articulo.Nombre = textNombre.Text.Trim();
                articulo.Descripcion = txtDescripcion.Text.Trim();
                articulo.Precio = precio;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Imagenes = MemoriaArticulo.Instance().Articulo.Imagenes;

              
                if (modificar)
                {
                    articuloService.modificar(articulo);
                    MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
                }
                else
                {
                    int idArt = articuloService.agregarProducto(articulo);
                    MessageBox.Show("PRODUCTO AGREGADO CON ÉXITO");
                    MemoriaArticulo.Instance().ReinicarMemoria();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

       
        private bool ValidarCamposObligatorios()
        {
            return !string.IsNullOrWhiteSpace(textCodigo.Text) &&
                   !string.IsNullOrWhiteSpace(textNombre.Text) &&
                   !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                   cbMarca.SelectedItem != null &&
                   cbCategoria.SelectedItem != null;
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

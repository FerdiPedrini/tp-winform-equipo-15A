using System;
using System.Collections;
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
        private int index = 0;

        public Mercado()
        {
            InitializeComponent();

        }

        private void MercadoGen_Load(object sender, EventArgs e)
        {

            cargaDataGrip();
            cbCampo.Items.Add("Codigo");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Descripcion");


        }
        public void cargaDataGrip()
        {

            ArticuloService articuloService = new ArticuloService();

            listaArticulos = articuloService.listar();
            dgvListaProd.DataSource = listaArticulos;
            ocultarColumnas();
            cargarImagen(listaArticulos[0].FirstImage());
        }

        private void dgvListaProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaProd.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.FirstImage());
            }

        }
        private void cargarImagen(string Urlimagen)
        {
            try
            {

                pbxArt.Load(Urlimagen);

                return;

            }
            catch (Exception)
            {
                pbxArt.Load("https://img.freepik.com/free-vector/funny-error-404-background-design_1167-219.jpg?t=st=1725827418~exp=1725831018~hmac=54590de3abb1e78d752a2b192ee5f3553e873955a510b935d7dd33c8d56a8a18&w=740");
                return;

            }


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
            if (index == 0)
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
                service.EliminarImagenPorId(seleccionado.Id);
                cargaDataGrip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool modificar = true;

            Articulo seleccionado;
            seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;


            FrmAgregarProducto frmmodificar = new FrmAgregarProducto(seleccionado, modificar);

            frmmodificar.ShowDialog();
            cargaDataGrip();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != " ")
            {
                listaFiltrada = listaArticulos.FindAll(y => y.CodigoArticulo.ToUpper().Contains(filtro.ToUpper()) || y.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || y.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvListaProd.DataSource = null;
            dgvListaProd.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void pbxArt_Click(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgvListaProd.CurrentRow.DataBoundItem;
            bool hayFoto = false;
            int cantidad = seleccionado.Imagenes.Count;
            Imagen UrlError = new Imagen();
            UrlError.UrlImagen = "https://st2.depositphotos.com/1560768/6162/i/450/depositphotos_61621057-stock-photo-no-image-available.jpg";
            if (cantidad > 0) 
                {
                    hayFoto = true;
                }

                if (seleccionado.Imagenes.Count < index)
                {
                    index = 0;
                }
                if (hayFoto && index<seleccionado.Imagenes.Count)
                {
                    string segunda_imagen = seleccionado.Imagenes[index].UrlImagen;
                    cargarImagen(segunda_imagen);
                }
                else
                {
                    cargarImagen(UrlError.UrlImagen);
                }
                if (seleccionado.Imagenes.Count > index)
                {
                    index++;

                } else
                {
                    index = 0;
                }

            hayFoto = false;

            }

        private void BtnAgregarCategoriaMarca_Click(object sender, EventArgs e)
        {
            frmModificarMcaCria formModificarMcaCria = new frmModificarMcaCria();
            formModificarMcaCria.ShowDialog();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Codigo")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscarFiltro_Click_1(object sender, EventArgs e)
        {
            ArticuloService service = new ArticuloService();
            try
            {

                if (cbCampo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un criterio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo filtro no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvListaProd.DataSource = service.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargaDataGrip();
        }
    }
    }

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
    public partial class frmModificarMcaCria : Form
    {
        CategoriaService categoriaService { get; set; } = new CategoriaService();
        MarcaService marcaService { get; set; } = new MarcaService();
         List<Categoria> ListaCategoria { get; set; } = new List<Categoria>();
         List<Marca> ListaMarca {  get; set; } =new List<Marca>();   
        Categoria seleccionado { get; set; } = new Categoria();
        Marca seleccionada { get; set; }= new Marca();
        
        public frmModificarMcaCria()
        {   
           
            InitializeComponent();
            
            
        }
        public void cargaDGVmodificarDataGridView()
        {
            CategoriaService categoriaServiceObjeto = new CategoriaService();
            ListaCategoria = categoriaServiceObjeto.listar();
            dgvModificarCria.DataSource = ListaCategoria;
        }

        public void cargaDGVmodificarMarca()
        {
            MarcaService marcaServiceObjeto = new MarcaService();
            ListaMarca= marcaServiceObjeto.listar();
            dgvModificarMca.DataSource = ListaMarca;
        }

        private void frmModificarMcaCria_Load(object sender, EventArgs e)
        {
            cargaDGVmodificarDataGridView();
            cargaDGVmodificarMarca();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string NuevaCategoria = txtAgregarCria.Text.Trim();

            if (string.IsNullOrEmpty(NuevaCategoria))
            {
                MessageBox.Show("Ingrese texto");

            }
            else
            {
                categoriaService.AgregarCategoria(NuevaCategoria);
            }

            cargaDGVmodificarDataGridView();
        }

        private void btnEliminarCria_Click(object sender, EventArgs e)
        {
            categoriaService.EliminarCategoria(seleccionado.Descripcion);
            cargaDGVmodificarDataGridView();
        }

        private void dgvModificarCria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificarCria.CurrentRow != null)
            {
                Categoria seleccionadoEntrante = (Categoria)dgvModificarCria.CurrentRow.DataBoundItem;
                seleccionado = seleccionadoEntrante;
                
            }
        }

        private void btnAgregarMca_Click(object sender, EventArgs e)
        {
            string NuevaMarca=txtAgregarMca.Text.Trim();

            if (string.IsNullOrEmpty(NuevaMarca))
            {
                MessageBox.Show("Ingrese texto");
                   
            } else
            {
                marcaService.AgregarMarca(NuevaMarca);
            }

           
            cargaDGVmodificarMarca();

        }

        private void btnEliminarMca_Click(object sender, EventArgs e)
        {
            marcaService.EliminarMarca(seleccionada.Descripcion);
            cargaDGVmodificarMarca();

        }

        private void dgvModificarMca_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificarMca.CurrentRow != null)
            {
                Marca seleccionadoEntrante = (Marca)dgvModificarMca.CurrentRow.DataBoundItem;
                seleccionada = seleccionadoEntrante;

            }
        }
    }
}

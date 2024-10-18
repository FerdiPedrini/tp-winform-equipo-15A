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
        Articulo articulo { get; set; }=new Articulo();
        CategoriaService categoriaService { get; set; } = new CategoriaService();
        MarcaService marcaService { get; set; } = new MarcaService();
         List<Categoria> ListaCategoria { get; set; } = new List<Categoria>();
        Categoria seleccionado { get; set; } = new Categoria();
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

        private void frmModificarMcaCria_Load(object sender, EventArgs e)
        {
            cargaDGVmodificarDataGridView();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string NuevaCategoria = txtAgregarCria.Text;
            categoriaService.AgregarCategoria(NuevaCategoria);
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
    }
}

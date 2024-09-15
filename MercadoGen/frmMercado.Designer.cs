namespace Mercado
{
    partial class Mercado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mercado));
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.agregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroRapidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMercadoGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(12, 38);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.Size = new System.Drawing.Size(648, 331);
            this.dgvListaProd.TabIndex = 0;
            this.dgvListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProd_CellContentClick);
            this.dgvListaProd.SelectionChanged += new System.EventHandler(this.dgvListaProd_SelectionChanged);
            // 
            // pbxArt
            // 
            this.pbxArt.Location = new System.Drawing.Point(669, 38);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(312, 331);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArt.TabIndex = 1;
            this.pbxArt.TabStop = false;
            // 
            // agregarProducto
            // 
            this.agregarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.agregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarProducto.Location = new System.Drawing.Point(12, 375);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(180, 23);
            this.agregarProducto.TabIndex = 2;
            this.agregarProducto.Text = "Agregar Producto";
            this.agregarProducto.UseVisualStyleBackColor = false;
            this.agregarProducto.Click += new System.EventHandler(this.agregarProducto_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Red;
            this.btnEliminarFisico.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarFisico.Location = new System.Drawing.Point(437, 375);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(180, 23);
            this.btnEliminarFisico.TabIndex = 3;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(226, 375);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem,
            this.aboutMercadoGenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroRapidoToolStripMenuItem,
            this.filtroArticuloToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // filtroRapidoToolStripMenuItem
            // 
            this.filtroRapidoToolStripMenuItem.Name = "filtroRapidoToolStripMenuItem";
            this.filtroRapidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtroRapidoToolStripMenuItem.Text = "Filtro rapido";
            // 
            // filtroArticuloToolStripMenuItem
            // 
            this.filtroArticuloToolStripMenuItem.Name = "filtroArticuloToolStripMenuItem";
            this.filtroArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtroArticuloToolStripMenuItem.Text = "Filtro articulo";
            // 
            // aboutMercadoGenToolStripMenuItem
            // 
            this.aboutMercadoGenToolStripMenuItem.Name = "aboutMercadoGenToolStripMenuItem";
            this.aboutMercadoGenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutMercadoGenToolStripMenuItem.Text = "About Us";
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 433);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.agregarProducto);
            this.Controls.Add(this.pbxArt);
            this.Controls.Add(this.dgvListaProd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1004, 472);
            this.MinimumSize = new System.Drawing.Size(1004, 472);
            this.Name = "Mercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoGen";
            this.Load += new System.EventHandler(this.MercadoGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.PictureBox pbxArt;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroRapidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMercadoGenToolStripMenuItem;
    }
}


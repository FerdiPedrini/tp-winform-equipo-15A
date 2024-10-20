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
            this.agregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.lblClickSiguienteImagen = new System.Windows.Forms.Label();
            this.BtnAgregarCategoriaMarca = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(12, 43);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProd.Size = new System.Drawing.Size(648, 331);
            this.dgvListaProd.TabIndex = 0;
            this.dgvListaProd.SelectionChanged += new System.EventHandler(this.dgvListaProd_SelectionChanged);
            // 
            // agregarProducto
            // 
            this.agregarProducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.agregarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarProducto.Location = new System.Drawing.Point(12, 380);
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
            this.btnEliminarFisico.Location = new System.Drawing.Point(437, 380);
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
            this.btnModificar.Location = new System.Drawing.Point(226, 380);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtro rapido";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(98, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(280, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(394, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(72, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pbxArt
            // 
            this.pbxArt.Location = new System.Drawing.Point(669, 38);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(312, 331);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArt.TabIndex = 1;
            this.pbxArt.TabStop = false;
            this.pbxArt.Click += new System.EventHandler(this.pbxArt_Click);
            // 
            // lblClickSiguienteImagen
            // 
            this.lblClickSiguienteImagen.AutoSize = true;
            this.lblClickSiguienteImagen.Location = new System.Drawing.Point(737, 385);
            this.lblClickSiguienteImagen.Name = "lblClickSiguienteImagen";
            this.lblClickSiguienteImagen.Size = new System.Drawing.Size(193, 13);
            this.lblClickSiguienteImagen.TabIndex = 8;
            this.lblClickSiguienteImagen.Text = "Haga click para ver la siguiente imagen";
            // 
            // BtnAgregarCategoriaMarca
            // 
            this.BtnAgregarCategoriaMarca.Location = new System.Drawing.Point(482, 13);
            this.BtnAgregarCategoriaMarca.Name = "BtnAgregarCategoriaMarca";
            this.BtnAgregarCategoriaMarca.Size = new System.Drawing.Size(155, 23);
            this.BtnAgregarCategoriaMarca.TabIndex = 9;
            this.BtnAgregarCategoriaMarca.Text = "Agregar Marca o Categoria";
            this.BtnAgregarCategoriaMarca.UseVisualStyleBackColor = true;
            this.BtnAgregarCategoriaMarca.Click += new System.EventHandler(this.BtnAgregarCategoriaMarca_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(21, 432);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(79, 424);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 11;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(223, 432);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(281, 424);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 13;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(425, 432);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroAvanzado.TabIndex = 14;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(483, 425);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.Location = new System.Drawing.Point(606, 422);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFiltro.TabIndex = 16;
            this.btnBuscarFiltro.Text = "Buscar";
            this.btnBuscarFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.btnBuscarFiltro_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(687, 422);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refrescar lista";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 471);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBuscarFiltro);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.BtnAgregarCategoriaMarca);
            this.Controls.Add(this.lblClickSiguienteImagen);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.agregarProducto);
            this.Controls.Add(this.pbxArt);
            this.Controls.Add(this.dgvListaProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1004, 510);
            this.MinimumSize = new System.Drawing.Size(1004, 472);
            this.Name = "Mercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoGen";
            this.Load += new System.EventHandler(this.MercadoGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox pbxArt;
        private System.Windows.Forms.Label lblClickSiguienteImagen;
        private System.Windows.Forms.Button BtnAgregarCategoriaMarca;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscarFiltro;
        private System.Windows.Forms.Button btnRefresh;
    }
}


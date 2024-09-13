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
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.agregarProducto = new System.Windows.Forms.Button();
            this.btnEminarFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(0, 0);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.Size = new System.Drawing.Size(578, 331);
            this.dgvListaProd.TabIndex = 0;
            this.dgvListaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProd_CellContentClick);
            this.dgvListaProd.SelectionChanged += new System.EventHandler(this.dgvListaProd_SelectionChanged);
            // 
            // pbxArt
            // 
            this.pbxArt.Location = new System.Drawing.Point(584, 0);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(312, 331);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArt.TabIndex = 1;
            this.pbxArt.TabStop = false;
            // 
            // agregarProducto
            // 
            this.agregarProducto.Location = new System.Drawing.Point(12, 355);
            this.agregarProducto.Name = "agregarProducto";
            this.agregarProducto.Size = new System.Drawing.Size(180, 23);
            this.agregarProducto.TabIndex = 2;
            this.agregarProducto.Text = "Agregar Producto";
            this.agregarProducto.UseVisualStyleBackColor = true;
            this.agregarProducto.Click += new System.EventHandler(this.agregarProducto_Click);
            // 
            // btnEminarFisico
            // 
            this.btnEminarFisico.Location = new System.Drawing.Point(391, 355);
            this.btnEminarFisico.Name = "btnEminarFisico";
            this.btnEminarFisico.Size = new System.Drawing.Size(154, 23);
            this.btnEminarFisico.TabIndex = 3;
            this.btnEminarFisico.Text = "button1";
            this.btnEminarFisico.UseVisualStyleBackColor = true;
            this.btnEminarFisico.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 410);
            this.Controls.Add(this.btnEminarFisico);
            this.Controls.Add(this.agregarProducto);
            this.Controls.Add(this.pbxArt);
            this.Controls.Add(this.dgvListaProd);
            this.Name = "Mercado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MercadoGen";
            this.Load += new System.EventHandler(this.MercadoGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.PictureBox pbxArt;
        private System.Windows.Forms.Button agregarProducto;
        private System.Windows.Forms.Button btnEminarFisico;
    }
}


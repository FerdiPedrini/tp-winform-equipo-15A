namespace Mercado
{
    partial class frmModificarMcaCria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminarCria = new System.Windows.Forms.Button();
            this.lblModEliminar = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvModificarCria = new System.Windows.Forms.DataGridView();
            this.txtAgregarCria = new System.Windows.Forms.TextBox();
            this.txtAgregarMca = new System.Windows.Forms.TextBox();
            this.lblAgregarMarca = new System.Windows.Forms.Label();
            this.dgvModificarMca = new System.Windows.Forms.DataGridView();
            this.btnEliminarMca = new System.Windows.Forms.Button();
            this.btnAgregarMca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarCria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarMca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCria
            // 
            this.btnEliminarCria.Location = new System.Drawing.Point(394, 215);
            this.btnEliminarCria.Name = "btnEliminarCria";
            this.btnEliminarCria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCria.TabIndex = 0;
            this.btnEliminarCria.Text = "Eliminar";
            this.btnEliminarCria.UseVisualStyleBackColor = true;
            this.btnEliminarCria.Click += new System.EventHandler(this.btnEliminarCria_Click);
            // 
            // lblModEliminar
            // 
            this.lblModEliminar.AutoSize = true;
            this.lblModEliminar.Location = new System.Drawing.Point(50, 26);
            this.lblModEliminar.Name = "lblModEliminar";
            this.lblModEliminar.Size = new System.Drawing.Size(0, 13);
            this.lblModEliminar.TabIndex = 1;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(24, 134);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(127, 23);
            this.btnAgregarCategoria.TabIndex = 4;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese la categoria a cambiar, agregar o eliminar";
            // 
            // dgvModificarCria
            // 
            this.dgvModificarCria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarCria.Location = new System.Drawing.Point(168, 12);
            this.dgvModificarCria.Name = "dgvModificarCria";
            this.dgvModificarCria.Size = new System.Drawing.Size(301, 197);
            this.dgvModificarCria.TabIndex = 6;
            this.dgvModificarCria.SelectionChanged += new System.EventHandler(this.dgvModificarCria_SelectionChanged);
            // 
            // txtAgregarCria
            // 
            this.txtAgregarCria.Location = new System.Drawing.Point(13, 88);
            this.txtAgregarCria.Name = "txtAgregarCria";
            this.txtAgregarCria.Size = new System.Drawing.Size(149, 20);
            this.txtAgregarCria.TabIndex = 7;
            // 
            // txtAgregarMca
            // 
            this.txtAgregarMca.Location = new System.Drawing.Point(13, 325);
            this.txtAgregarMca.Name = "txtAgregarMca";
            this.txtAgregarMca.Size = new System.Drawing.Size(140, 20);
            this.txtAgregarMca.TabIndex = 8;
            // 
            // lblAgregarMarca
            // 
            this.lblAgregarMarca.Location = new System.Drawing.Point(23, 262);
            this.lblAgregarMarca.Name = "lblAgregarMarca";
            this.lblAgregarMarca.Size = new System.Drawing.Size(114, 51);
            this.lblAgregarMarca.TabIndex = 9;
            this.lblAgregarMarca.Text = "Ingrese la marca que desea agregar";
            // 
            // dgvModificarMca
            // 
            this.dgvModificarMca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarMca.Location = new System.Drawing.Point(168, 262);
            this.dgvModificarMca.Name = "dgvModificarMca";
            this.dgvModificarMca.Size = new System.Drawing.Size(301, 200);
            this.dgvModificarMca.TabIndex = 10;
            this.dgvModificarMca.SelectionChanged += new System.EventHandler(this.dgvModificarMca_SelectionChanged);
            // 
            // btnEliminarMca
            // 
            this.btnEliminarMca.Location = new System.Drawing.Point(394, 468);
            this.btnEliminarMca.Name = "btnEliminarMca";
            this.btnEliminarMca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMca.TabIndex = 12;
            this.btnEliminarMca.Text = "Eliminar";
            this.btnEliminarMca.UseVisualStyleBackColor = true;
            this.btnEliminarMca.Click += new System.EventHandler(this.btnEliminarMca_Click);
            // 
            // btnAgregarMca
            // 
            this.btnAgregarMca.Location = new System.Drawing.Point(26, 368);
            this.btnAgregarMca.Name = "btnAgregarMca";
            this.btnAgregarMca.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarMca.TabIndex = 13;
            this.btnAgregarMca.Text = "Agregar marca";
            this.btnAgregarMca.UseVisualStyleBackColor = true;
            this.btnAgregarMca.Click += new System.EventHandler(this.btnAgregarMca_Click);
            // 
            // frmModificarMcaCria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 495);
            this.Controls.Add(this.btnAgregarMca);
            this.Controls.Add(this.btnEliminarMca);
            this.Controls.Add(this.dgvModificarMca);
            this.Controls.Add(this.lblAgregarMarca);
            this.Controls.Add(this.txtAgregarMca);
            this.Controls.Add(this.txtAgregarCria);
            this.Controls.Add(this.dgvModificarCria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblModEliminar);
            this.Controls.Add(this.btnEliminarCria);
            this.Name = "frmModificarMcaCria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Marca o Categoria";
            this.Load += new System.EventHandler(this.frmModificarMcaCria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarCria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarMca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCria;
        private System.Windows.Forms.Label lblModEliminar;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvModificarCria;
        private System.Windows.Forms.TextBox txtAgregarCria;
        private System.Windows.Forms.TextBox txtAgregarMca;
        private System.Windows.Forms.Label lblAgregarMarca;
        private System.Windows.Forms.DataGridView dgvModificarMca;
        private System.Windows.Forms.Button btnEliminarMca;
        private System.Windows.Forms.Button btnAgregarMca;
    }
}
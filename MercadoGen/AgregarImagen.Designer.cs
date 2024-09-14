namespace Mercado
{
    partial class frmAgregarImagen
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
            this.dgvListaImagenes = new System.Windows.Forms.DataGridView();
            this.pbxListaImagenes = new System.Windows.Forms.PictureBox();
            this.lblAgregarImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregarURL = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaImagenes
            // 
            this.dgvListaImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaImagenes.Location = new System.Drawing.Point(12, 49);
            this.dgvListaImagenes.Name = "dgvListaImagenes";
            this.dgvListaImagenes.Size = new System.Drawing.Size(453, 246);
            this.dgvListaImagenes.TabIndex = 0;
            this.dgvListaImagenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaImagenes_CellContentClick);
            // 
            // pbxListaImagenes
            // 
            this.pbxListaImagenes.Location = new System.Drawing.Point(506, 49);
            this.pbxListaImagenes.Name = "pbxListaImagenes";
            this.pbxListaImagenes.Size = new System.Drawing.Size(259, 246);
            this.pbxListaImagenes.TabIndex = 1;
            this.pbxListaImagenes.TabStop = false;
            // 
            // lblAgregarImagen
            // 
            this.lblAgregarImagen.AutoSize = true;
            this.lblAgregarImagen.Location = new System.Drawing.Point(27, 13);
            this.lblAgregarImagen.Name = "lblAgregarImagen";
            this.lblAgregarImagen.Size = new System.Drawing.Size(83, 13);
            this.lblAgregarImagen.TabIndex = 2;
            this.lblAgregarImagen.Text = "INGRESE URL:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(117, 13);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(348, 20);
            this.txtUrlImagen.TabIndex = 3;
            // 
            // btnAgregarURL
            // 
            this.btnAgregarURL.Location = new System.Drawing.Point(488, 13);
            this.btnAgregarURL.Name = "btnAgregarURL";
            this.btnAgregarURL.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarURL.TabIndex = 4;
            this.btnAgregarURL.Text = "Agregar";
            this.btnAgregarURL.UseVisualStyleBackColor = true;
            this.btnAgregarURL.Click += new System.EventHandler(this.btnAgregarURL_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(548, 319);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(162, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Cargar Imagen";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(548, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarURL);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblAgregarImagen);
            this.Controls.Add(this.pbxListaImagenes);
            this.Controls.Add(this.dgvListaImagenes);
            this.Name = "frmAgregarImagen";
            this.Text = "AgregarImagen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaImagenes;
        private System.Windows.Forms.PictureBox pbxListaImagenes;
        private System.Windows.Forms.Label lblAgregarImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregarURL;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
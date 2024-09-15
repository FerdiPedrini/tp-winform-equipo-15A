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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgrImgAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaImagenes
            // 
            this.dgvListaImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaImagenes.Location = new System.Drawing.Point(12, 49);
            this.dgvListaImagenes.Name = "dgvListaImagenes";
            this.dgvListaImagenes.Size = new System.Drawing.Size(151, 360);
            this.dgvListaImagenes.TabIndex = 3;
            this.dgvListaImagenes.SelectionChanged += new System.EventHandler(this.dgvListaImagenes_SelectionChanged);
            // 
            // pbxListaImagenes
            // 
            this.pbxListaImagenes.Location = new System.Drawing.Point(185, 49);
            this.pbxListaImagenes.Name = "pbxListaImagenes";
            this.pbxListaImagenes.Size = new System.Drawing.Size(264, 360);
            this.pbxListaImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxListaImagenes.TabIndex = 1;
            this.pbxListaImagenes.TabStop = false;
            // 
            // lblAgregarImagen
            // 
            this.lblAgregarImagen.AutoSize = true;
            this.lblAgregarImagen.Location = new System.Drawing.Point(12, 20);
            this.lblAgregarImagen.Name = "lblAgregarImagen";
            this.lblAgregarImagen.Size = new System.Drawing.Size(83, 13);
            this.lblAgregarImagen.TabIndex = 0;
            this.lblAgregarImagen.Text = "INGRESE URL:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(101, 20);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(348, 20);
            this.txtUrlImagen.TabIndex = 1;
            // 
            // btnAgregarURL
            // 
            this.btnAgregarURL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarURL.Location = new System.Drawing.Point(462, 12);
            this.btnAgregarURL.Name = "btnAgregarURL";
            this.btnAgregarURL.Size = new System.Drawing.Size(105, 33);
            this.btnAgregarURL.TabIndex = 2;
            this.btnAgregarURL.Text = "Cargar Imagenes";
            this.btnAgregarURL.UseVisualStyleBackColor = false;
            this.btnAgregarURL.Click += new System.EventHandler(this.btnCargarIMG_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(468, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgrImgAceptar
            // 
            this.btnAgrImgAceptar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgrImgAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgrImgAceptar.Location = new System.Drawing.Point(468, 326);
            this.btnAgrImgAceptar.Name = "btnAgrImgAceptar";
            this.btnAgrImgAceptar.Size = new System.Drawing.Size(100, 31);
            this.btnAgrImgAceptar.TabIndex = 5;
            this.btnAgrImgAceptar.Text = "Aceptar";
            this.btnAgrImgAceptar.UseVisualStyleBackColor = false;
            this.btnAgrImgAceptar.Click += new System.EventHandler(this.btnAgrImgAceptar_Click);
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 414);
            this.Controls.Add(this.btnAgrImgAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarURL);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblAgregarImagen);
            this.Controls.Add(this.pbxListaImagenes);
            this.Controls.Add(this.dgvListaImagenes);
            this.MaximumSize = new System.Drawing.Size(590, 453);
            this.MinimumSize = new System.Drawing.Size(590, 453);
            this.Name = "frmAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgrImgAceptar;
    }
}
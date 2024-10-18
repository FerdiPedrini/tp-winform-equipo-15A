namespace Mercado
{
    partial class frmModificarImg
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
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.dgvModificarImg = new System.Windows.Forms.DataGridView();
            this.pbxModificarImg = new System.Windows.Forms.PictureBox();
            this.btnModificarImg = new System.Windows.Forms.Button();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.lblListaImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(12, 48);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(141, 23);
            this.btnAgregarImg.TabIndex = 0;
            this.btnAgregarImg.Text = "Agregar nueva imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // dgvModificarImg
            // 
            this.dgvModificarImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarImg.Location = new System.Drawing.Point(8, 283);
            this.dgvModificarImg.Name = "dgvModificarImg";
            this.dgvModificarImg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificarImg.Size = new System.Drawing.Size(422, 116);
            this.dgvModificarImg.TabIndex = 1;
            this.dgvModificarImg.SelectionChanged += new System.EventHandler(this.dgvModificarImg_SelectionChanged);
            // 
            // pbxModificarImg
            // 
            this.pbxModificarImg.Location = new System.Drawing.Point(166, 12);
            this.pbxModificarImg.Name = "pbxModificarImg";
            this.pbxModificarImg.Size = new System.Drawing.Size(264, 265);
            this.pbxModificarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxModificarImg.TabIndex = 2;
            this.pbxModificarImg.TabStop = false;
            // 
            // btnModificarImg
            // 
            this.btnModificarImg.Location = new System.Drawing.Point(12, 99);
            this.btnModificarImg.Name = "btnModificarImg";
            this.btnModificarImg.Size = new System.Drawing.Size(141, 23);
            this.btnModificarImg.TabIndex = 3;
            this.btnModificarImg.Text = "Modificar imagen";
            this.btnModificarImg.UseVisualStyleBackColor = true;
            this.btnModificarImg.Click += new System.EventHandler(this.btnModificarImg_Click);
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(12, 153);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(141, 23);
            this.btnEliminarImg.TabIndex = 4;
            this.btnEliminarImg.Text = "Eliminar imagen";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // lblListaImg
            // 
            this.lblListaImg.AutoSize = true;
            this.lblListaImg.Location = new System.Drawing.Point(47, 253);
            this.lblListaImg.Name = "lblListaImg";
            this.lblListaImg.Size = new System.Drawing.Size(78, 13);
            this.lblListaImg.TabIndex = 5;
            this.lblListaImg.Text = "Lista Imagenes";
            // 
            // frmModificarImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 404);
            this.Controls.Add(this.lblListaImg);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnModificarImg);
            this.Controls.Add(this.pbxModificarImg);
            this.Controls.Add(this.dgvModificarImg);
            this.Controls.Add(this.btnAgregarImg);
            this.Name = "frmModificarImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Imagenes";
            this.Load += new System.EventHandler(this.frmModificarImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.DataGridView dgvModificarImg;
        private System.Windows.Forms.PictureBox pbxModificarImg;
        private System.Windows.Forms.Button btnModificarImg;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.Label lblListaImg;
    }
}
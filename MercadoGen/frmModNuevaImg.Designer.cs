namespace Mercado
{
    partial class frmModNuevaImg
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrlNuevaIMG = new System.Windows.Forms.TextBox();
            this.btnNuevaIMG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUrl.Location = new System.Drawing.Point(29, 32);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(104, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Ingrese URL imagen";
            // 
            // txtUrlNuevaIMG
            // 
            this.txtUrlNuevaIMG.Location = new System.Drawing.Point(32, 64);
            this.txtUrlNuevaIMG.Name = "txtUrlNuevaIMG";
            this.txtUrlNuevaIMG.Size = new System.Drawing.Size(328, 20);
            this.txtUrlNuevaIMG.TabIndex = 1;
            // 
            // btnNuevaIMG
            // 
            this.btnNuevaIMG.Location = new System.Drawing.Point(150, 107);
            this.btnNuevaIMG.Name = "btnNuevaIMG";
            this.btnNuevaIMG.Size = new System.Drawing.Size(191, 23);
            this.btnNuevaIMG.TabIndex = 2;
            this.btnNuevaIMG.Text = "Agregar Nueva Imagen";
            this.btnNuevaIMG.UseVisualStyleBackColor = true;
            this.btnNuevaIMG.Click += new System.EventHandler(this.btnNuevaIMG_Click);
            // 
            // frmModNuevaImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 175);
            this.Controls.Add(this.btnNuevaIMG);
            this.Controls.Add(this.txtUrlNuevaIMG);
            this.Controls.Add(this.lblUrl);
            this.MaximumSize = new System.Drawing.Size(388, 214);
            this.MinimumSize = new System.Drawing.Size(388, 214);
            this.Name = "frmModNuevaImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva imagen";
            this.Load += new System.EventHandler(this.frmModNuevaImg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrlNuevaIMG;
        private System.Windows.Forms.Button btnNuevaIMG;
    }
}
namespace Mercado
{
    partial class frmModEliminarIMG
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
            this.btnModEliminar = new System.Windows.Forms.Button();
            this.lblModEliminar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModEliminar
            // 
            this.btnModEliminar.Location = new System.Drawing.Point(268, 94);
            this.btnModEliminar.Name = "btnModEliminar";
            this.btnModEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnModEliminar.TabIndex = 0;
            this.btnModEliminar.Text = "Eliminar";
            this.btnModEliminar.UseVisualStyleBackColor = true;
            // 
            // lblModEliminar
            // 
            this.lblModEliminar.AutoSize = true;
            this.lblModEliminar.Location = new System.Drawing.Point(50, 26);
            this.lblModEliminar.Name = "lblModEliminar";
            this.lblModEliminar.Size = new System.Drawing.Size(0, 13);
            this.lblModEliminar.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frmModEliminarIMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 175);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblModEliminar);
            this.Controls.Add(this.btnModEliminar);
            this.MaximumSize = new System.Drawing.Size(388, 214);
            this.MinimumSize = new System.Drawing.Size(388, 214);
            this.Name = "frmModEliminarIMG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar imagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModEliminar;
        private System.Windows.Forms.Label lblModEliminar;
        private System.Windows.Forms.TextBox textBox1;
    }
}
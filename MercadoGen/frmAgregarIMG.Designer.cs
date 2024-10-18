namespace Mercado
{
    partial class frmAgregarIMG
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
            this.dgvAgregarImg = new System.Windows.Forms.DataGridView();
            this.pbxAgregarImg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtBoxUrLImg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgregarImg
            // 
            this.dgvAgregarImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarImg.Location = new System.Drawing.Point(6, 60);
            this.dgvAgregarImg.Name = "dgvAgregarImg";
            this.dgvAgregarImg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregarImg.Size = new System.Drawing.Size(476, 210);
            this.dgvAgregarImg.TabIndex = 0;
            this.dgvAgregarImg.SelectionChanged += new System.EventHandler(this.dgvAgregarImg_SelectionChanged);
            // 
            // pbxAgregarImg
            // 
            this.pbxAgregarImg.Location = new System.Drawing.Point(488, 60);
            this.pbxAgregarImg.Name = "pbxAgregarImg";
            this.pbxAgregarImg.Size = new System.Drawing.Size(300, 346);
            this.pbxAgregarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarImg.TabIndex = 1;
            this.pbxAgregarImg.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(541, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(21, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(55, 23);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(70, 13);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "Ingrese URL:";
            // 
            // txtBoxUrLImg
            // 
            this.txtBoxUrLImg.Location = new System.Drawing.Point(131, 20);
            this.txtBoxUrLImg.Name = "txtBoxUrLImg";
            this.txtBoxUrLImg.Size = new System.Drawing.Size(376, 20);
            this.txtBoxUrLImg.TabIndex = 5;
            // 
            // frmAgregarIMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxUrLImg);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxAgregarImg);
            this.Controls.Add(this.dgvAgregarImg);
            this.Name = "frmAgregarIMG";
            this.Text = "frmAgregarIMG";
            this.Load += new System.EventHandler(this.frmAgregarIMG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgregarImg;
        private System.Windows.Forms.PictureBox pbxAgregarImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtBoxUrLImg;
    }
}
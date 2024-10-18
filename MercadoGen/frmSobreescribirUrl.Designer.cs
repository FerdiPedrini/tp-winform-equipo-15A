namespace Mercado
{
    partial class frmSobreescribirUrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSobreescribirUrl = new System.Windows.Forms.TextBox();
            this.btnSobreescribirUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva URl:";
            // 
            // txtSobreescribirUrl
            // 
            this.txtSobreescribirUrl.Location = new System.Drawing.Point(24, 79);
            this.txtSobreescribirUrl.Name = "txtSobreescribirUrl";
            this.txtSobreescribirUrl.Size = new System.Drawing.Size(301, 20);
            this.txtSobreescribirUrl.TabIndex = 1;
            // 
            // btnSobreescribirUrl
            // 
            this.btnSobreescribirUrl.Location = new System.Drawing.Point(165, 105);
            this.btnSobreescribirUrl.Name = "btnSobreescribirUrl";
            this.btnSobreescribirUrl.Size = new System.Drawing.Size(160, 23);
            this.btnSobreescribirUrl.TabIndex = 2;
            this.btnSobreescribirUrl.Text = "Sobreescribir URL imagen";
            this.btnSobreescribirUrl.UseVisualStyleBackColor = true;
            this.btnSobreescribirUrl.Click += new System.EventHandler(this.btnSobreescribirUrl_Click);
            // 
            // frmSobreescribirUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 175);
            this.Controls.Add(this.btnSobreescribirUrl);
            this.Controls.Add(this.txtSobreescribirUrl);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(388, 214);
            this.MinimumSize = new System.Drawing.Size(388, 214);
            this.Name = "frmSobreescribirUrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSobreescribirUrl;
        private System.Windows.Forms.Button btnSobreescribirUrl;
    }
}
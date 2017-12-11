namespace Exo6
{
    partial class frmAjoutStagiaire
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
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbStagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(408, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "O&K";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Annuler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAjoutStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAjoutStagiaire";
            this.ShowInTaskbar = false;
            this.Text = "Ajouter un stagiaire";
            this.Load += new System.EventHandler(this.frmAjoutStagiaire_Load);
            this.Controls.SetChildIndex(this.gbStagiaire, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.gbStagiaire.ResumeLayout(false);
            this.gbStagiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}

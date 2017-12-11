namespace Exo6
{
    partial class frmLireStagiaire
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
            this.gbSeDeplacer = new System.Windows.Forms.GroupBox();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNoStagiaire = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbStagiaire.SuspendLayout();
            this.gbSeDeplacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSeDeplacer
            // 
            this.gbSeDeplacer.Controls.Add(this.button1);
            this.gbSeDeplacer.Controls.Add(this.btnSuivant);
            this.gbSeDeplacer.Controls.Add(this.btnPrecedent);
            this.gbSeDeplacer.Controls.Add(this.btnPremier);
            this.gbSeDeplacer.Controls.Add(this.lblNoStagiaire);
            this.gbSeDeplacer.Location = new System.Drawing.Point(167, 282);
            this.gbSeDeplacer.Name = "gbSeDeplacer";
            this.gbSeDeplacer.Size = new System.Drawing.Size(418, 70);
            this.gbSeDeplacer.TabIndex = 7;
            this.gbSeDeplacer.TabStop = false;
            this.gbSeDeplacer.Text = "Se déplacer";
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(6, 28);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(90, 25);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<< Pre&mier";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(109, 28);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(90, 25);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "<&Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(217, 28);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(90, 25);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">&Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>&Dernier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNoStagiaire
            // 
            this.lblNoStagiaire.AutoSize = true;
            this.lblNoStagiaire.Font = new System.Drawing.Font("Cooper Black", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoStagiaire.ForeColor = System.Drawing.Color.Red;
            this.lblNoStagiaire.Location = new System.Drawing.Point(14, 29);
            this.lblNoStagiaire.Name = "lblNoStagiaire";
            this.lblNoStagiaire.Size = new System.Drawing.Size(390, 24);
            this.lblNoStagiaire.TabIndex = 8;
            this.lblNoStagiaire.Text = "Il n\'y a aucun stagiaire actuellement";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(384, 373);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(503, 373);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmLireStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbSeDeplacer);
            this.Name = "frmLireStagiaire";
            this.Text = "Afficher un stagiaire";
            this.Load += new System.EventHandler(this.frmLireStagiaire_Load);
            this.Controls.SetChildIndex(this.gbStagiaire, 0);
            this.Controls.SetChildIndex(this.gbSeDeplacer, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.btnQuitter, 0);
            this.gbStagiaire.ResumeLayout(false);
            this.gbStagiaire.PerformLayout();
            this.gbSeDeplacer.ResumeLayout(false);
            this.gbSeDeplacer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox gbSeDeplacer;
        protected System.Windows.Forms.Button btnPremier;
        protected System.Windows.Forms.Button btnPrecedent;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button btnSuivant;
        protected System.Windows.Forms.Label lblNoStagiaire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnQuitter;
    }
}

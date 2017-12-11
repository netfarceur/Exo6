namespace Exo6
{
    partial class Stagiaire
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
            this.lblnumOsia = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prénom = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStagiaire = new System.Windows.Forms.GroupBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtOSIA = new System.Windows.Forms.TextBox();
            this.gbStagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumOsia
            // 
            this.lblnumOsia.AutoSize = true;
            this.lblnumOsia.Location = new System.Drawing.Point(99, 52);
            this.lblnumOsia.Name = "lblnumOsia";
            this.lblnumOsia.Size = new System.Drawing.Size(82, 15);
            this.lblnumOsia.TabIndex = 0;
            this.lblnumOsia.Text = "Numéro OSIA";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(102, 82);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(37, 15);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom:";
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(102, 113);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(54, 15);
            this.Prénom.TabIndex = 2;
            this.Prénom.Text = "Prénom:";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(105, 153);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(54, 15);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "Adresse:";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(108, 185);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(52, 19);
            this.Ville.TabIndex = 4;
            this.Ville.Text = "Ville:";
            this.Ville.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code Postale:";
            // 
            // gbStagiaire
            // 
            this.gbStagiaire.Controls.Add(this.txtCodePostal);
            this.gbStagiaire.Controls.Add(this.txtVille);
            this.gbStagiaire.Controls.Add(this.txtAdresse);
            this.gbStagiaire.Controls.Add(this.txtPrenom);
            this.gbStagiaire.Controls.Add(this.txtNom);
            this.gbStagiaire.Controls.Add(this.txtOSIA);
            this.gbStagiaire.Location = new System.Drawing.Point(83, 28);
            this.gbStagiaire.Name = "gbStagiaire";
            this.gbStagiaire.Size = new System.Drawing.Size(502, 239);
            this.gbStagiaire.TabIndex = 6;
            this.gbStagiaire.TabStop = false;
            this.gbStagiaire.Text = "Stagiaire";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(204, 197);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(138, 20);
            this.txtCodePostal.TabIndex = 5;
            this.txtCodePostal.TextChanged += new System.EventHandler(this.codePostaleStagiaire_TextChanged);
            // 
            // txtVille
            // 
            this.txtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVille.Location = new System.Drawing.Point(204, 157);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(261, 20);
            this.txtVille.TabIndex = 4;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(204, 120);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(261, 20);
            this.txtAdresse.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPrenom.Location = new System.Drawing.Point(204, 85);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(261, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(204, 54);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(261, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtOSIA
            // 
            this.txtOSIA.Location = new System.Drawing.Point(204, 24);
            this.txtOSIA.Name = "txtOSIA";
            this.txtOSIA.Size = new System.Drawing.Size(261, 20);
            this.txtOSIA.TabIndex = 0;
            // 
            // Stagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.lblnumOsia);
            this.Controls.Add(this.gbStagiaire);
            this.Name = "Stagiaire";
            this.Text = "Stagiaire Parent";
            this.gbStagiaire.ResumeLayout(false);
            this.gbStagiaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumOsia;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.CheckBox Ville;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtCodePostal;
        protected System.Windows.Forms.TextBox txtVille;
        protected System.Windows.Forms.TextBox txtAdresse;
        protected System.Windows.Forms.TextBox txtPrenom;
        protected System.Windows.Forms.TextBox txtNom;
        protected System.Windows.Forms.TextBox txtOSIA;
        protected System.Windows.Forms.GroupBox gbStagiaire;
    }
}
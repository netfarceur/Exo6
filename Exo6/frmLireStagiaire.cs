using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmLireStagiaire : Exo6.Stagiaire
    {
        private Int32 istag;

        private void frmLireStagiaire_Load(object sender, EventArgs e)
        {
            /*
            * initialisation du form
            * pour afficher le label "pas de stagiaires"
            */
            base.gbStagiaire.Visible = false;
            this.lblNoStagiaire.Visible = true;
            this.gbSeDeplacer.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Exo6
{
    public partial class Stagiaire : Form
    {
        
        public Stagiaire()
        {
            InitializeComponent();
        }

        void codePostaleStagiaire_TextChanged(string input)
        {
            ///<summary>
            ///Test de la longueur du code postal
            ///</summary>
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"^\d{5}$", options);
            bool isMatch = regex.IsMatch(input);

            if (isMatch)
                return;
            else
                MessageBox.Show("erreur de saisie");
                return;

        }

        private void codePostaleStagiaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
    }
}



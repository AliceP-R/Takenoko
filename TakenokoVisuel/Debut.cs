using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakenokoVisuel
{
    public partial class Debut : Form
    {
        private int nbreJoueur = 0; 
        public Debut()
        {
            InitializeComponent();
            groupeBoxNomJoueur.Hide();
            DebutPartie.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nbreJoueur = 2; 
            groupeBoxNomJoueur.Show();
            NomJoueur3.Hide();
            labelNomJoueur3.Hide();
            labelNomJoueur4.Hide(); 
            NomJoueur4.Hide();
            DebutPartie.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nbreJoueur = 3; 
            groupeBoxNomJoueur.Show();
            NomJoueur3.Show();
            labelNomJoueur3.Show(); 
            NomJoueur4.Hide();
            labelNomJoueur4.Hide(); 
            DebutPartie.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nbreJoueur = 4; 
            groupeBoxNomJoueur.Show();
            NomJoueur3.Show();
            labelNomJoueur3.Show(); 
            NomJoueur4.Show();
            labelNomJoueur4.Show(); 
            DebutPartie.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] joueur = new string[nbreJoueur];

            
            joueur[0] = NomJoueur1.Text;
            joueur[1] = NomJoueur2.Text;

            if (nbreJoueur == 3)
                joueur[2] = NomJoueur3.Text;
            if (nbreJoueur == 4)
                joueur[3] = NomJoueur4.Text; 

            foreach(string nom in joueur)
            {
                if (nom == "")
                {
                    MessageBox.Show("Vous avez oublié un nom.");
                    return;
                }
            }
            
            Bambouseraie b = new Bambouseraie(joueur, nbreJoueur);
            b.Show();
            this.Hide(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }
    }
}

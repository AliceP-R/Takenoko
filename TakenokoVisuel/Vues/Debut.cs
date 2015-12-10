using System;
using System.Collections;
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
        private ArrayList joueurs; 
        public Debut()
        {
            InitializeComponent();
            groupeBoxNomJoueur.Hide();
            DebutPartie.Hide();
            joueurs = new ArrayList(); 
        }

        private void joueur2_Click(object sender, EventArgs e)
        {
            nbreJoueur = 2; 
            groupeBoxNomJoueur.Show();
            labelNomJoueur3.Hide();
            NomJoueur3.Hide();
            labelNomJoueur4.Hide(); 
            NomJoueur4.Hide();
            DebutPartie.Show(); 
        }

        private void joueur3_Click(object sender, EventArgs e)
        {
            nbreJoueur = 3; 
            groupeBoxNomJoueur.Show();
            NomJoueur3.Show();
            labelNomJoueur3.Show(); 
            NomJoueur4.Hide();
            labelNomJoueur4.Hide(); 
            DebutPartie.Show(); 
        }

        private void joueur4_Click(object sender, EventArgs e)
        {
            nbreJoueur = 4; 
            groupeBoxNomJoueur.Show();
            NomJoueur3.Show();
            labelNomJoueur3.Show(); 
            NomJoueur4.Show();
            labelNomJoueur4.Show(); 
            DebutPartie.Show(); 
        }

        private void debut_Click(object sender, EventArgs e)
        {
            if (joueurs.Count != nbreJoueur)
            {
                MessageBox.Show("Vous avez oublié un nom.");
                return;
            }
            
            Bambouseraie b = new Bambouseraie(joueurs, nbreJoueur);
            b.Show();
            this.Hide(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        private void NomJoueur1_Leave(object sender, EventArgs e)
        {
            string nom = NomJoueur1.Text;
            if (joueurs.Contains(nom))
                MessageBox.Show("Un joueur avec ce nom existe déjà.");
            else if (nom.Equals(""))
                MessageBox.Show("Ce nom n'est pas valide. Veuillez entrer au moins 1 caractère."); 
            else
                joueurs.Add(new Joueur(nom)); 
        }

        private void NomJoueur2_Leave(object sender, EventArgs e)
        {
            string nom = NomJoueur2.Text;
            if (joueurs.Contains(nom))
                MessageBox.Show("Un joueur avec ce nom existe déjà.");
            else if (nom.Equals(""))
                MessageBox.Show("Ce nom n'est pas valide. Veuillez entrer au moins 1 caractère.");
            else
                joueurs.Add(new Joueur(nom)); 
        }

        private void NomJoueur3_Leave(object sender, EventArgs e)
        {
            string nom = NomJoueur3.Text;
            if (joueurs.Contains(nom))
                MessageBox.Show("Un joueur avec ce nom existe déjà.");
            else if (nom.Equals(""))
                MessageBox.Show("Ce nom n'est pas valide. Veuillez entrer au moins 1 caractère.");
            else
                joueurs.Add(new Joueur(nom)); 
        }

        private void NomJoueur4_Leave(object sender, EventArgs e)
        {
            string nom = NomJoueur4.Text;
            if (joueurs.Contains(nom))
                MessageBox.Show("Un joueur avec ce nom existe déjà.");
            else if (nom.Equals(""))
                MessageBox.Show("Ce nom n'est pas valide. Veuillez entrer au moins 1 caractère.");
            else
                joueurs.Add(new Joueur(nom)); 
        }
    }
}

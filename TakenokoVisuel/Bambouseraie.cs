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
using System.Windows.Input;


namespace TakenokoVisuel
{
    public partial class Bambouseraie : Form
    {

        private Parcelle[,] tableauParcelle = new Parcelle[10,10];
        private int tailleParcelle = 49; 
        public int nbrejoueur;
        Joueur[] listeJoueur;
        private List<Carte> piocheP;
        List<Carte> pioche
        {
            get
            {
                return piocheP;
            }
            set
            {
                piocheP = value;
            }
        }

        int jEnCours;
        private bool placer_parcelle = false; 

        public Graphics baseDessin;
        private Color choixCouleur; 

        public Bambouseraie(ArrayList joueurs, int nbrej)
        {

            #region Initialisation du tableau contenant les parcelles
            int xParcelle = 0;
            int yParcelle = 0;
            int ligne = 0;
            int colonne = 0;

            for (xParcelle = 0; xParcelle < 450; xParcelle += 50)
            {
                for (yParcelle = 0; yParcelle < 450; yParcelle += 50)
                {
                    tableauParcelle[ligne, colonne] = new Parcelle(xParcelle, yParcelle, tailleParcelle);
                    ligne++;
                }
                ligne = 0;
                colonne++;
            }
            #endregion 


            InitializeComponent();

            #region Initialisation affichage objectif
            Obj1.Hide();
            Obj2.Hide();
            Obj3.Hide();
            Obj4.Hide();
            Obj5.Hide();
            #endregion

            #region Intialisation de la pioche
            int maxPioche = nbrej * 6 + 10;
            piocheP = new List<Carte>();
            Random rand = new Random();
            for (int i = 0; i < maxPioche; i++)
            { 
                pioche.Add(new Carte(rand.Next(1,4)));
            }
            Console.WriteLine(pioche.ToString()); 
            #endregion 


            #region Initialisation du tableau des joueurs
            nbrejoueur = nbrej;
            listeJoueur = (Joueur[])joueurs.ToArray(typeof(Joueur)); 
            jEnCours = 0;
            #endregion 

            baseDessin = zoneJardin.CreateGraphics();

            #region Définition de l'étang 
            tableauParcelle[4, 4].etang = true;
            tableauParcelle[4, 4].choixCouleur(Color.AliceBlue); 
            this.tracer_parcelle(tableauParcelle[4, 4]); 
            this.Refresh();
            #endregion

        }

        private void tracer_parcelle(Parcelle p)
        {
            if (p.afficher == false && p.etang != true)
            {
                baseDessin.DrawRectangle(p.contour, p.dimension);
                baseDessin.FillRectangle(p.remplissage, p.dimension);
                p.afficher = true;
            }
        }

        private void trouver_parcelle(MouseEventArgs souris, Color couleur)
        {

            for (int ligne = 0; ligne < 9; ligne++)
            {
                for (int colonne = 0; colonne < 9; colonne++)
                {
                    if (tableauParcelle[ligne, colonne].curseur_dedans(souris.X, souris.Y, tailleParcelle) == true)
                    {
                        Parcelle p = tableauParcelle[ligne, colonne];
                        p.choixCouleur(couleur); 
                        tracer_parcelle(p); 
                    }
                }
            }
        }

        // Affiche le nom du joueur qui doit faire effectuer son tour ainsi que ses objectifs 
        public void Tour()
        {
            Obj2.Hide();
            Obj3.Hide();
            Obj1.Hide();
            Obj4.Hide();
            Obj5.Hide();

            MessageBox.Show("C'est à " + listeJoueur[jEnCours].nom + " de jouer.");

            if (listeJoueur[jEnCours].main.Count() >= 1)
            {
                Obj1.Text = listeJoueur[jEnCours].main[0].objectif;
                Obj1.Show();
            }
            if (listeJoueur[jEnCours].main.Count() >= 2)
            {
                Obj2.Text = listeJoueur[jEnCours].main[1].objectif;
                Obj2.Show();
            }
            if (listeJoueur[jEnCours].main.Count() >= 3)
            {
                Obj3.Text = listeJoueur[jEnCours].main[2].objectif;
                Obj3.Show();
            }
            if (listeJoueur[jEnCours].main.Count() >= 4)
            {
                Obj4.Text = listeJoueur[jEnCours].main[3].objectif;
                Obj4.Show();
            }
            if (listeJoueur[jEnCours].main.Count() >= 5)
            {
                Obj5.Text = listeJoueur[jEnCours].main[4].objectif;
                Obj5.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATTENTION\nvous quitter définitivement la partie."); 
            System.Environment.Exit(0); 
        }

        private void piocheCarte_Click(object sender, EventArgs e)
        {
            if (piocheP.Count() > 0)
            {
                if (listeJoueur[jEnCours].main.Count < 5)
                {
                    listeJoueur[jEnCours].piocher(piocheP);
                    if (jEnCours != listeJoueur.Count()-1)
                        jEnCours++;
                    else
                        jEnCours = 0;
                    Tour();
                }
                else
                    MessageBox.Show("Vous avez déjà 5 objectifs.\nChoississez une autre action.");
            }
            else
                MessageBox.Show("Il n'y a plus de carte disponible.\nChoississez une autre action."); 
        }

        private void piocheParcelle_Click(object sender, EventArgs e)
        {
            placer_parcelle = true;
            choixCouleurParcelle.Show(); 
        }

        private void zoneJardin_Click(object sender, MouseEventArgs e)
        {

            int xsouris = e.X;
            int ysouris = e.Y; 

            if (placer_parcelle == true)
            {
                trouver_parcelle(e, choixCouleur);
                placer_parcelle = false; 
                if (jEnCours != listeJoueur.Count() - 1)
                    jEnCours++;
                else
                    jEnCours = 0;
                Tour();
            }
        }

        private void ColorGreen_Click(object sender, EventArgs e)
        {
            choixCouleur = Color.Green;
            choixCouleurParcelle.Hide(); 
        }

        private void ColorPink_Click(object sender, EventArgs e)
        {
            choixCouleur = Color.Pink;
            choixCouleurParcelle.Hide(); 
        }

        private void ColorYellow_Click(object sender, EventArgs e)
        {
            choixCouleur = Color.Yellow;
            choixCouleurParcelle.Hide(); 
        }
    }
}

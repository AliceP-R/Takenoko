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
    enum Action
    {
        Indefinie,
        Parcelle, 
        Arroser, 
        Piocher, 
        BougerPanda, 
        BougerJardinier
    }

    public partial class Bambouseraie : Form
    {

        private Parcelle[,] tableauParcelle = new Parcelle[10,10];
        private int tailleParcelle = 49; 

        public int nbrejoueur;
        Joueur[] listeJoueur;
        int jEnCours;
        private Action act; 

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
        
        public Graphics baseDessin;
        private Pen contour;
        SolidBrush texte;
        Font police;
        StringFormat formatTexte;
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
                    tableauParcelle[ligne, colonne] = new Parcelle(ligne, colonne, xParcelle, yParcelle, tailleParcelle);
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
            #endregion 


            #region Initialisation du tableau des joueurs
            nbrejoueur = nbrej;
            listeJoueur = (Joueur[])joueurs.ToArray(typeof(Joueur));
            foreach (Joueur j in listeJoueur)
            {
                j.piocher(pioche); 
            }
            jEnCours = 0;
            #endregion 

            baseDessin = zoneJardin.CreateGraphics();

            #region Définition de l'étang 
            tableauParcelle[4, 4].etang = true;
            tableauParcelle[4, 4].choixCouleur(Color.Blue); 
            #endregion

            #region Initialisation des pinceaux
            contour = new Pen(Color.Black);
            texte = new SolidBrush(Color.Black);
            police = new Font("Arial", 20);
            formatTexte = new StringFormat();
            formatTexte.Alignment = StringAlignment.Center;
            formatTexte.LineAlignment = StringAlignment.Center;
            #endregion 

        }


        #region Gestion Joueur
        // Affiche le nom du joueur qui doit faire effectuer son tour ainsi que ses objectifs 
        public void Tour()
        {
            Obj2.Hide();
            Obj3.Hide();
            Obj1.Hide();
            Obj4.Hide();
            Obj5.Hide();

            act = Action.Indefinie; 
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
        private void changementJoueur()
        {
            if (jEnCours != listeJoueur.Count() - 1)
                jEnCours++;
            else
                jEnCours = 0;
            Tour();
        }
        #endregion


        private void quitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATTENTION\nvous quitter définitivement la partie."); 
            System.Environment.Exit(0); 
        }

        private void piocherCarte_Click(object sender, EventArgs e)
        {
            if (piocheP.Count() > 0)
            {
                if (listeJoueur[jEnCours].main.Count < 5)
                {
                    listeJoueur[jEnCours].piocher(piocheP);
                    changementJoueur(); 
                }
                else
                    MessageBox.Show("Vous avez déjà 5 objectifs.\nChoississez une autre action.");
            }
            else
                MessageBox.Show("Il n'y a plus de carte disponible.\nChoississez une autre action."); 
        }

        private void piocherParcelle_Click(object sender, EventArgs e)
        {
            act = Action.Parcelle; 
            choixCouleurParcelle.Show(); 
        }
        private void tracer_parcelle(Parcelle p)
        {
            if (p.afficher == false && p.etang != true)
            {
                // contour du rectangle (noir)
                baseDessin.DrawRectangle(contour, p.dimension);
                // intérieur du rectangle (vert/rose/jaune)
                baseDessin.FillRectangle(p.remplissage, p.dimension);
                // nbre de bambou sur cette parcelle
                baseDessin.DrawString(p.nbreBambou.ToString(), police, texte, p.dimension, formatTexte);
                p.afficher = true;
            }
        }

        private bool tracer_parcelle(Parcelle p, Color choix)
        {
            if (p.afficher == false && p.etang != true)
            {
                p.choixCouleur(choix);
                // contour du rectangle (noir)
                baseDessin.DrawRectangle(contour, p.dimension);
                // intérieur du rectangle (vert/rose/jaune)
                baseDessin.FillRectangle(p.remplissage, p.dimension);
                // nbre de bambou sur cette parcelle
                baseDessin.DrawString(p.nbreBambou.ToString(), police, texte, p.dimension, formatTexte);
                p.afficher = true;
                return true;
            }

            return false;
        }

        private bool trouver_liaison(Parcelle p)
        {
            bool lien = true;
            int lignep = p.ligne;
            int colonnep = p.colonne;

            #region Parcelle adjacente haute
            Parcelle haut; 
            if (lignep == 0)
                haut = tableauParcelle[lignep, colonnep];
            else
                haut = tableauParcelle[lignep - 1, colonnep];
            #endregion 

            #region Parcelle adjacente basse
            Parcelle bas;
            if (lignep == 9)
                bas = tableauParcelle[lignep, colonnep];
            else
                bas = tableauParcelle[lignep + 1, colonnep];
            #endregion 

            #region Parcelle adjacente gauche
            Parcelle gauche;
            if (colonnep == 0)
                gauche = tableauParcelle[lignep, colonnep]; 
            else
                gauche = tableauParcelle[lignep, colonnep - 1]; 
            #endregion 

            #region Parcelle adjacente droite
            Parcelle droite;
            if (colonnep == 9)
                droite = tableauParcelle[lignep, colonnep];
            else
                droite = tableauParcelle[lignep, colonnep + 1];
            #endregion 

            if (haut.afficher == false && bas.afficher == false && droite.afficher == false && gauche.afficher == false)
                lien = false; 
            return lien; 
        }

        private Parcelle trouver_parcelle(MouseEventArgs souris)
        {
            for (int ligne = 0; ligne < 9; ligne++)
            {
                for (int colonne = 0; colonne < 9; colonne++)
                {
                    if (tableauParcelle[ligne, colonne].curseur_dedans(souris.X, souris.Y, tailleParcelle) == true)
                    {
                        Parcelle p = tableauParcelle[ligne, colonne];
                        return p;
                    }
                }
            }

            return null;
        }

        private void arroser_Click(object sender, EventArgs e)
        {
            act = Action.Arroser;
        }

       
        private void zoneJardin_Click(object sender, MouseEventArgs e)
        {

            int xsouris = e.X;
            int ysouris = e.Y;
 
            Parcelle p = trouver_parcelle(e); 

            if (act == Action.Parcelle)
            {
                if(choixCouleur.IsEmpty || choixCouleur == Color.White)
                    MessageBox.Show("Vous n'avez pas choisi la couleur de la parcelle.");
                else if (!trouver_liaison(p))
                    MessageBox.Show("Pas de lien entre cette parcelle et les autres.");
                else if (p.afficher == true)
                {
                    MessageBox.Show("Il y a déjà une parcelle ici.");
                }
                else if (p != null)
                {
                    tracer_parcelle(p, choixCouleur);
                    choixCouleur = Color.White; 
                    changementJoueur();
                }
            }
            if (act == Action.Arroser)
            {
                if (p.nbreBambou == 4)
                    MessageBox.Show("Ce bambou est complètement poussé.");
                if(p.etang == true)
                    MessageBox.Show("Les bambous ne poussent pas sur l'étang.");
                if(p.afficher == false)
                    MessageBox.Show("Il n'y a pas de parcelle ici.");
                else
                {
                    p.afficher = false;
                    p.nbreBambou++;
                    tracer_parcelle(p);
                    changementJoueur();
                }
            }
        }

        #region choixCouleurParcelle

        private void ColorGreen_Click(object sender, EventArgs e)
        {
            choixCouleur = Color.ForestGreen;
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

        #endregion 

        private void lancement_Click(object sender, EventArgs e)
        {
            lancement.Hide(); 
            #region Etang
            baseDessin.DrawRectangle(contour, tableauParcelle[4, 4].dimension);
            baseDessin.FillRectangle(tableauParcelle[4, 4].remplissage, tableauParcelle[4, 4].dimension);
            tableauParcelle[4, 4].afficher = true;
            #endregion

            Obj1.Text = listeJoueur[jEnCours].main[0].objectif;
            Obj1.Show();
        }
      
    }
}

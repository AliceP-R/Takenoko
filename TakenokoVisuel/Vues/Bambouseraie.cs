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
using TakenokoVisuel.Elements;


namespace TakenokoVisuel
{
    enum Action
    {
        Indefinie,
        Parcelle, 
        Arroser, 
        Piocher, 
        BougerPanda, 
        BougerJardinier, 
        Irriguer
    }

    public partial class Bambouseraie : Form
    {

        private Parcelle[,] tableauParcelle;
        private const int tailleParcelle = 59;
        private int nbreParcelle; 

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
        Font police;
        StringFormat formatTexte;
        private Color choixCouleur;

        private Acteur jardinier;
        private Acteur panda;
        private int tailleInformation = 29; 

        public Bambouseraie(ArrayList joueurs, int nbrej)
        {
            InitializeComponent();
            baseDessin = zoneJardin.CreateGraphics();

            #region Initialisation du tableau contenant les parcelles
            nbreParcelle = zoneJardin.Height / tailleParcelle; 
            tableauParcelle = new Parcelle[nbreParcelle, nbreParcelle];
            int xParcelle = 0;
            int yParcelle = 0;
            int ligne = 0;
            int colonne = 0;

            for (xParcelle = 0; xParcelle < zoneJardin.Height; xParcelle += (tailleParcelle+1))
            {
                for (yParcelle = 0; yParcelle < zoneJardin.Height; yParcelle += (tailleParcelle+1))
                {
                    tableauParcelle[ligne, colonne] = new Parcelle(ligne, colonne, xParcelle, yParcelle, tailleParcelle);
                    ligne++;
                }
                ligne = 0;
                colonne++;
            }
            #endregion 

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
            #endregion 

            

            #region Définition de l'étang 
            tableauParcelle[4, 4].etang = true;
            tableauParcelle[4, 4].irriguee = true;
            tableauParcelle[4, 4].jardinier = true;
            tableauParcelle[4, 4].panda = true;
            tableauParcelle[4, 4].choixCouleur(Color.Blue); 
            #endregion

            #region Initialisation des pinceaux
            contour = new Pen(Color.Black);
            police = new Font("Arial", 20);
            formatTexte = new StringFormat();
            formatTexte.Alignment = StringAlignment.Center;
            formatTexte.LineAlignment = StringAlignment.Center;
            #endregion 

            #region Définition des images
            string dossierimg = "C:/Users/Alice/Documents/Visual Studio 2013/Projects/Takenoko/TakenokoVisuel/img/";
            jardinier = new Acteur(dossierimg + "jardinier.png", tableauParcelle[4, 4].dimension.X, tableauParcelle[4, 4].dimension.Y, tableauParcelle[4,4], tailleInformation);
            int xpanda = tableauParcelle[4, 4].dimension.X + tailleParcelle - tailleInformation; 
            panda = new Acteur(dossierimg + "panda.png", xpanda, tableauParcelle[4, 4].dimension.Y, tableauParcelle[4,4], tailleInformation); 
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
                    Carte c = listeJoueur[jEnCours].piocher(piocheP);
                    MessageBox.Show("Vous avez pioché " + c.ToString()); 
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
            if (p.afficher == false && (p.etang != true || act == Action.BougerJardinier || act == Action.BougerPanda))
            {
                // contour du rectangle (noir)
                baseDessin.DrawRectangle(contour, p.dimension);
                // intérieur du rectangle (vert/rose/jaune)
                baseDessin.FillRectangle(p.remplissage, p.dimension);
                // nbre de bambou sur cette parcelle
                baseDessin.DrawString(p.nbreBambou.ToString(), police, p.texte, p.dimension.X+tailleInformation, p.dimension.Y+tailleInformation, formatTexte);
                // jardinier 
                if (p.jardinier == true)
                {
                    jardinier.mouvement(p.dimension.X, p.dimension.Y);
                    baseDessin.DrawImage(jardinier.image, jardinier.placement);
                }
                // panda 
                if (p.panda == true)
                {
                    panda.mouvement(p.dimension.X + tailleParcelle - tailleInformation, p.dimension.Y);
                    baseDessin.DrawImage(panda.image, panda.placement);
                }
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
                baseDessin.DrawString(p.nbreBambou.ToString(), police, p.texte, p.dimension.X + tailleInformation, p.dimension.Y + tailleInformation, formatTexte);
                // jardinier 
                if (p.jardinier == true)
                {
                    jardinier.mouvement(p.dimension.X, p.dimension.Y);
                    baseDessin.DrawImage(jardinier.image, jardinier.placement);
                }
                // panda 
                if (p.panda == true)
                {
                    panda.mouvement(p.dimension.X + tailleParcelle - tailleInformation, p.dimension.Y);
                    baseDessin.DrawImage(panda.image, panda.placement);
                }
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
            if (lignep == nbreParcelle-1)
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
            if (colonnep == nbreParcelle - 1)
                droite = tableauParcelle[lignep, colonnep];
            else
                droite = tableauParcelle[lignep, colonnep + 1];
            #endregion 

            if (haut.afficher == false && bas.afficher == false && droite.afficher == false && gauche.afficher == false)
                lien = false; 
            return lien; 
        }

        private bool trouver_liaison_irrigation(Parcelle p)
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
            if (lignep == nbreParcelle -1 )
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
            if (colonnep == nbreParcelle-1)
                droite = tableauParcelle[lignep, colonnep];
            else
                droite = tableauParcelle[lignep, colonnep + 1];
            #endregion

            if (haut.irriguee == false && bas.irriguee == false && droite.irriguee == false && gauche.irriguee == false)
                lien = false;
            return lien;
        }

        private Parcelle trouver_parcelle(MouseEventArgs souris)
        {
            for (int ligne = 0; ligne < nbreParcelle; ligne++)
            {
                for (int colonne = 0; colonne < nbreParcelle; colonne++)
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

        private void deplacementJardinier(Parcelle p)
        {
            Parcelle avant = jardinier.parcelle;
            jardinier.mouvement(p.dimension.X, p.dimension.Y);
            #region actualisation parcelle de départ
            avant.jardinier = false;
            avant.afficher = false;
            bool etang = avant.etang; 
            if (etang == true)
                avant.etang = false; 
            tracer_parcelle(avant);
            if (etang == true)
                avant.etang = true; 

            #endregion 

            #region actualisation parcelle d'arrivée 
            jardinier.parcelle = p;
            p.afficher = false;
            p.jardinier = true;
            if (p.nbreBambou < 4 && p.irriguee && !p.etang)
                p.nbreBambou++;
            tracer_parcelle(p);
            #endregion 

            #region actualisation des parcelles adajcentes 
            int lignep = p.ligne;
            int colonnep = p.colonne;

            #region Parcelle adjacente haute
            Parcelle haut;
            if (lignep == 0)
                haut = tableauParcelle[lignep, colonnep];
            else
                haut = tableauParcelle[lignep - 1, colonnep];
            
            if (haut.afficher && !haut.etang && haut.remplissage.Color == p.remplissage.Color && haut.nbreBambou < 4)
            {
                haut.nbreBambou++;
                haut.afficher = false;
                tracer_parcelle(haut);
            }
            #endregion

            #region Parcelle adjacente basse
            Parcelle bas;
            if (lignep == nbreParcelle - 1)
                bas = tableauParcelle[lignep, colonnep];
            else
                bas = tableauParcelle[lignep + 1, colonnep];

            if (bas.afficher && !bas.etang && bas.remplissage.Color == p.remplissage.Color && bas.nbreBambou < 4)
            {
                bas.nbreBambou++;
                bas.afficher = false;
                tracer_parcelle(bas);
            }
            #endregion

            #region Parcelle adjacente gauche
            Parcelle gauche;
            if (colonnep == 0)
                gauche = tableauParcelle[lignep, colonnep];
            else
                gauche = tableauParcelle[lignep, colonnep - 1];
           
            if (gauche.afficher && !gauche.etang && gauche.remplissage.Color == p.remplissage.Color && gauche.nbreBambou < 4)
            {
                gauche.nbreBambou++;
                gauche.afficher = false;
                tracer_parcelle(gauche);
            }
            #endregion

            #region Parcelle adjacente droite
            Parcelle droite;
            if (colonnep == nbreParcelle - 1)
                droite = tableauParcelle[lignep, colonnep];
            else
                droite = tableauParcelle[lignep, colonnep + 1];

            if (droite.afficher && !droite.etang && droite.remplissage.Color == p.remplissage.Color && droite.nbreBambou < 4)
            {
                droite.nbreBambou++;
                droite.afficher = false;
                tracer_parcelle(droite);
            }
            #endregion 
            #endregion 

        }
        private void zoneJardin_Click(object sender, MouseEventArgs e)
        {

            int xsouris = e.X;
            int ysouris = e.Y;
 
            Parcelle p = trouver_parcelle(e);
            #region placer parcelle
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
            #endregion 
            #region arroser
            if (act == Action.Arroser)
            {
                if (p.nbreBambou == 4)
                    MessageBox.Show("Ce bambou est complètement poussé.");
                else if(p.etang == true)
                    MessageBox.Show("Les bambous ne poussent pas sur l'étang.");
                else if(p.afficher == false)
                    MessageBox.Show("Il n'y a pas de parcelle ici.");
                else if (p.irriguee == false)
                {
                    MessageBox.Show("Il faut que la parcelle soit irriguée pour que le bambou pousse."); 
                }
                else
                {
                    p.afficher = false;
                    p.nbreBambou++;
                    tracer_parcelle(p);
                    changementJoueur();
                }
            }
            #endregion 
            #region irriger
            if (act == Action.Irriguer)
            {
                if (p.etang == true)
                    MessageBox.Show("Pas besoin d'irriguer l'étant !");
                else if (p.afficher == false)
                    MessageBox.Show("Il n'y a pas de parcelle ici.");
                else if (p.irriguee == true)
                    MessageBox.Show("Cette parcelle est déjà irriguée.");
                else if (!trouver_liaison_irrigation(p))
                    MessageBox.Show("Les parcelles adjacentes ne sont pas irriguées."); 
                else
                {
                    p.texte.Color = Color.Blue;
                    p.irriguee = true;
                    p.nbreBambou++;
                    p.afficher = false;
                    tracer_parcelle(p); 
                    changementJoueur();
                }
            }
            #endregion 
            #region bouger jardinier
            if (act == Action.BougerJardinier)
            {
                deplacementJardinier(p); 
                changementJoueur();
            }
            #endregion 
            #region bouger panda
            if (act == Action.BougerPanda)
            {
                Parcelle avant = panda.parcelle;
                panda.mouvement(p.dimension.X, p.dimension.Y);
                panda.parcelle = p;
                p.afficher = false;
                p.panda = true;
                tracer_parcelle(p);
                avant.panda = false;
                avant.afficher = false;
                tracer_parcelle(avant);
                changementJoueur();
            }
            #endregion 
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
            
            foreach (Joueur j in listeJoueur)
            {
                j.piocher(pioche);
            }
            jEnCours = 0;
            groupBoxAction.Show();
            groupBoxObjectif.Show();            
            #region Etang
            baseDessin.DrawRectangle(contour, tableauParcelle[4, 4].dimension);
            baseDessin.FillRectangle(tableauParcelle[4, 4].remplissage, tableauParcelle[4, 4].dimension);
            tableauParcelle[4, 4].afficher = true;
            #endregion

            #region objectif du premier joueur 
            Obj1.Text = listeJoueur[jEnCours].main[0].objectif;
            Obj1.Show();
            #endregion 

            #region panda et jardinier 
            baseDessin.DrawImage(jardinier.image, jardinier.placement);
            baseDessin.DrawImage(panda.image, panda.placement); 
            #endregion 
        }

        private void irriguer_Click(object sender, EventArgs e)
        {
            act = Action.Irriguer;
        }

        private void deplacerJardinier_Click(object sender, EventArgs e)
        {
            act = Action.BougerJardinier; 
        }

        private void deplacerPanda_Click(object sender, EventArgs e)
        {
            act = Action.BougerPanda; 
        }
      
    }
}

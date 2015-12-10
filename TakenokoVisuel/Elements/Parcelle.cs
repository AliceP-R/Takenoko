using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace TakenokoVisuel
{
    class Parcelle
    {
        private int nbreBambouP;
        public int nbreBambou 
        {
            get
            {
                return nbreBambouP; 
            }
            set
            {
                nbreBambouP = value; 
            } 
        }

        public bool irriguee;

        public SolidBrush remplissage; 
        public Rectangle dimension;
        public SolidBrush texte; 

        public bool afficher;
        public bool etang;
        public bool jardinier;
        public bool panda; 

        public int ligne; 
        public int colonne; 

        public Parcelle(int l, int c, int x, int y, int t)
        {
            dimension.X = x;
            dimension.Y = y;
            dimension.Width = dimension.Height = t;
            remplissage = new SolidBrush(Color.White);
            texte = new SolidBrush(Color.Black); 
            afficher = false;
            etang = false;
            jardinier = false;
            panda = false; 
            irriguee = false; 
            nbreBambouP = 0;
            ligne = l;
            colonne = c; 
        }

        public void choixCouleur(Color couleur)
        {
            this.remplissage.Color = couleur; 
        }
        // si le curseur (x,y) est dans le parcelle, renvoie true
        public bool curseur_dedans(int x, int y, int taille)
        {
            bool dedans = true;

            if ((x < dimension.X) || (x > (dimension.X + taille)))
            {
                dedans = false; 
            }

            if ((y < dimension.Y) || (y > (dimension.Y + taille)))
            {
                dedans = false; 
            }

            return dedans; 
        }
    }
}

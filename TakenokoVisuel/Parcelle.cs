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

        private bool irigueeP;
        public bool iriguee
        {
            get
            {
                return irigueeP;
            }
            set
            {
                irigueeP = value;
            }
        }

        public SolidBrush remplissage; 
        public Rectangle dimension;

        public bool afficher;
        public bool etang;  

        public int ligne; 
        public int colonne; 

        public Parcelle(int l, int c, int x, int y, int t)
        {
            dimension.X = x;
            dimension.Y = y;
            dimension.Width = dimension.Height = t;
            remplissage = new SolidBrush(Color.Yellow);
            afficher = false;
            etang = false;
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

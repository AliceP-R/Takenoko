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

        public Pen contour;
        public SolidBrush remplissage; 
        public Rectangle dimension;

        public bool afficher;
        public bool etang;  

        public Parcelle(int x, int y, int t)
        {
            dimension.X = x;
            dimension.Y = y;
            dimension.Width = dimension.Height = t;
            contour = new Pen(Color.Black);
            remplissage = new SolidBrush(Color.Yellow);
            afficher = false;
            etang = false; 
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

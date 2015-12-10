using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakenokoVisuel.Elements
{
    class Acteur
    {
        private Bitmap imageP;
        public Bitmap image 
        {
            get
            {
                return imageP; 
            }
            set
            {
                imageP = value; 
            }
        }

        private Rectangle placementP;
        public Rectangle placement
        {
            get
            {
                return placementP; 
            }
            set
            {
                placementP = value; 
            }
        }

        public Parcelle parcelle; 

        public Acteur(String loc, int x, int y, Parcelle p, int taille)
        {
            imageP = new Bitmap(loc);
            placementP.X = x;
            placementP.Y = y;
            placementP.Width = placementP.Height = taille;
            parcelle = p; 
        }

        public void mouvement(int x, int y )
        {
            placementP.X = x;
            placementP.Y = y;   
        }


    }
}

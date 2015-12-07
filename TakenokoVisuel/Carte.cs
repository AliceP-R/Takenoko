using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TakenokoVisuel
{
    enum Type
    {
        Indefini, 
        Poser, 
        Jardiner, 
        Manger
    }

    enum Couleur
    {
        Rose, 
        Jaune, 
        Vert
    }

    class Carte
    {
        private Type typePrive;
        public Type type
        {
            get
            {
                return typePrive;
            }
            set
            {
                typePrive = value;
            }
        }

        private string objectifPrive;
        public string objectif
        {
            get
            {
                return objectifPrive;
            }
            set
            {
                objectifPrive = value;
            }
        }

        private bool realiseP;
        public bool realise
        {
            get { return realiseP; }
            set { realiseP = value;}
        }

        Couleur couleur;

        private void randCouleur()
        {
            int ms = DateTime.Now.Millisecond;
            Random random = new Random(ms);
            switch ((random.Next(1, 4)))
            {
                case 1:
                    this.couleur = Couleur.Vert;
                    break; 
                case 2:
                    this.couleur = Couleur.Rose;
                    break; 
                case 3:
                    this.couleur = Couleur.Jaune;
                    break; 
            }
            Thread.Sleep(1); 
        }

        public Carte(int t)
        {
            int ms = DateTime.Now.Millisecond;
            Random rand = new Random(ms);
            int nbre = rand.Next(1, 5); 
            this.randCouleur(); 
            switch (t)
            {
                case 1:
                    typePrive = Type.Jardiner;
                    objectifPrive = "Planter " + nbre + " x " + nbre + " bambous "+couleur; 
                    break; 
                case 2:
                    typePrive = Type.Manger;
                    objectifPrive = "Manger " + nbre + " bambous "+couleur; 
                    break;
                case 3:
                    typePrive = Type.Poser;
                    objectifPrive = "Poser " + nbre + " parcelle "+couleur; 
                    break;
                default:
                    typePrive = Type.Indefini;
                    break;
            }
            Thread.Sleep(1);
            realiseP = false; 
        }

        public override string ToString() 
        {
            return "Objectif : " + objectifPrive; 
        }
    }
}

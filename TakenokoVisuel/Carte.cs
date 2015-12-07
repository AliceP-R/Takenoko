using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        Couleur couleur; 

        public Carte(int t)
        {
            Random rand = new Random(); 
            switch (t)
            {
                case 1:
                    typePrive = Type.Jardiner;
                    objectifPrive = "Planter " + rand.Next(1,4) + " x " + rand.Next(1,4) + "bambous COULEUR."; 
                    break; 
                case 2:
                    typePrive = Type.Manger;
                    objectifPrive = "Manger " + rand.Next(1, 4) + "bambous COULEUR."; 
                    break;
                case 3:
                    typePrive = Type.Poser;
                    objectifPrive = "Poser " + rand.Next(1, 4) + "parcelle COULEUR."; 
                    break;
                default:
                    typePrive = Type.Indefini;
                    break;
            }
        }

        public override string ToString() 
        {
            return "Objectif : " + objectifPrive; 
        }
    }
}

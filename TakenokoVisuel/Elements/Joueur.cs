using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakenokoVisuel
{
    class Joueur
    {
        private List<Carte> mainP = new List<Carte>();
        public List<Carte> main 
        {
            get
            {
                return mainP; 
            }
            set
            {
                mainP = value; 
            }
        }
        public int nbreObjOk; 

        public int nbreBambouRose;
        public int nbreBambouVert;
        public int nbreBambouJaune; 

        public string nom; 
        public Joueur(string n)
        {
            nom = n;
            nbreBambouVert = nbreBambouRose = nbreBambouJaune = 0;
            nbreObjOk = 0; 
        }

        public Carte piocher(List<Carte> pioche)
        {
                Carte c; 
                Random rand = new Random();
                int nbre = rand.Next(0, pioche.Count);
                c = pioche[nbre]; 
                mainP.Add(c);
                pioche.RemoveAt(nbre);
                return c; 

        }

        /*
        public void afficher_main()
        {
            if (mainP.Count == 0)
                Console.WriteLine("Joueur " + nom + ", vous n'avez pas de cartes.");
            else
            {
                Console.WriteLine("Joueur " + nom + ", vous avez les cartes suivantes :");
                foreach (Carte carte in mainP)
                {
                    Console.WriteLine(carte.type);

                }
            }
        }
         */
        
    }
}

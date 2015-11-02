using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string nom; 
        public Joueur(string n)
        {
            nom = n; 
        }
        public void piocher(List<Carte> pioche)
        {
                Random rand = new Random();
                int nbre = rand.Next(0, pioche.Count);
                mainP.Add(pioche[nbre]);
                pioche.RemoveAt(nbre);
        }

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
        
    }
}

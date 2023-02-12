using System;
using System.Threading.Tasks.Dataflow;

namespace ProjectTourHanoi
{
    public class ToursHanoi
    {
        private Tour[] _tours = new Tour[3];
        private int _nbAnneau;

        //Constructeur
        public ToursHanoi(int nbAnneau)
        {
            _nbAnneau = nbAnneau;
            // _tours[0] = new Tour('A',_____);
            // _tours[1] = new Tour('B',_____);
            // _tours[2] = new Tour('C',_____);
            reinitialiser();
        }

        //Réinitialise le jeu
        public void reinitialiser()
        {
            //Vide les tours
            // _tours[0].clear();
            // _tours[1].clear();
            // _tours[2].clear();

            //Ajout des anneaux sur la tour A
            for (int i = _nbAnneau; i > 0; i--)
            {
                //_tours[0].push(i);
            }
        }

        //Déplace lun anneau si le mouvement est légal
        private bool deplacer(string strDe, string strVers)
        {
            int nb; //Variable de l'anneau à déplacer
            int de; //Variable de la tour de départ
            int vers; //Varibale de la tour de fin

            //Récupération des indice de tours (a = 0, b = 1, c = 2)
            de = transform(strDe);
            vers = transform(strVers);
            
            /*//Vérifie si l'anneau a déplacer est plus petit
            if (_tours[de].peek() < _tours[vers].peek())
            {
                //Déplacement de l'anneau
                nb = _tours[de].peek();
                _tours[de].pop();
                _tours[vers].push(nb);
                
                //Affichage du déplacement
                Console.WriteLine("L'anneau de diamètre " + nb + " est déplacé de la tour " + strDe + " vers la tour " + strVers);
                return true;
            }
            else
            {
                //Affichage du message d'erreur
                Console.WriteLine("Déplacement illégal");
                return false;
            }
            */
            
            return false;
        }

        //Transforme les lettres des tour en indice int (a = 0, b = 1, c = 2)
        private int transform(string de)
        {
            int nb = -1;
            bool fin = false;

            //Boucle qui prend fin lors d'un résultat valide
            while (!fin)
            {
                //Si la tour est a, retourne 0 et sort de la boucle
                if (de.Equals("a") || de.Equals("A"))
                {
                    nb = 0;
                    fin = true;
                }

                //Si la tour est b, retourne 1 et sort de la boucle
                else if (de.Equals("b") || de.Equals("B"))
                {
                    nb = 1;
                    fin = true;
                }

                //Si la tour est c, retourne 2 et sort de la boucle
                else if (de.Equals("c") || de.Equals("C"))
                {
                    nb = 2;
                    fin = true;
                }

                //Si la tour est non-valide, affiche le message d'erreur et reste dans la boucle
                else
                {
                    Console.WriteLine("Choix de tour non-valide");
                }
            }

            return nb;
        }

        public void resoudre()
        {
            reinitialiser();
            deplacerAuto();
        }
        
        private void deplacerAuto()
        {
            
        }

        public string toString()
        {
            string affiche = "";
            for (int i = 0; i < 3; i++)
            {
               affiche +=  _tours[i].ToString()+"\n";
            }
            return affiche;
        }
    }
}
using System;
using System.Threading.Tasks.Dataflow;

namespace ProjectTourHanoi
{
    public class ToursHanoi
    {
        private Tour[] _tours = new Tour[3];
        private int _nbAnneau;
        
        /*
	     * \brief : Constructeur ToursHanoi surchargé 
	     * \param[in] : Un int qui représente le nombre d'anneaux
	     */
        public ToursHanoi(int nbAnneau)
        {
            _nbAnneau = nbAnneau;
            _tours[0] = new Tour('A',nbAnneau,nbAnneau);
            _tours[1] = new Tour('B',0,nbAnneau);
            _tours[2] = new Tour('C',0,nbAnneau);
            reinitialiser();
        }

        
        /*
        * \brief : Réinitialiser le jeu
        * \param[in] : Aucun
        * \return : Aucun
        */
        public void reinitialiser()
        {
            //Vide les tours
            _tours[0].clear();
            _tours[1].clear();
            _tours[2].clear();

            //Ajout des anneaux sur la tour A
            for (int i = _nbAnneau; i > 0; i--)
            {
                _tours[0].push(new Anneau(i));
            }
        }

        
        /*
        * \brief : Déplacer un anneau
        * \param[in] : int représentant l'indice de la tour de départ
        * \param[in] : int représentant l'indice de la tour de fin
        * \return : bool représentant si le déplacment est valide
        */
        public bool deplacer(int de, int vers)
        {
            Anneau nb = _tours[de].peek();

            //Vérifie si l'anneau a déplacer est plus petit
            if (nb.Diametre < _tours[vers].peek().Diametre)
            {
                //Déplacement de l'anneau
                _tours[de].pop();
                _tours[vers].push(nb);
                
                //Affichage du déplacement
                Console.WriteLine("L'anneau de diamètre " + nb + " est déplacé de la tour " + de + " vers la tour " + vers);
                return true;
            }
            else
            {
                //Affichage du message d'erreur
                Console.WriteLine("Déplacement illégal");
                Console.WriteLine("Veuillez recommencer la sélection des tours");
                return false;
            }

        }

        
        /*
        * \brief : Transformer les lettres des tour en indice int (a = 0, b = 1, c = 2)
        * \param[in] : Aucun
        * \return : int représentant l'indice de la tour
        */
        public int transform()
        {
            int nb = -1;
            bool fin = false;
            string de;

            //Boucle qui prend fin lors d'un résultat valide
            while (!fin)
            {
                //Récupération de la lettre de la tour
                de = Console.ReadLine();
                
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

        
        /*
        * \brief : Résolution du jeu
        * \param[in] : Aucun
        * \return : Aucun
        */
        public void resoudre()
        {
            reinitialiser();
            deplacerAuto(_nbAnneau,0,1,2);
        }
        
        
        /*
        * \brief : Déplacement automatique des anneaux par récursivité
        * \param[in] : int représentant le disque à déplacer
        * \param[in] : int représentant l'indice de la tour de départ
        * \param[in] : int représentant l'indice de la tour intermédiare
        * \param[in] : int représentant l'indice de la tour de fin
        * \return : Aucun
        */
        private void deplacerAuto(int disque,int de, int inter, int vers)
        {
            if (disque == 1)
            {
                deplacer(de, vers);
            }

            else
            {
             deplacerAuto(disque-1,de,vers,inter);
             deplacer(de, vers);
             deplacerAuto(disque - 1,inter,de,vers);
            }
        }

        
        /*
        * \brief : Afficher le jeu
        * \param[in] : Aucun
        * \return : String représentant le jeu avec ses tours et ses anneaux
        */
        public override string ToString()
        {
            string affiche = "";
            for (int i = 0; i < 3; i++)
            {
               affiche +=  _tours[i]+"\n";
            }
            return affiche;
        }
    }
}
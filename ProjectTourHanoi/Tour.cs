using System;
using System.Security.Cryptography;

namespace ProjectTourHanoi
{
    public class Tour
    {

        public char _lettreTour; //Variable représentant la lettre associée à la tour
        private int _nbAnneau;  //Variable du nombre d'anneau de la tour
        public int _top;    //Variable du sommet de la pile
        private Anneau[] _tours;    //Tableau d'anneaux
        
        
        /*
	     * \brief : Constructeur Tour surchargé 
	     * \param[in] : Un char qui représente la lettre de la tour 
	     * \param[in] : Un int pour le nombre d'anneaux sur la tour
         * \param[in] : Un int pour le nombre d'anneaux maximal sur la tour
	     */
        public Tour(char lettreTour, int nbAnneau, int maxAnneau)
        {
            _lettreTour = lettreTour;
            _nbAnneau = nbAnneau;
            _tours = new Anneau[maxAnneau];
            _top = nbAnneau - 1;
            int diametre = nbAnneau;
            
            //Ajout des anneau sur la tour
            for (int i = 0; i < nbAnneau; i++)
            {
                _tours[i] = new Anneau(diametre);
                diametre--;
            }

        }
        
        
        //////////Fonctions primaires de la pile Tour[]//////////
        
        
        /*
	     * \brief : Ajouter un anneau sur la pile
	     * \param[in] : Un anneau qui sera ajouter sur la pile 
	     * \return : Aucun
	     */
        public void push(Anneau nbAnneau)
        {
            _tours[++_top] = nbAnneau;
        }

        
        /*
	     * \brief : Enlever un anneau de la pile
	     * \param[in] : Aucun
	     * \return : L'anneau qui est retiré de la pile
	     */
        public Anneau pop()
        {
            return _tours[_top--];
        }

        //////////Fonctions secondaires de la pile Tour[]//////////
        
        
        /*
        * \brief : Retourne l'anneau sur le dessus de la pile
        * \param[in] : Aucun
        * \return : L'anneau du dessus de la pile
        */
        public Anneau peek()
        {
            if (_top != -1)
            {
                return _tours[_top];
            }
            //Si la tour est vide, retourne un diamètre plus grand que le maximum d'anneau pour assurer que le déplacment sera perçu comme valide
            else
            {
                return (new Anneau(_tours.Length + 1));
            }
        }

        
        /*
        * \brief : Vérifie si la pile est vide
        * \param[in] : Aucun
        * \return : Un bool représentant si la pile est vide
        */
        public bool isEmpty()
        {
            return (_top == -1);
        }

        
        /*
        * \brief : Vérifie si la pile est pleine
        * \param[in] : Aucun
        * \return : Un bool représentant si la pile est pleine
        */
        public bool isFull()
        {
            return (_top == _nbAnneau - 1);
        }

        
        /*
        * \brief : Vider la pile
        * \param[in] : Aucun
        * \return : Aucun
        */
        public void clear()
        {
            while (!isEmpty())
            {
                pop();
            }
        }
        
        
        /*
        * \brief : Afficher la tour
        * \param[in] : Aucun
        * \return : String représentant la tour avec ses anneaux
        */
        public override string ToString()
        {
            string affichage = _lettreTour + ": ";

            //Variable représentant la différence entre le top dela pile et le maximum d'anneaux
            int dif = _tours.Length - (_top + 1);

            //Affichage des anneaux sur la tour
            for (int i = 0; i < (_top + 1); i++)
            {
                affichage += _tours[i].ToString();
            }

            //Affichage des espaces libres de la tour
            for (int i = 0; i < dif; i++)
            {
                affichage += "-";
            }
           
            
            return affichage;
        }
    }
}
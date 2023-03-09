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
        
        //Constructeur
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
        
        //Fonction pour ajouter un anneau sur la pile
        public void push(Anneau nbAnneau)
        {
            _tours[++_top] = nbAnneau;
        }

        //Fonction pour enlever un anneau de la pile
        public Anneau pop()
        {
            return _tours[_top--];
        }

        //////////Fonctions secondaires de la pile Tour[]//////////
       
        //Retourne l'anneau sur le dessus de la pile, si celle-ci vide, retourne un diamètre plus grand que le maximum d'anneau
        public Anneau peek()
        {
            if (_top != -1)
            {
                return _tours[_top];
            }
            else
            {
                return (new Anneau(10));
            }
        }

        //Fonction pour vérifier si la pile est vide
        public bool isEmpty()
        {
            return (_top == -1);
        }

        //Fonction pour vérifier si la pileest pleine
        public bool isFull()
        {
            return (_top == _nbAnneau - 1);
        }

        //Fonction pour vider la pile
        public void clear()
        {
            while (!isEmpty())
            {
                pop();
            }
        }

        //Fonction permettant d'afficher la tour
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
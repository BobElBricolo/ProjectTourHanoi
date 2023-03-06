using System;
using System.Security.Cryptography;

namespace ProjectTourHanoi
{
    public class Tour
    {

        public char _lettreTour;
        private int _nbAnneau;
        public int _top;
        private Anneau[] _tours;
        
        public Tour(char lettreTour, int nbAnneau, int maxAnneau)
        {
            _lettreTour = lettreTour;
            _nbAnneau = nbAnneau;
            _tours = new Anneau[maxAnneau];
            _top = nbAnneau - 1;
            int diametre = nbAnneau;
            
            for (int i = 0; i < nbAnneau; i++)
            {
                _tours[i] = new Anneau(diametre);
                diametre--;
            }

        }
        
        //Fonctions primaires de la pile Tour[]
        public void push(Anneau nbAnneau)
        {
            _tours[++_top] = nbAnneau;
        }

        public Anneau pop()
        {
            return _tours[_top--];
        }

        //Fonctions secondaires de la pile Tour[]
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

        public bool isEmpty()
        {
            return (_top == -1);
        }

        public bool isFull()
        {
            return (_top == _nbAnneau - 1);
        }

        public void clear()
        {
            while (!isEmpty())
            {
                pop();
            }
        }

        public override string ToString()
        {
            string affichage = _lettreTour + ": ";

            int dif = _tours.Length - (_top + 1);

            for (int i = 0; i < (_top + 1); i++)
            {
                affichage += _tours[i].ToString();
            }

            for (int i = 0; i < dif; i++)
            {
                affichage += "-";
            }
           
            
            return affichage;
        }
    }
}
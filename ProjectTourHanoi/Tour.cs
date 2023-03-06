using System;

namespace ProjectTourHanoi
{
    public class Tour
    {
        //Fonctions primaires de la pile Tour[]
        public void push(Anneau nbAnneau)
        {
            Tour[++top.set] = nbAnneau;
        }

        public Anneau pop()
        {
            return Tour[top.set--];
        }

        //Fonctions secondaires de la pile Tour[]
        public Anneau peek()
        {
            return Tour[top.get()];
        }

        public bool isEmpty()
        {
            return (top.get() == -1);
        }

        public bool isFull()
        {
            return (top.get() == Tour.nbAnneau - 1);
        }

        public void clear()
        {
            
        }
        
        
    }
}
using System;

namespace ProjectTourHanoi
{
    public class Tour
    {
        public void push(Anneau nbAnneau)
        {
            Tour[++top] = nbAnneau;
        }
        
        
    }
}
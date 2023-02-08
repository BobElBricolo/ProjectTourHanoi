using System;

namespace ProjectTourHanoi
{
    public class ToursHanoi
    {
        private Tour[] _tours = new Tour[3];
        private int _nbAnneau;

        public ToursHanoi(int nbAnneau)
        {
            _nbAnneau = nbAnneau;
            // _tours[0] = new Tour('A',_____);
            // _tours[1] = new Tour('B',_____);
            // _tours[2] = new Tour('C',_____);
            // reiniatiliser
        }

        public void reinitialiser()
        {
            // _tours[0].clear();
            // _tours[1].clear();
            // _tours[2].clear();

            for (int i = _nbAnneau; i > 0; i--)
            {
                //_tours[0].push(i);
            }
        }

        public bool deplacer(int de, int vers, string strDe, string strVers)
        {
            int nb;
            
            /*
            if (_tours[de].peek() < _tours[vers].peek())
            {
                nb = _tours[de].peek();
                _tours[de].pop();
                _tours[vers].push(nb);
                
                Console.WriteLine("L'anneau de diamètre " + nb + " est déplacé de la tour " + strDe + " vers la tour " + strVers);
                return true;
            }
            else
            {
                Console.WriteLine("Déplacement illégal");
                return false;
            }
            */
            
            return false;
        }

        private void validation(string vers, string de)
        {
            //Avec A comme point de départ
            if (de.Equals("a") || de.Equals("A"))
            {
                if (vers.Equals("b") || vers.Equals("B"))
                {
                    deplacer(0, 1,"A","B");
                }
                else if (vers.Equals("c") || vers.Equals("C"))
                {
                    deplacer(0, 2,"A","C");
                }
                else
                {
                    Console.WriteLine("Déplacement illégal");
                }
            }
            
            //Avec B comme point de départ
            else if (de.Equals("b") || de.Equals("B"))
            {
                if (vers.Equals("a") || vers.Equals("A"))
                {
                    deplacer(1, 0,"B","A");
                }
                else if (vers.Equals("c") || vers.Equals("C"))
                {
                    deplacer(1, 2,"B","C");
                }
                else
                {
                    Console.WriteLine("Déplacement illégal");
                }
            }
            
            //Avec C comme point de départ
            else if (de.Equals("c") || de.Equals("C"))
            {
                if (vers.Equals("a") || vers.Equals("A"))
                {
                    deplacer(2, 0,"C","A");
                }
                else if (vers.Equals("b") || vers.Equals("B"))
                {
                    deplacer(2, 1,"C","B");
                }
                else
                {
                    Console.WriteLine("Déplacement illégal");
                }
            }
            else
            {
                Console.WriteLine("Déplacement illégal");
            }
        }
        
    }
}
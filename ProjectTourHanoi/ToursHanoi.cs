using System;
using System.Threading.Tasks.Dataflow;

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
            reinitialiser();
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

        private bool deplacer(string strDe, string strVers)
        {
            int nb;
            int de;
            int vers;

            de = transform(strDe);
            vers = transform(strVers);
            
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

        private int transform(string de)
        {
            int nb = -1;
            bool fin = false;

            while (!fin)
            {
                if (de.Equals("a") || de.Equals("A"))
                {
                    nb = 0;
                    fin = true;
                }

                else if (de.Equals("b") || de.Equals("B"))
                {
                    nb = 1;
                    fin = true;
                }

                else if (de.Equals("c") || de.Equals("C"))
                {
                    nb = 2;
                    fin = true;
                }

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
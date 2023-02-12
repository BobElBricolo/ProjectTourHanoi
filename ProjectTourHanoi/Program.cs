using System;

namespace ProjectTourHanoi
{
    class Program
    {
        private static ToursHanoi jeu;
      
        static void Main(string[] args)
        {
            string choix;
            bool fin = false;
            
            jeu = new ToursHanoi(3);

            while (!fin)
            {
                Console.WriteLine("Tours:");
                Console.WriteLine(jeu + "\n");

                Console.WriteLine("MENU\n");

                Console.WriteLine("1:Déterminer le nombre d'anneaux (3 par défaut)");
                Console.WriteLine("2: Réinitialiser les tours");
                Console.WriteLine("3: Jouer un coup");
                Console.WriteLine("4: Montrer la solution");
                Console.WriteLine("5: Quitter");
                Console.WriteLine("Faites votre choix et appuyer sur ENTER");
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        choix1();
                        break;
                    
                    case "2":
                        choix2();
                        break;
                    
                    case "3":
                        choix3();
                        break;
                    
                    case "4":
                        //jeu.resoudre();
                        break;
                    
                    case "5":
                        fin = true;
                        break;
                    
                    default:
                        Console.WriteLine("Choix non-valide");
                        break;
                }
                
            }
        }

        static void choix1()
        {
            int nb;
            bool fin = false;

            while (!fin)
            {
                Console.WriteLine("Veuiller entrer un nombre entre 1 et 9");
                nb = Convert.ToInt16(Console.ReadLine());

                if (nb < 10 && nb > 0)
                {
                    jeu = new ToursHanoi(nb);
                    fin = true;
                }
                else if (nb == 0)
                {
                    Console.WriteLine("Retour au menu principal");
                    fin = true;
                }
                else
                {
                    Console.WriteLine("Choix non-valide");
                }
            }
        }

        static private void choix2()
        {
            jeu.reinitialiser();
        }

        static private void choix3()
        {
            
        }
    }
}

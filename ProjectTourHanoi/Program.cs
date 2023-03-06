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
                //Affichage du menu
                Console.WriteLine("\n\nTours:");
                Console.WriteLine(jeu);

                Console.WriteLine("MENU\n");

                Console.WriteLine("1:Déterminer le nombre d'anneaux (3 par défaut)");
                Console.WriteLine("2: Réinitialiser les tours");
                Console.WriteLine("3: Jouer un coup");
                Console.WriteLine("4: Montrer la solution");
                Console.WriteLine("5: Quitter");
                Console.WriteLine("Faites votre choix et appuyer sur ENTER");
                
                //Récupération du choix de l'utilisateur
                choix = Console.ReadLine();

                //Appel de la fonction selon le choix
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
                        jeu.resoudre();
                        break;
                    
                    //Quitte la boucle
                    case "5":
                        fin = true;
                        break;
                    
                    //Message d'erreur si choix non-valide
                    default:
                        Console.WriteLine("Choix non-valide");
                        break;
                }
                
            }
        }

        static void choix1()
        {
            int nb;//Variable du nombre d'anneaux
            bool fin = false;//Variable pour la boucle

            //Boucle jusqu'à ce qu'un résultat valide soit entré
            while (!fin)
            {
                //Récupération du nombre d'anneau
                Console.WriteLine("Veuiller entrer un nombre d'anneau entre 1 et 9");
                nb = Convert.ToInt16(Console.ReadLine());

                //Validation du nombre entré
                if (nb < 10 && nb > 0)
                {
                    //Création du nouveau jeu avec le nombre d'anneaux
                    jeu = new ToursHanoi(nb);
                    
                    //Termine la boucle
                    fin = true;
                }
                
                //Si le nombre est , retour au menu
                else if (nb == 0)
                {
                    Console.WriteLine("Retour au menu principal");
                    fin = true;
                }
                
                //Si le nombre est invalide, affichage du message d'erreur
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
            Console.WriteLine("De quelle tour prenez-vous l'anneau? (A - B - C)");
            int _base = jeu.transform();
            
            Console.WriteLine("Vers quelle tour envoyez-vous l'anneau? (A - B - C)");
            int fin = jeu.transform();


            jeu.deplacer(_base, fin);
        }

        
    }
}

namespace ProjectTourHanoi
{
    public class Anneau
    {
        public int Diametre { get; }  

        //Constructeur d'Anneau
        public Anneau(int diametre)
        {
            Diametre = diametre;
        }
        
        //Affichage d'anneau
        public override string ToString()
        {
            return Diametre.ToString();
        }
    }
}
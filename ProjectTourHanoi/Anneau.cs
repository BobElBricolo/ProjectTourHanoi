namespace ProjectTourHanoi
{
    public class Anneau
    {
        public int Diametre { get; }

        public Anneau(int diametre)
        {
            Diametre = diametre;
        }
        
        public override string ToString()
        {
            return Diametre.ToString();
        }
    }
}
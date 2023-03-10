namespace ProjectTourHanoi
{
    public class Anneau
    {
        public int Diametre { get; }  

        /*
	     * \brief : Constructeur Anneau surchargé 
	     * \param[in] : Un int qui représente le diamètre de l'anneau
	     */
        public Anneau(int diametre)
        {
            Diametre = diametre;
        }

        /*
        * \brief : Afficher l'anneau
        * \param[in] : Aucun
        * \return : String représentant le diamètre de l'anneau
        */
        public override string ToString()
        {
            return Diametre.ToString();
        }
    }
}
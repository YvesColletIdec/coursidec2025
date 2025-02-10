namespace POO_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto m = new Moto();
            m.NombreRoues = 2;
            m.Marque = "Ducati";
            m.Couleur = "rouge";
            m.Poids = 230;

            Avion a = new Avion();
            a.Couleur = "blanc";
            //a.Voler();
        }
    }
}

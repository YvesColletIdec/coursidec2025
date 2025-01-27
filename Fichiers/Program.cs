namespace Fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chemin = "C:/Users/yvesc/monFichier.txt";
            string[] donnees = new string[] { "Bonjour", "le", "monde" };
            File.AppendAllLines(chemin, donnees);

            string[] donneesLues = File.ReadAllLines(chemin);
            foreach (string ligne in donneesLues)
            {
                Console.WriteLine(ligne);
            }
        }
    }
}

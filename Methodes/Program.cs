namespace MonEspaceDeNom
{
    public class Fonction
    {

        //méthode qui affiche le nombre qu'on lui passe en entrée
        static void AfficherNombre(int nombre)
        {
            Console.WriteLine($"la somme est de {nombre}");
        }

        //méthode qui aditionne 2 chiffres reçus en entrée et retourne la somme
        static int Additionner(int a, int b)
        {
            return a + b;
        }


        //methode.exe salut tout le monde
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            if (args.Length > 0 && args[0] == "toto")
            {
                Console.WriteLine("creative mode activé");
            }
        
            //AfficherNombre(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(Additionner(5, 6));
            AfficherNombre(Additionner(5, 6));

            Console.ReadLine();
        }


    }
}

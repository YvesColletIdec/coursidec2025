namespace ProjetException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisir le 1er nombre");
            int x = 0;
            try
            {
                x = int.Parse(Console.ReadLine());
            } catch (Exception e)
            {
                Console.WriteLine($"veuillez saisir un mombre en chiffre");
            }
            Console.WriteLine("saisir le 2ème nombre");
            int y = int.Parse(Console.ReadLine());
            Division(x, y);
            Console.ReadLine();
        }

        public static void Division(int a, int b)
        {
            decimal resultat = 0;
            try
            {
                 resultat = a / b;
            } catch(Exception e)
            {
                Console.WriteLine($"zut le programme a planté...");
                string path = "C:/Users/yvesc/monFichier.txt";
                File.AppendAllText(path, e.Message);
            }
            
            Console.WriteLine(resultat);
        }
    }
}

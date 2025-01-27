namespace Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Test();
            //déclaration
            List<int> maListeDEntiers = new List<int>();
            maListeDEntiers.Add(1654);
            maListeDEntiers.Add(234);
            maListeDEntiers.Add(768);
            foreach (int entier in maListeDEntiers)
            {
                Console.WriteLine(entier);
            }

            string[] tableauDeChaines = new string[] {"salut","tout","le","monde" };
            List<string> listeDeChaines = new List<string>();
            listeDeChaines.AddRange(tableauDeChaines);
            listeDeChaines = tableauDeChaines.ToList();
            listeDeChaines.Add("!");
            string[] testTableau = listeDeChaines.ToArray();
            //listeDeChaines.Remove("tout");
            listeDeChaines[1] = "";
            listeDeChaines[3] = "!!!";
            foreach (string s in listeDeChaines)
            {
                Console.WriteLine(s);
            }

        }

        public static void Test()
        {

        }
    }
}

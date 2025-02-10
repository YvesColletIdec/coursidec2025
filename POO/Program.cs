using POO1;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(5);
            a.Nom = "Fufu";
            a.Espece = "Chien";
            a.Age = 5;
            Console.WriteLine(a.Nom);
        }
            static void Main6(string[] args)
        {
            Voiture v = new Voiture();
            Console.WriteLine(v.GetMarque());
            Console.WriteLine(v.Poids);
            v.Poids = Console.ReadLine();
            Montre m = new Montre() { prix = 23, type = "luxe" };
        }
            static void Main5(string[] args)
        {
            Personne p = new Personne();
            Personne p1 = new Personne("Jean", 42);
            p.SetNom("Raul");
            Console.WriteLine($"la personne s'appelle {p.GetNom()}");
            p.GetNom();
            Personne.Respirer();
        }
        static void Main4(string[] args)
        {
            Ami moi = new Ami();
            moi.nom = "Yves";
            moi.age = 25;
            moi.sonAmi = new Ami();
            moi.sonAmi.nom = "Luc";
            Ami monPote = moi.sonAmi;
            Console.WriteLine(monPote.nom);
        }
        static void Main3(string[] args)
        {
            Montre m1 = new Montre();
            m1.marque = "Rolex";
            m1.type = "Automatique";
            m1.prix = 5000;
            Montre m2 = new Montre();
            m2.marque = m1.marque;
            m2.type = m1.type;
            m2.prix = m1.prix;
            m1 = m2;
        }
        static void Main2(string[] args)
        {
            //int x = 2;
            //int y = 3;
            //x = y;
            //Personne p = new Personne();
            //p.nom = "Jean";
            //p.age = 25;
            //Personne p1 = new Personne();
            //p1.nom = "Eric";
            //p1.age = 32;
            //p1.age = p.age + x;
            //p1 = p;
            //p.age = 30;
            //p1.age = p.age + y;
            //p1 = new Personne();
            //p = null;
            //p1 = p;
        }
    }
}

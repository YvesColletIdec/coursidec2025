using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Personne
    {
        private string nom;
        private int age;

        public static void Respirer()
        {
            Console.WriteLine("pfou");
        }
        public static void Salut()
        {
            Console.WriteLine("Salut");
        }

        //constructeur par défaut
        public Personne() { }

        public Personne(string monNom)
        {
            nom = monNom;
        }

        public Personne(string unNom, int unAge)
        {
            nom = unNom;
            age = unAge;
        }

        public void SetNom(string valeur)
        {
            nom = valeur;
        }

        public string GetNom()
        {
            return nom;
        }

        public void SetAge(int valeur)
        {
            age = valeur;
        }

        public int GetAge()
        {
            return age;
        }

        public void Coucou()
        {
            Console.WriteLine("coucou");
        }
    }
}

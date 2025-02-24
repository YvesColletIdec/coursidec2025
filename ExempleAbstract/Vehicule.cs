using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleAbstract
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }
        public string Couleur { get; set; }

        public abstract void Demarrer();
        public void Coucou()
        {
            Console.WriteLine("coucou");
        }
    }
}

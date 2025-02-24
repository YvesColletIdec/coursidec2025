using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleAbstract
{
    public class Voiture : Vehicule
    {
        public int NbreDeChevaux { get; set; }

        public override void Demarrer()
        {
            Console.WriteLine("vroum");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    public class Avion : Vehicule
    {
        public string TypeModele { get; set; }
        public int NombrePlaces { get; set; }

        public Avion() {
            Salut();
        }

        protected void Voler() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    public class Vehicule
    {
        public string Couleur { get; set; }
        public int Poids { get; set; }

        public void Demarrer() { }

        private void Freiner() { }

        protected void Salut()
        {

        }
    }
}

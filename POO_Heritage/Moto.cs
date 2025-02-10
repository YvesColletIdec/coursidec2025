using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    public class Moto : Vehicule
    {
        public int NombreRoues { get; set; }
        public string Marque { get; set; }
    }

    public class Scooter : Moto
    {

    }
}

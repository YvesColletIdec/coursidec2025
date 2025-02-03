using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Voiture
    {
        private string marque;
        public static int nbRoues = 4;

        public void SetMarque(string marque)
        {
            this.marque = marque;
        }

        public string GetMarque()
        {
            return this.marque;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleInterface
{
    public class Voiture : Object, IVehicule, IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("dispose");
            List<int> x = null;
        }

        public void Freiner()
        {
            Console.WriteLine("freiner");
        }
    }
}

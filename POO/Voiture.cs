using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Voiture
    {
        public int NombreDeRoues { get; set; }

        private string _poids;

        public string Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }

        public Voiture()
        {
            _marque = "Ford";
            Poids = "1000";
            Console.WriteLine(Poids);
        }



        private string _marque;

        public void SetMarque(string _marque)
        {
            this._marque = _marque;
        }

        public string GetMarque()
        {
            return _marque;
        }


    }
}

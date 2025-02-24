using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heritage
{
    public partial class Velo
    {
		private int _taille;

		public int Taille
		{
			get { return this._taille; }
			set { this._taille = value; }
		}

        public bool EstElectrique { get; set; }

		public Velo()
		{
			EstElectrique = false;
		}

        public Velo(bool estElectrique)
        {
			this.EstElectrique = estElectrique;
			this._taille = 0;
			this.Taille = 3;
        }
    }
}

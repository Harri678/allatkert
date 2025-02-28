using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	internal class Szárazföldi_hideg_éghajlat
	{
		private string nev;
		private string allat;
		private int sebesseg;

		public Szárazföldi_hideg_éghajlat(string nev, string allat, int sebesseg)
		{
			this.nev = nev;
			this.allat = allat;
			this.sebesseg = sebesseg;
		}

		public string Nev { get => nev; set => nev = value; }
		public string Allat { get => allat; set => allat = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
	public class Allatkert
	{
		public string Nev { get; set; }
		public string Faj { get; set; }
		public int Sebesseg { get; set; }

		public Allatkert(string nev, string faj, int sebesseg)
		{
			Nev = nev;
			Faj = faj;
			Sebesseg = sebesseg;
		}
	}

	public class SzarazfoldiTropusiEghajlatban : Allatkert
	{
		public SzarazfoldiTropusiEghajlatban(string nev, string faj, int sebesseg) : base(nev, faj, sebesseg) { }
	}

	public class SzarazfoldiMelegEghajlatban : Allatkert
	{
		public SzarazfoldiMelegEghajlatban(string nev, string faj, int sebesseg) : base(nev, faj, sebesseg) { }
	}

	public class SzarazfoldiMediterranEghajlatban : Allatkert
	{
		public SzarazfoldiMediterranEghajlatban(string nev, string faj, int sebesseg) : base(nev, faj, sebesseg) { }
	}

	public class SzarazfoldiHidegEghajlat : Allatkert
	{
		public SzarazfoldiHidegEghajlat(string nev, string faj, int sebesseg) : base(nev, faj, sebesseg) { }
	}

	public class Vizi : Allatkert
	{
		public Vizi(string nev, string faj, int sebesseg) : base(nev, faj, sebesseg) { }
	}
}

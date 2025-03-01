namespace allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{

            SzarazfoldiTropusiEghajlatban allat1 = new SzarazfoldiTropusiEghajlatban("Jani", "Gorilla", 2);
			SzarazfoldiMelegEghajlatban allat2 = new SzarazfoldiMelegEghajlatban("Kiky", "Teve", 3);
			SzarazfoldiMediterranEghajlatban allat3 = new SzarazfoldiMediterranEghajlatban("Zsolti", "Béka", 1);
			SzarazfoldiHidegEghajlat allat4 = new SzarazfoldiHidegEghajlat("Béla", "Medve", 4);
			Vizi allat5 = new Vizi("Karcsi", "Cápa", 3);

			List<Allatkert> allatLista = new List<Allatkert>
		{
			allat1,
			allat2,
			allat3,
			allat4,
			allat5
		};
			//Verseny
            int haladas = 0;

			for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();
				haladas += 1;
				foreach(var allat in allatLista)
				{
                    Console.Write(allat.Nev + ": ");
					Console.SetCursorPosition(haladas*allat.Sebesseg, allatLista.IndexOf(allat));
					Console.WriteLine("O");
				}
            }

			//Telitetség
			Random rnd = new Random();
			int meret = rnd.Next(5, 15);

			string keret = new string('_', meret);
			Console.WriteLine(keret);
			Console.Write("|");
			Console.BackgroundColor = ConsoleColor.Green;
			for (int i = 0; i < allatLista.Count(); i++)
			{
				if (allatLista[i] != null)
				{
					Console.Write(" ");
				}
			}
			Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < meret - allatLista.Count(); i++)
            {
				Console.Write(" ");
			}

            Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("|");
			Console.WriteLine(keret);

			//Kiiratas
			foreach (var allat in allatLista)
			{
                Console.WriteLine($"{allat.Nev} {allat.Sebesseg} {allat.Faj}");
            }
        }
	}
}

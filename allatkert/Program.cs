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
			Console.WriteLine("O\nO");
            int haladas = 0;
            int haladas2 = 0;



			for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                Console.Clear();
				foreach(var allat in allatLista)
				{
					Console.SetCursorPosition(haladas += 2, 0);
					Console.WriteLine("O");
				}
                Console.SetCursorPosition(haladas += 2, 0);
                Console.WriteLine("O");
                Console.SetCursorPosition(haladas2 += 3, 1);
                Console.WriteLine("O");

            }


			//Telitetség
			Random rnd = new Random();
			int meret = rnd.Next(5, 15);
			meret = 15;

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

		static void Szazalek() { 

            Random rnd = new Random();
            int meret = rnd.Next(5, 15);


			string[] szavak = new string[meret];    
            szavak[0] = "alma";
			szavak[1] = "béla";
			szavak[2] = "cecil";


            string keret = new string('_', meret);
			Console.WriteLine(keret);
            Console.Write("|");
            for (int i = 0; i < szavak.Length; i++)
            {
				if (szavak[i] != null) Console.BackgroundColor = ConsoleColor.Green;
				else
				{
					Console.BackgroundColor= ConsoleColor.Black;
                }
                Console.Write(" ");
            }


            Console.BackgroundColor= ConsoleColor.Black;
            Console.WriteLine("|");
            Console.WriteLine(keret);
        }
	}
}

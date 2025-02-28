namespace allatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{

            Console.WriteLine("O\nO");
            int haladas = 0;
            int haladas2 = 0;  
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.SetCursorPosition(haladas += 2, 0);
                Console.WriteLine("O");
                Console.SetCursorPosition(haladas2 += 3, 1);
                Console.WriteLine("O");

            }


        }

		static void Szazalek() { 
            string[] szavak = new string[5];
            szavak[0] = "alma";
			szavak[1] = "béla";
			szavak[2] = "cecil";


			Console.WriteLine("_______");
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
            Console.WriteLine("_______");
        }
	}
}

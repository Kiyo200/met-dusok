namespace metódusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
            Console.WriteLine(Osszeadas(10,90));
            Console.WriteLine(Duplaz(5));
            Console.WriteLine(Osszeg(4));
			int elso = 5;
			int masodik = 4;
            Console.WriteLine(elso+ " " +masodik);
        }
		static void Koszonto()
		{
            Console.WriteLine("hello vilag");
			Console.ReadLine();
        }



		static int Osszeadas(int a, int b)
		{
			int osszeg = a + b;
			return osszeg;
			/*return a + b;*/
		}

		static int Duplaz( int szam)
		{
			return szam * 2;
		}

		static int Osszeg(int a, int b = 5)
		{
			return a + b;
		}


		static void Csere(ref int a,ref int b)
		{
			int tep = a;
			a = b;
			b = tep;

		}
	}
}

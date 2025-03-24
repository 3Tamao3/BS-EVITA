using System;

public class Methoden
{
	public static void Main(string[] args)
	{
		IstGerade(7);
		Console.WriteLine(Quadrat(5));
	}
		static bool IstGerade(int zahl)
		{
			if (zahl % 2 == 0)
			{
				Console.WriteLine("Ist eine gerade");
				return true;
			}
			else
			{
				Console.WriteLine("Ist nicht eine gerade");
				return false;
			}
		}

		static int Quadrat(int zahl)
		{	
			return zahl * zahl;	
		}
		
}

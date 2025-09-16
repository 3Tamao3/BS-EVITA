using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> zahlen = new List<int>();

        zahlen.Add(3);
        zahlen.Add(7);
        zahlen.Add(12);
        zahlen.Add(5);

        zahlen[1] = 99;
        zahlen.RemoveAt(0);

        foreach (var i in zahlen)
        {
            Console.WriteLine(i);
        }

        List<string> namen = new() { "Lena", "Markus", "Anna", "Tom" };
        namen.Sort();

        foreach (var n in namen)
        {
            Console.WriteLine(n);
        }

        List<int> eingaben = new();

        Console.WriteLine("Zahlen eingeben: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Zahl {i + 1}: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            eingaben.Add(zahl);
        }

        int summe = 0;
        for (int i = 0; i < eingaben.Count; i++)
        {
            summe += eingaben[i];
        }

        Console.WriteLine(summe);
    }
}

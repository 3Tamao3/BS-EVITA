using System;

class Program
{
    static void Main()
    {
        int[,] zahlen =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
        };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(zahlen[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int[,] multiplikationsTabelle = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                multiplikationsTabelle[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(multiplikationsTabelle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

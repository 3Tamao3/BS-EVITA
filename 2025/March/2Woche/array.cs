using System;

public class Name
{  
  public static void Main(string[] args)
  {
    
    int[] zahlen = new int[5];

    zahlen[0] = 5;
    zahlen[1] = 4;
    zahlen[2] = 2;
    zahlen[3] = 3;
    zahlen[4] = 1;

    for(int i = 0; i < 5;i++)
      Console.Write(zahlen[i]);

    Console.WriteLine("\n");

    int[] zahlen1 = new int[10] {5, 4, 7, 0, 1, 3, 9, 8, 2, 6};

    int ergebnis = 0;
    int i2 = 0;

    while(i2 < zahlen1.Length)
    {
      ergebnis = zahlen1[i2] + ergebnis;
      i2++;
    }
    Console.WriteLine(ergebnis);


    Console.WriteLine("\n");

    int[] zahlen2 = new int[5] {5, 2, 3, 4, 1};

 for (int i3 = 0; i3 < zahlen2.Length - 1; i3++)
        {
            for (int j = 0; j < zahlen2.Length - 1 - i3; j++)
            {
                if (zahlen2[j] > zahlen2[j + 1])
                {
                    // Swap values
                    int temp = zahlen2[j];
                    zahlen2[j] = zahlen2[j + 1];
                    zahlen2[j + 1] = temp;
                }
            }
        }

         Console.WriteLine("Sorted numbers:");
for (int i = 0; i < zahlen2.Length; i++)
        {
            Console.Write(zahlen2[i] + " ");
        }
Console.WriteLine("\n");

  }
}

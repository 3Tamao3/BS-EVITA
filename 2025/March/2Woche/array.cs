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
      Console.WriteLine(zahlen[i]);

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



  }
}

using System;

class test
{
    static void Main(string[] args)
    {
      //1. Aufgabe
      
      for (int i = 0; i < 10; i++)
      {
          Console.Write(i + " ");
      }

      Console.WriteLine("\n");
      
      //2. Aufgabe

      for (int i = 0; i  < 20; i = i + 2)
      {
         Console.Write(i + " "); 
      }

      Console.WriteLine("\n");

      //3. Aufgabe

    int ergebnis = 0;

      for (int i = 0; i < 101; i++)
      {
          ergebnis = ergebnis + i;
      }

      Console.Write("Summe: " + ergebnis);
      Console.WriteLine("\n");

    //4. Aufgabe

    for (int i = 0; i < 50; i = i + 5)
    {
        Console.Write(i + " ");
    }
    
    Console.WriteLine("\n");

    //5. Aufgabe

    for (int i = 0; i != 5; i++)
{
      for (int j= 0; j <= i; j++)
      {
          Console.Write("*");
      }
      Console.Write("\n");
    }

    }
}

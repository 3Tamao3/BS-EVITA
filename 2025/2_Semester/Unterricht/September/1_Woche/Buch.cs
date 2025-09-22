using System;

namespace Konstruktor
{
    public class Buch
    {
      public string Titel { get; set; }
      public string Autor { get; set; }

      public Buch(string titel, string autor)
      {
        Titel = titel;
        Autor = autor;
      }

      public void ZeigeInfo()
      {
        Console.WriteLine(Titel + " " + Autor);
      }
    }
}


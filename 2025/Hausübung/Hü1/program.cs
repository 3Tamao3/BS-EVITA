//Aufgabe 1
using System;

public class Buch
{
    public string Titel { get; set; }
    public string Autor { get; set; }
    public int Seiten { get; set; }

    public void Ausgabe()
    {
        Console.WriteLine("Titel-> " + Titel);
        Console.WriteLine("Autor-> " + Autor);
        Console.WriteLine("Seiten-> " + Seiten);
    }

    public static void Main(string[] args)
    {
        Buch buch1 = new Buch();
        buch1.Titel = "Harry Potter";
        buch1.Autor = "J.K. Rowling";
        buch1.Seiten = 350;
        buch1.Ausgabe();

        Buch buch2 = new Buch();
        buch2.Titel = "Tschick";
        buch2.Autor = "Wolfgang Herrndorf";
        buch2.Seiten = 256;
        buch2.Ausgabe();
    }
}

//Aufgabe 2
using System;

public class Buch
{
    public string Titel { get; set; }
    public string Autor { get; set; }
    public int Seiten { get; set; }

    public void Ausgabe()
    {
        Console.WriteLine("Titel-> " + Titel);
        Console.WriteLine("Autor-> " + Autor);
        Console.WriteLine("Seiten-> " + Seiten);
    }
}

public class Program
{
    static Buch[] AddOneSpaceToArray(Buch[] smallerArray)
    {
        Buch[] biggerArray = new Buch[smallerArray.Length + 1];
        for (int i = 0; i < smallerArray.Length; i++)
            biggerArray[i] = smallerArray[i];
        return biggerArray;
    }

    public static void Main(string[] args)
    {
        bool loop = true;

        Buch[] buecher = new Buch[0];

        while (loop)
        {
            Console.Write("Titel: ");
            string titel = Console.ReadLine();
            
            if (titel == "exit")
            {
                loop = false;
                break;
            }
            
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            
            Console.Write("Seiten: ");
            int seiten = Convert.ToInt32(Console.ReadLine());

            buecher = AddOneSpaceToArray(buecher);

            buecher[buecher.Length - 1] = new Buch {
                Titel  = titel,
                Autor  = autor,
                Seiten = seiten
            };
        }
            Console.WriteLine("\nBücher: \n");
            foreach (var buch in buecher)
            buch.Ausgabe();
    }
}



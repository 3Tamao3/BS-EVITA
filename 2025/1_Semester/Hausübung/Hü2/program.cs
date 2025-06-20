Aufgabe 1:
------------------------------------------------------------
using System;

public class Rechteck
{
    public double Breite { get; set; }
    public double Hoehe { get; set; }

    public Rechteck(double breite, double hoehe)
    {
        Breite = breite;
        Hoehe = hoehe;
    }

    public double Flaeche()
    {
        return (Breite * Hoehe);
    }

    public double Umfang()
    {
        return ((2 * Breite) + (2 * Hoehe));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rechteck rechteck1 = new(2, 5);

        Console.WriteLine(rechteck1.Flaeche());
        Console.WriteLine(rechteck1.Umfang());
    }
}






Aufgabe 2
----------------------------------------
using System;

public class Bankkonto
{
    public string Kontoinhaber { get; set; }
    public decimal Kontostand { get; private set; }

    public void Einzahlen(decimal betrag)
    {
        Kontostand = Kontostand + betrag;

        Console.WriteLine(Kontostand);
    }

    public void Abheben(decimal betrag)
    {
        if (Kontostand < betrag)
        {
            Console.WriteLine("Nicht genug");
        }
        else
        {
            Kontostand = Kontostand - betrag;
        }
        Console.WriteLine(Kontostand);
    }

    public Bankkonto(string kontoinhaber, decimal kontostand)
    {
        Kontoinhaber = kontoinhaber;
        Kontostand = kontostand;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bankkonto user1 = new("Rene", 100);

        user1.Einzahlen(20);
        user1.Abheben(40);
    }
}




Aufgabe 3
----------------------------------------
using System;

public class Auto
{
    public string Marke { get; set; }
    public string Modell { get; set; }
    public int Baujahr { get; set; }

    public Auto()
    {
        Marke = "Unbekannt";
        Modell = "Standard";
        Baujahr = 0;
    }

    public Auto(string marke, string modell, int baujahr)
    {
        Marke = marke;
        Modell = modell;
        Baujahr = baujahr;
    }

    public void StarteMotor()
    {
        Console.WriteLine(
            Marke + " " + Modell + " " + "(" + Baujahr + ") startet jetzt den Motor!!!!"
        );
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Auto auto1 = new();
        Auto auto2 = new("BMW", "M4 Comp", 2025);

        auto1.StarteMotor();
        auto2.StarteMotor();
    }
}




using System;

public enum Wochentag
{
    Montag,
    Dienstag,
    Mittwoch,
    Donnerstag,
    Freitag,
    Samstag,
    Sonntag
}

enum Jahreszeit
{
    Frühling,
    Sommer,
    Herbst,
    Winter
}

enum Ampel
{
    Rot,
    Gelb,
    Grün
}

public class Program
{
    public static void Main()
    {
        Wochentag heute = Wochentag.Mittwoch;
        Jahreszeit aktuelleJahreszeit = Jahreszeit.Sommer;
        int zahl = (int)aktuelleJahreszeit;
        Ampel aktuelleFarbe = Ampel.Rot;

        Console.WriteLine($"Heute ist {heute}");
        Console.WriteLine($"Die aktuelle Jahreszeit ist: {aktuelleJahreszeit}");
        Console.WriteLine($"{aktuelleJahreszeit} ist >>> {zahl}");
        switch (aktuelleFarbe)
        {
            case Ampel.Rot:
                Console.WriteLine("Stopp!");
                break;
            case Ampel.Gelb:
                Console.WriteLine("Warten…");
                break;
            case Ampel.Grün:
                Console.WriteLine("Fahren!");
                break;
        }
    }
}



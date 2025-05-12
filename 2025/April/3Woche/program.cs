using System;

public class Name
{
    public static void Main(string[] args)
    {
        int auswahl = Convert.ToInt32(Console.ReadLine());

        switch (auswahl)
        {
            case 1:
                Lieblingszahl();
                break;

            case 2:
                NameBegrueßen();
                break;

            case 3:
                AlterVerdoppeln();
                break;

            case 4:
                NameAnal();
                break;

            case 5:
                LangeNamen();
                break;

            case 6:
                StimmenZählen();
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    static void Lieblingszahl()
    {
        int[] zahlen = { 2, 3, 4, 5, 6 };

        foreach (int i in zahlen)
        {
            Console.WriteLine("Lieblingszahl: " + i);
        }
    }

    static void NameBegrueßen()
    {
        string[] namen = { "Anna", "Felix", "Lisa", "Tomas", "Aylin", "Fatima", "Jasmin" };

        foreach (string i in namen)
        {
            Console.WriteLine("Hallo " + i + "! Schön dich zu sehen :D");
        }
    }

    static void AlterVerdoppeln()
    {
        int[] alter = { 10, 11, 12, 13, 16 };

        foreach (int i in alter)
        {
            Console.WriteLine("Alter in 14 Jahren: " + (i + 14));
        }
    }

    static void NameAnal()
    {
        string[] namen = { "test", "Larissa", "idk", "Alexander" };

        foreach (string i in namen)
        {
            Console.WriteLine(i + " " + i.Length);
        }
    }

    static void LangeNamen()
    {
        string[] namen = { "Alex", "Alexander", "Markus", "lisa", "Bob", "Tomas" };

        foreach (string i in namen)
        {
            if (i.Length >= 5)
            {
                Console.WriteLine(i);
            }
        }
    }

    
static void StimmenZählen()
{
    string[] faecher = { "Mathe", "Deutsch", "Mathe", "Informatik", "Englisch", "Mathe", "Informatik" };
    string[] faecherbezeichnung = { "Mathe", "Deutsch", "Informatik" };

    // Enum mit korrekter Zuordnung
    enum Faecher
    {
        Mathe = 0,
        Deutsch = 1,
        Informatik = 2
    }

    int[] zaehler = new int[3]; // für Mathe, Deutsch, Informatik

    // Zählen
    foreach (string i in faecher)
    {
        switch (i)
        {
            case "Mathe":
                zaehler[(int)Faecher.Mathe]++;
                break;
            case "Deutsch":
                zaehler[(int)Faecher.Deutsch]++;
                break;
            case "Informatik":
                zaehler[(int)Faecher.Informatik]++;
                break;
        }
    }

    // Ausgabe
    for (int count = 0; count < faecherbezeichnung.Length; count++)
    {
        Console.WriteLine($"{faecherbezeichnung[count]}: {zaehler[count]}");
    }
}

}

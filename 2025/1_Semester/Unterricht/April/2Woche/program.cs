using System;

class idk
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "1 - Notendurchschnitt | 2 - Wassertemparatur | 3 - Tagesbegrüßung | 4 - Würfelspiel | 5 - Kopfrechentrainer"
        );

        String auswahl = Console.ReadLine();

        switch (auswahl)
        {
            case "1":
                Notendurchschnitt();
                break;

            case "2":
                Wassertemparatur();
                break;

            case "3":
                Tagesbegrueßung();
                break;

            case "4":
                Würfelspiel();
                break;

            case "5":
                Kopfrechentrainer();
                break;
        }
    }

    static void Notendurchschnitt()
    {
        Console.WriteLine("Notendurchschnitt\n");

        Console.WriteLine("Gib eine Zahl ein: ");
        decimal note1 = Convert.D(Console.ReadLine());
        Console.WriteLine("Gib eine Zahl ein: ");
        decimal note2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Gib eine Zahl ein: ");
        decimal note3 = Convert.ToDouble(Console.ReadLine());

        if ((note1 + note2 + note3) / 3 <= 2.5m)
        {
            Console.WriteLine("Sehr Gut!!!");
            Console.WriteLine("Notendurchschnitt: " + (note1 + note2 + note3) / 3);
        }
        else
        {
            Console.WriteLine("Notendurchschnitt: " + (note1 + note2 + note3) / 3);
        }
    }

    static void Wassertemparatur()
    {
        Console.WriteLine("Wassertemparatur");

        Console.WriteLine("Gib eine Zahl ein: ");
        int tempInput = Convert.ToInt32(Console.ReadLine());

        if (tempInput >= 100)
        {
            System.Console.WriteLine("Gasförmig");
        }
        else if (tempInput >= 0)
        {
            System.Console.WriteLine("Flüssig");
        }
        else if (tempInput < 0)
        {
            System.Console.WriteLine("Fest");
        }
    }

    static void Tagesbegrueßung()
    {
        Console.WriteLine("Tagesbegrüßung");

        Console.WriteLine("Wie viel Uhr ist es bei dir (Stunde)");
        int stunde = Convert.ToInt32(Console.ReadLine());

        if (stunde > 17)
        {
            Console.WriteLine("Guten Abend");
        }
        else if (stunde > 11)
        {
            Console.WriteLine("Guten Tag");
        }
        else if (stunde > 4)
        {
            Console.WriteLine("Guten Morgen");
        }
        else
        {
            Console.WriteLine("Gute Nacht");
        }
    }

    static void Würfelspiel()
    {
        Random random = new Random();

        int würfel1 = random.Next(1, 7);
        int würfel2 = random.Next(1, 7);

        if (würfel1 == würfel2)
        {
            Console.WriteLine("Würfel: " + würfel1 + " " + würfel2);
            Console.WriteLine("Pasch!");
        }
        else if (würfel1 + würfel2 == 7)
        {
            Console.WriteLine("Würfel: " + würfel1 + " " + würfel2);
            Console.WriteLine("Siebener");
        }
        else
        {
            Console.WriteLine("Würfel: " + würfel1 + " " + würfel2);
            Console.WriteLine("Summe: " + (würfel1 + würfel2));
        }
    }

    static void Kopfrechentrainer()
    {
        Random random = new Random();

        int zahl1 = random.Next(1, 50);
        int zahl2 = random.Next(1, 50);

        Console.WriteLine(zahl1 + " + " + zahl2);
        Console.WriteLine("Was ist das Ergebnis?");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == zahl1 + zahl2)
        {
            Console.WriteLine("RICHTIG");
        }
        else
        {
            Console.WriteLine(zahl1 + zahl2 + " War das Ergebnis");
        }
    }
}

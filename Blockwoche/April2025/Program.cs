using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = GGT | 2 = Einmaleins in Tabellenform | 3 = Wort-Zähler | 4 = Fibonacci (1 - 10) | \n" +
                "5 = Random Motivationsspruch | 6 = Größte Zahl | 7 = Münzen/Schein-Rechner | 8 = Pyramide\n| 9 = Würfelspiel | 10 = Ratespiel"
                );
            Console.Write("Wähle aus was du durchführen möchtest: ");
            int auswahl = Convert.ToInt32(Console.ReadLine());
            switch (auswahl)
            {
                case 1:
                    Console.Write("Gib eine Zahl ein: ");
                    int zahl1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Gib eine weitere Zahl ein: ");
                    int zahl2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(GGT(zahl1, zahl2));
                    break;
                case 2:
                    Einmaleins();
                    break;
                case 3:
                    Console.Write("Gib einen Text ein: ");
                    string sentence = Console.ReadLine();
                    Console.WriteLine();
                    CountWords(sentence);
                    break;
                case 4:
                    Fibonacci();
                    break;
                case 5:
                    Motivationssprueche();
                    break;
                case 6:
                    ArrayVergrößern();
                    break;
                case 7:
                    Console.Write("Gib ein Betrag ein (zb 273.34 Euro): ");
                    decimal betrag = Convert.ToDecimal(Console.ReadLine());
                    MünzenScheineRechner(betrag);
                    break;
                case 8:
                    Console.Write("Input a Number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Pyramide(n);
                    break;
                case 9:
                    WürfelDuell();
                    break;
                case 10:
                    Zahlenraten();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        //Aufgabe 5
        static int GGT(int zahl1, int zahl2)
        {

            while (zahl2 != 0)
            {
                int temporary = zahl2;
                zahl2 = zahl1 % zahl2;
                zahl1 = temporary;
            }
            return zahl1;
        }
        //Aufgabe 6
        static void Einmaleins()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j * i + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        //Aufgabe 7

        static void CountWords(String text)
        {
            char separator = ' ';
            string[] stringArray = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == null)
                    continue;

                string currentWord = stringArray[i];
                for (int j = 0; j < stringArray.Length; j++)
                {
                    if (currentWord == stringArray[j])
                    {
                        count++;
                        stringArray[j] = null;
                    }
                }

                Console.WriteLine(count + " " + currentWord);
                count = 0;
            }
        }

        //Aufgabe 8
        static void Fibonacci()
        {
            int ergebnis;
            int a = 0;
            int b = 1;
            for (int i = 0; i < 10; i++)
            {
                ergebnis = b;
                b = a + b;
                a = ergebnis;
                Console.WriteLine(b);
            }
        }
        //Aufgabe 9
        static void Motivationssprueche()
        {
            String[] sprueche =
                {
                "\"It’s not about being fearless. It’s about taking action even when you're scared.\" – Yuji Itadori",
                "\"If you don’t like the hand that fate’s dealt you with, fight for a new one.\" – Satoru Gojo",
                "\"The best way to become stronger is to be with others who are stronger.\" – Megumi Fushiguro",
                "\"The only thing you can do is live, even if you're hated, even if you're betrayed.\" – Kento Nanami",
                "\"Don’t you think I want to be with my family? But I have to do this, for the people I love.\" – Yuji Itadori",
                "\"I’ll never give up, no matter how many times I fail.\" – Tanjiro Kamado",
                "\"A person's heart is like a flower. You have to nurture it to make it bloom.\" – Tanjiro Kamado",
                "\"It's not about being the strongest. It's about fighting for what's right.\" – Kanao Tsuyuri",
                "\"Even if you’re small, even if you’re weak, there’s always something you can do.\" – Zenitsu "
                };
            Random random = new Random();
            int start = random.Next(0, sprueche.Length);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n" + sprueche[start]);
            Console.ResetColor();
        }
        //Aufgabe 10
        static void ArrayVergrößern()
        {
            int[] zahlenArray = { };
            char loopCancelRequest = 'y';
            while (loopCancelRequest == 'y')
            {
                Console.WriteLine("Möchtest du eine weitere Zahl hinzufügen?");
                Console.WriteLine("(y = yes || n = no): ");
                loopCancelRequest = Convert.ToChar(Console.ReadLine());
                if (loopCancelRequest == 'y')
                {
                    Console.WriteLine("Gib eine Zahl ein die in die Array soll: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    zahlenArray = AddOneSpaceToArray(zahlenArray);
                    zahlenArray[zahlenArray.Length - 1] = userInput;
                }
                else if (loopCancelRequest == 'n')
                {
                    int größteZahl = 0;
                    foreach (int zahl in zahlenArray)
                    {
                        if (zahl > größteZahl)
                        {
                            größteZahl = zahl;
                        }
                    }
                    Console.Write("Array: ");
                    for (int i = 0; i < zahlenArray.Length; i++)
                    {
                        Console.Write(zahlenArray[i] + ", ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Die größte Zahl ist: " + größteZahl);
                }
                else
                {
                    Console.WriteLine("Invalid Input :P");
                }
            }
        }

        static int[] AddOneSpaceToArray(int[] smallerArray)
        {
            int[] biggerArray = new int[smallerArray.Length + 1];
            int i = 0;

            foreach (int wert in smallerArray)
            {
                biggerArray[i] = wert;
                i++;
            }
            return biggerArray;
        }

        //Aufgabe 11
        static void MünzenScheineRechner(decimal geld)
        {
            decimal[] muenzenUndScheine = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5m, 0.2m, 0.1m, 0.05m, 0.02m, 0.01m };
            for (int i = 0; i < muenzenUndScheine.Length; i++)
            {
                int anzahl = (int)(geld / muenzenUndScheine[i]);
                if (anzahl > 0)
                {
                    Console.WriteLine(anzahl + " " + muenzenUndScheine[i] + " Euro");
                    geld -= anzahl * muenzenUndScheine[i];
                }
            }
        }
        //Aufgabe 12
        static void Pyramide(int n)
        {
            int number = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (number > n)
                        break;
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine(" ");
            }
        }
        //Aufgabe 13
        static void WürfelDuell()
        {
            Random random = new Random();
            int wuerfelPlayer1;
            int wuerfelPlayer2;
            int wuerfelGegner1;
            int wuerfelGegner2;
            int playerScore = 0;
            int gegnerScore = 0;
            for (int i = 0; i < 5; i++)
            {
                wuerfelPlayer1 = random.Next(1, 7);
                wuerfelPlayer2 = random.Next(1, 7);
                wuerfelGegner1 = random.Next(1, 7);
                wuerfelGegner2 = random.Next(1, 7);
                Console.WriteLine("Player hat " + wuerfelPlayer1 + ", " + wuerfelPlayer2 + " gewürfelt");
                Console.WriteLine("Gegner hat " + wuerfelGegner1 + ", " + wuerfelPlayer2 + " gewürfelt");
                if (wuerfelPlayer1 + wuerfelPlayer2 == wuerfelGegner1 + wuerfelGegner2)
                {
                    Console.WriteLine("Gleichstand");
                }
                else if (wuerfelPlayer1 + wuerfelPlayer2 > wuerfelGegner1 + wuerfelGegner2)
                {
                    Console.WriteLine("Player hat diese Runde gewonnen. +150 Punkte");
                    playerScore += 150;
                }
                else if (wuerfelPlayer1 + wuerfelPlayer2 < wuerfelGegner1 + wuerfelGegner2)
                {
                    Console.WriteLine("Gegner hat diese Runde gewonnen. +150 Punkte");
                    gegnerScore += 150;
                }
            }
            if (playerScore > gegnerScore)
            {
                Console.WriteLine("Player hat Gewonnen. Score: " + playerScore);
            }
            else if (playerScore < gegnerScore)
            {
                Console.WriteLine("Gegner hat Gewonnen. Score: " + gegnerScore);
            }
        }
        //Aufgabe 14
        static void Zahlenraten()
        {
            Random random = new Random();
            int trys = 0;
            int zahl = random.Next(1, 1000);
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Gib eine Zahl ein: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == zahl)
                {
                    Console.WriteLine("RICHTIG!!! LETS GOOOOOO!!!");
                    loop = false;
                    break;
                }
                else if (userInput < zahl)
                {
                    Console.WriteLine("Die Zahl die du suchst ist größer! Try again!");
                    trys++;
                }
                else if (userInput > zahl)
                {
                    Console.WriteLine("Die Zahl die du suchst ist kleiner! Try again!");
                    trys++;
                }
            }
            Console.WriteLine("Du hast " + trys + " Versuche benötigt");
        }
    }
}
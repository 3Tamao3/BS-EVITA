

using System.Linq.Expressions;
using System.Threading.Channels;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wähl was du machen möchtest:");
            Console.WriteLine("1. Zahlenraten mit Versuche-Limit");
            Console.WriteLine("2. Taschenrechner mit Schleifen");
            Console.WriteLine("3. FizzBuzz Deluxe");
            Console.WriteLine("4. Geheime PIN-Abfrage mit begrenzten Versuchen");
            Console.WriteLine("5. Einfache Primzahlenprüfung");
            Console.WriteLine("6. Umrechnung von Notenpunkten in Schulnoten");
            Console.WriteLine("7. Zahlensystem-Umwandler (Dezimal zu Binär)");
            Console.WriteLine("8. Fakulät einer Zahl berechnen");
            Console.WriteLine("9. Palindrom-Checker für Wörter");
            Console.WriteLine("10. Einfache Uhrzeitprüfung");
            Console.Write("Auswahl (1 - 10)-> ");
            int wahl = Convert.ToInt32(Console.ReadLine());



            switch (wahl)
            {
                case 1:
                    Zahlenraten();
                    break;
                case 2:
                    Taschenrechner();
                    break;
                case 3:
                    FizzBuzz();
                    break;
                case 4:
                    GeheimPin();
                    break;
                case 5:
                    Primzahlenprüfung();
                    break;
                case 6:
                    UmrechnungNotenpunkte();
                    break;
                case 7:
                    ZahlensystemUmwandler();
                    break;
                case 8:
                    Fakulät();
                    break;
                case 9:
                    PalindromChecker();
                    break;
                case 10:
                    Uhrzeitprüfung();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }



            static void Zahlenraten()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");

                int zahl = 7;
                Console.WriteLine("DU hast nur 5 Versuche!");
                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine("Gib eine Zahl ein: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == zahl)
                    {
                        Console.WriteLine("RICHTIG!!! LETS GOOOOOO!!!");
                        Console.WriteLine("*******************************************");
                        break;
                    }
                    else if (userInput < zahl)
                    {
                        Console.WriteLine("Die Zahl die du suchst ist größer! Try again!");
                        i++;
                    }
                    else if (userInput > zahl)
                    {
                        Console.WriteLine("Die Zahl die du suchst ist kleiner! Try again!");
                        i++;

                    }
                }
                Console.WriteLine("Alle Versuche verbraucht! Die richtige Zahl war: " + zahl);
            }

            static void Taschenrechner()
            {

                Console.Clear();
                Console.WriteLine("****************************************************************");
                Console.WriteLine(" Gib eine Zahl ein: ");
                double zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" Gib eine weitere Zahl ein: ");
                double zahl2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Gib ein Operator ein(+,  -,  *,  / ): ");
                String operatoren = Console.ReadLine();

                switch (operatoren)
                {
                    case "+":
                        Console.WriteLine(zahl1 + zahl2);
                        break;

                    case "-":
                        Console.WriteLine(zahl1 - zahl2);
                        break;

                    case "*":
                        Console.WriteLine(zahl1 * zahl2);
                        break;

                    case "/":
                        Console.WriteLine(zahl1 / zahl2);
                        break;

                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }

                Console.WriteLine("Möchtest du eine weitere Rechnung durchführen? (y = Ja, n = No)");
                string repeat = Console.ReadLine();
                if (repeat == "y")
                {
                    Taschenrechner();
                }
                else if (repeat == "n")
                {
                    Console.WriteLine("Thx for using!");
                    Console.WriteLine("****************************************************************");
                }

            }

            static void FizzBuzz()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                int i = 0;
                while (i < 100)
                {
                    i++;

                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("*******************************************");

            }

            static void GeheimPin()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                string pin = "1234";
                int trys = 3;

                while (trys > 0)
                {
                    Console.WriteLine("Guess PIN: ");
                    string userInput = Console.ReadLine();


                    int count = userInput.Length;

                    if (count != 4)
                    {
                        Console.WriteLine("Its a 4-digit pin! Try Again!");
                        trys++;
                    }


                    if (userInput != pin)
                    {
                        trys--;
                        Console.WriteLine("Falsche PIN! Noch " + trys + " Versuche übrig.");
                    }
                    else
                    {
                        trys = 0;
                        Console.WriteLine("Richtig!!!1");
                    }


                }
                Console.WriteLine("*******************************************");
            }

            static void Primzahlenprüfung()
            {
                Console.Clear();
                Console.WriteLine("*******************************************\n");
                Console.WriteLine("Welche Zahl möchtest du überprüfen?->");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 2 || userInput == 3)
                {
                    Console.WriteLine("Ist eine Primzahl");
                }
                else if (userInput % 2 >= 1 && userInput % 3 >= 1)
                {
                    Console.WriteLine("Ist eine Primzahl");
                }
                else
                {
                    Console.WriteLine("Ist KEINE Primzahl");
                }
                Console.WriteLine("\n*******************************************");
                //Meine Theorie
                //https://www.matheretter.de/wiki/primzahlen-ermitteln
            }

            static void UmrechnungNotenpunkte()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Gib deine Punkte Anzahl an-> ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case > 100:
                        Console.WriteLine("INVALID NUMBER");
                        break;

                    case >= 90:
                        Console.WriteLine("Sehr gut");
                        break;

                    case >= 80:
                        Console.WriteLine("Gut");
                        break;

                    case >= 70:
                        Console.WriteLine("Befriedeigend");
                        break;

                    case >= 60:
                        Console.WriteLine("Genügend");
                        break;

                    case >= 0:
                        Console.WriteLine("Nicht Genügend");
                        break;

                    default:
                        Console.WriteLine("INVALID NUMBER");
                        break;

                }
                Console.WriteLine("*******************************************");
            }

            static void ZahlensystemUmwandler()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Gib eine Zahl ein die in Binär umgewandelt werden soll->");
                int zahl = Convert.ToInt32(Console.ReadLine());

                while (zahl > 0)
                {
                    if (zahl % 2 >= 1)
                    {
                        Console.Write(1);
                    }
                    else if (zahl % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    zahl = zahl / 2;
                }

                Console.WriteLine("\n*******************************************");
            }

            static void Fakulät()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Gib eine Zahl ein um sie zu fakultät(ieren)->");
                int zahl = Convert.ToInt32(Console.ReadLine());
                int loop = 0;
                int zahlErgebnis = zahl;
                while ((loop + 1) < zahlErgebnis)
                {
                    loop++;
                    zahl = zahl * loop;
                    Console.WriteLine(zahl);

                }

                Console.WriteLine("*******************************************");
            }

            static void PalindromChecker()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Palindrom-Checker->");
                string userInput = Console.ReadLine();
                char[] charArray = new char[userInput.Length];


                for (int i = 0; i < userInput.Length; i++)
                {
                    charArray[i] = userInput[i]; //Hallo
                }

                char[] charArrayReverse = new char[userInput.Length];
                Array.Copy(charArray, charArrayReverse, charArray.Length);
                Array.Reverse(charArrayReverse);



                for (int i = 0; i < charArray.Length; i++)
                {
                    if (charArray[i] != charArrayReverse[i])
                    {
                        Console.WriteLine("Its not a Palindrom");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Is a Palindrom");
                        break;
                    }
                }
                Console.WriteLine("*******************************************");
            }

            static void Uhrzeitprüfung()
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Gib Stunden ein->");
                int stunde = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Gib Minuten ein->");
                int minute = Convert.ToInt16(Console.ReadLine());

                if (stunde < 0 || stunde >= 24)
                {
                    Console.WriteLine("Stunde Input ist Invalid");

                }
                else if (minute < 0 || minute >= 60)
                {
                    Console.WriteLine("Minuten Input ist Invalid");
                }
                else
                {
                    Console.WriteLine("Die Uhrzeit ist-> " + stunde + ":" + minute);
                }
                Console.WriteLine("*******************************************");
            }
        }
    }
}
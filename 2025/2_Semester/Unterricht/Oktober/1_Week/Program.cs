using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

                Dictionary<string, string> myDictionary = new Dictionary<string, string>();
                myDictionary.Add("Max", "+43 664 1234567");
                myDictionary.Add("Lisa", "+43 664 7654321");
                myDictionary.Add("Eva", "+43 664 9876543");

                while (true)
                {
                Console.WriteLine("1. Telefonnummer suchen");
                Console.WriteLine("2. Telefonnummer hinzufügen");
                Console.WriteLine("3. Telefonnummer löschen");
                Console.WriteLine("4. Telefonbuch anzeigen");
                Console.Write("->");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Search();
                        break;
                    case 2:
                        AddPhone();
                        break;
                    case 3:
                        DeletePhone();
                        break;
                    case 4:
                        DisplayPhonebook();
                        break;
                    default:
                        Console.WriteLine($"Falsche Eingabe");
                        break;
                }
                void Search()
                {
                    Console.Write("Name suchen: ");
                    string userInput = Console.ReadLine();

                    if (myDictionary.ContainsKey(userInput))
                    {
                        Console.WriteLine($"Telefonnummer von {userInput}: {myDictionary[userInput]}");
                    }
                    else
                    {
                        Console.WriteLine($"Keine Telefonnummer gefunden für {userInput}");
                    }
                }

                void AddPhone()
                {
                    Console.Write("Name hinzufügen: ");
                    string name = Console.ReadLine();

                    Console.Write("Telefonnummer hinzufügen: ");
                    string phone = Console.ReadLine();

                    myDictionary.Add(name, phone);

                    Console.WriteLine($"{name}, {phone} wurde hinzugefügt");
                }

                void DeletePhone()
                {
                    Console.Write("Name löschen: ");
                    string name = Console.ReadLine();

                    if (myDictionary.ContainsKey(name))
                    {
                        myDictionary.Remove(name);
                        Console.WriteLine($"{name} wurde gelöscht");
                    }
                    else
                    {
                        Console.WriteLine($"Kein Eintrag gefunden für {name}");
                    }
                }

                void DisplayPhonebook()
                {
                    foreach (var entry in myDictionary)
                    {
                        Console.WriteLine($"{entry.Key}, {entry.Value}");
                    }
                }

            }

        }
    }
}

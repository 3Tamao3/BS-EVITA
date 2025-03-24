using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Sprachen (de = deutsch, en = english, fr = french, pl = polish, sv = slovakia, gr = greek)");
        Console.Write("in welche sprache willst du begrüßt werden?");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
          case "de":
            Console.WriteLine("Hallo");
            break;

          case "en":
            System.Console.WriteLine("Hello");
            break;

          case "fr":
            Console.WriteLine("Bonjur");
            break;

          case "pl":
            Console.WriteLine("Witam");
            break;

          case "sv":
            Console.WriteLine("Ahoj");
            break;

          case "gr":
            Console.WriteLine("Geiá sou");
            break;

          default:
            Console.WriteLine("Invalid Input");
            break;

        }
    }
}

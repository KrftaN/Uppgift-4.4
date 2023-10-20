using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main(string[] args)
    {
        bool färdig = false;

        do
        {
            Console.WriteLine("Välj ett av följande alternativen.");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");
            string userInput = Console.ReadLine();
            try
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Skriv två tal separerat med ett mellanslag:");
                        string[] nummer = Console.ReadLine().Split(" ");
                        int num1 = Convert.ToInt32(nummer[0]);
                        int num2 = Convert.ToInt32(nummer[1]);
                        Console.WriteLine($"Svaret är {num1 - num2}");

                        break;

                    case "2":
                        Console.WriteLine("Skriv två tal separerat med ett mellanslag:");
                        string[] userNummer = Console.ReadLine().Split(" ");
                        int nummer1 = Convert.ToInt32(userNummer[0]);
                        int nummer2 = Convert.ToInt32(userNummer[1]);
                        Console.WriteLine($"Svaret är {nummer1 / nummer2}");
                        break;
                    case "3":
                        färdig = true;
                        break;
                    default:
                        Console.WriteLine($"{userInput} är inte ett giltigt svar.");

                        break;
                }
            }
            catch
            {
                Console.WriteLine("Någonting gick ");
            }



        } while (färdig == false);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueExecution = true;

        while (continueExecution)
        {
            Console.Clear();

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Fibonacci");
            Console.WriteLine("3 - DailyRevenue");
            Console.WriteLine("4 - StateRevenue");
            Console.WriteLine("5 - ReverseString");
            Console.WriteLine("0 - Exit\n");

            Console.Write("Choose a challenge: ");
            string? choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    Sum.Execute();
                    break;

                case "2":
                    Fibonacci.Execute();
                    break;

                case "3":
                    DailyRevenue.Execute();
                    break;

                case "4":
                    StateRevenue.Execute();
                    break;

                case "5":
                    ReverseString.Execute();
                    break;

                case "0":
                    continueExecution = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            if (choice != "0")
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
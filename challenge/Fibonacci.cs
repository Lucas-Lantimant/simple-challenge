using System;

public class Fibonacci
{
    public static void Execute()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        if (input == null || !int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
            return;
        }

        if (number == 0 || number == 1)
        {
            Console.WriteLine("The number belongs to the Fibonacci sequence.");
            return;
        }

        int fib1 = 0, fib2 = 1;

        while (fib2 < number)
        {
            int fibNext = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibNext;
        }

        if (fib2 == number)
        {
            Console.WriteLine("The number belongs to the Fibonacci sequence.");
        }
        else
        {
            Console.WriteLine("The number does not belong to the Fibonacci sequence.");
        }
    }
}

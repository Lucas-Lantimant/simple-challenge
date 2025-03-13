using System;

public class Sum
{
    public static void Execute()  
    {
        int INDEX = 13, SUM = 0, K = 0;

        while (K < INDEX)
        {
            K = K + 1;
            SUM = SUM + K;
        }

        Console.WriteLine("The final value of the variable SUM is: " + SUM);
    }
}

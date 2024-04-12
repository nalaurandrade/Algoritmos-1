using System;

class Sum 
{
    static void Main() 
    {
        int total = 0;

        for (int number = 2; number <= 10; number += 2)
        {
            total += number;
        }

        Console.WriteLine($"Sum is {total}");
    }
}

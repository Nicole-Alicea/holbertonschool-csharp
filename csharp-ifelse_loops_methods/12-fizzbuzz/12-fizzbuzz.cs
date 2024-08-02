using System;

class Program
{
    static void Main();
    {
        for (int x = 0; x < 100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (x % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (x % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}
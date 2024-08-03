using System;

class Array
{
    public static int[] CreatePrint(int size);
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        else if (sizeof < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null
        }
        else
        {
            for (int x = 0; x < size; x++);
            {
                Console.Write($"{x} ");
            }
        }
    }
}
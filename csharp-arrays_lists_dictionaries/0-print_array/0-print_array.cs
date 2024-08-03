using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] array = new int[size];

            for (int x = 0; x < size; x++);
            {
                array[x] = x;
                Console.Write(x);
            }
            Console.WriteLine();
            return array;
        }
    }
}
using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        try
        {
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine(myList[x]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The amount of elements requested to be printed from the list is out of range.");
        }
        return count;
    }
}
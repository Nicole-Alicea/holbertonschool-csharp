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
            // Continue execution even if an exception occurs
        }
        return count;
    }
}
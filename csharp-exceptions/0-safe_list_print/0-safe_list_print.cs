using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        int x = 0;
        
        for(; x < n; x++)
        try
        {
            Console.WriteLine(myList[x]);
            count++;
        }
        catch
        {
            return count;
        }
        return count;
    }
}
using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        for (int x = 0; x < n; x++)
        {
            try
            {
                Console.WriteLine(myList[x]);
            }
            catch
            {
                return x;
            }
        }
        return x;
    }
}
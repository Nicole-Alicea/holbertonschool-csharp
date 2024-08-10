using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();

        if (size < 0)
        {
            return llist;
        }

        for (int x = 0; x < size; x++)
        {
            llist.AddLast(x);
            Console.WriteLine(x);
        }

        return llist;
    }
}
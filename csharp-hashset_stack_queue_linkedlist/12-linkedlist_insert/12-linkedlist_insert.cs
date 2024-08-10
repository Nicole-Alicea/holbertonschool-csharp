using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;

        while (current != null && current.Value < n)
        {
            current = current.Next;
        }

        if (current == null)
        {
            return myLList.AddLast(n);
        }
        else
        {
            return myLList.AddBefore(current, n);
        }
    }
}
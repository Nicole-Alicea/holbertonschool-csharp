using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        // Check if the index is out of range
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        // Create a new list to store the result
        List<int> updatedList = new List<int>(myList.Count - 1);

        // Add all elements except the one at the specified index
        for (int x = 0; x < myList.Count; x++)
        {
            if (x != index)
            {
                updatedList.Add(myList[x]);
            }
        }

        return updatedList;
    }
}
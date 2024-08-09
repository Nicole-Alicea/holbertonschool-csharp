using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Creates a HashSet that will store the common elements in both lists
        HashSet<int> commonIntegers = new HashSet<int>();

        // Iterates through the first list
        foreach (int integer in list1)
        {
            // If the integer is also in the second list, it will be added to the HashSet
            if (list2.Contains(integer))
            {
                commonIntegers.Add(integer);
            }
        }
        // Converts HashSet to a List
        List<int> sortedList = new List<int>(commonIntegers);

        // Sorts the list
        sortedList.Sort();

        return sortedList;
    }
}
using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // The HashSets will store the unique integers in each list
        HashSet<int> differentIntegers1 = new HashSet<int>(list1);
        HashSet<int> differentIntegers2 = new HashSet<int>(list2);

        // Creates a list that will store the different integers
        List<int> diffIntegers = new List<int>();

        // This will add the integers that are in differentIntegers1 but not in differentIntegers2
        foreach (int integer in differentIntegers1)
        {
            if (!differentIntegers2.Contains(integer))
            {
                diffIntegers.Add(integer);
            }
        }

        // This will add the integers that are in differentIntegers2 but not in differentIntegers1
        foreach (int integer in differentIntegers2)
        {
            if (!differentIntegers1.Contains(integer))
            {
                diffIntegers.Add(integer);
            }
        }
        // Will return the sorted integers        
        return diffIntegers.Sort();
    }
}
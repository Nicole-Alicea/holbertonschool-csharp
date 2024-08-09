using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        // HashSets contain only unique elements
        HashSet<int> uniqueIntegers = new HashSet<int>(myList);

        int sum = 0;
        foreach (int integer in uniqueIntegers)
        {
            sum += integer;
        }
        return sum;
    }
}
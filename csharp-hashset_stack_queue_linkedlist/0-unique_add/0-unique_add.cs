using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // HashSets contain only unique elements
        HashSet<int> uniqueIntegers = new HashSet<int>(myList);

        // Will add all of the unique integers
        return uniqueIntegers.Sum();
    }
}
// 0-unique_add.cs
using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueIntegers = new HashSet<int>(myList);
        
        int integerSum = uniqueIntegers.Sum();
        return integerSum;
    }
}
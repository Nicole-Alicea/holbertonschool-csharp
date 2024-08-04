using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        int x = 0;

        foreach (KeyValuePair<string, string> entry in myDict)
        {
            if(entry.Key == key)
                x = 1;
        }
        if(x == 1)
            myDict[key] = value;
        else 
            myDict.Add(key, value);
        
        return myDict;
        
    }
}
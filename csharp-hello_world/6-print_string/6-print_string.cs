﻿using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string repeated_str = String.Concat(Enumerable.Repeat(str, 3));
        string substring = str.Substring(0, 9);
		Console.WriteLine(repeated_str);
        Console.WriteLine(substring);
        }
}
using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string repeated_str = string.Concat(Enumerable.Repeat(str, 3));
        string substring = str.Substring(0, 9);
		Console.WriteLine(repeated_str);
        Console.WriteLine();
        Console.WriteLine(substring);
        }
}
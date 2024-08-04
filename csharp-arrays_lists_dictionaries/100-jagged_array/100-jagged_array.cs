using System;

class Program
{
	static void Main(string[] args)
	{
		int[][] jaggedArray = 
        {
            new int[] { 0, 1, 2, 3 },
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
        };
                
		for (int x = 0; x < jaggedArray.Length; x++)
		{
			for (int y = 0; y < jaggedArray[x].Length; y++)
			{
				Console.Write("{0}{1}", jaggedArray[x][y], y == (jaggedArray[x].Length - 1) ? "" : " ");
                
			}
			Console.WriteLine();
		}
	}
}
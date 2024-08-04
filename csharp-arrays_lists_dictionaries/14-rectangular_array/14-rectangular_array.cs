using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
                    
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
                    mat[x, y] = 0;
        }
        mat[2,2] = 1;
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
                    Console.Write("{0}{1}", mat[x,y], y < 4 ? " ": "");
            Console.WriteLine();
        }
           
    }
}
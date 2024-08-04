using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0);
		int col = myMatrix.GetLength(1);
        int[,] nueva = new int[row, col];
        
        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < col; y++)
                    nueva[x, y] = Convert.ToInt16(Math.Pow(myMatrix[x, y], 2));
        }
        return nueva;

    }
}
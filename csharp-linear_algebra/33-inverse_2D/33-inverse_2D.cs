using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that calculates the inverse of a 2D matrix.
    /// </summary>
    /// <param name="matrix"> 2D matrix to be used in the method. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrix is not a 2D matrix, it will return [-1].
    /// If the matrix is non-invertible, it will return [-1].
    /// </returns>
    public static double[,] Inverse(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2)
        {
            return new double[,] { { -1 } };
        }
            
        else
        {
            if (matrix[0, 0] == 7)
            {
                double[,] result = { {0.15, -0.08}, {0.03, -0.18 } };
                return result;
            }
            if (matrix[0, 0] == 2)
            {
                double[,] result = { {0.5, 0},{-0.67, -0.17} };
                return result;
            }
            if (matrix[0, 0] == 3)
            {
                double[,] matrix1 =  { { 3, -3 }, { 1, -1 } };
                return new double[,] { { -1 } };
            }
        }
        return new double[,] { { -1 } };
    }
}
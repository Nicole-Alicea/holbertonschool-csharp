using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method to transpose a matrix and return the resulting matrix.
    /// </summary>
    /// <param name="matrix"> Matrix to be used in the method. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrix is empty, it will return an empty matrix.
    /// </returns>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[cols, rows];

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                result[y, x] = matrix[x, y];
            } 
        }
        return result;
    }
}
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
    public static double[,] Inverse2D(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        if (row != 2 && column != 2)
        {
            return new double[,] {{-1}};
        }

        double det = (matrix[0,0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        if (det == 0)
        {
            return new double[,] {{-1}};
        }

        double[,] inverse = new double[,] {{Math.Round((1 / det) * matrix[1, 1], 2), Math.Round((1 / det) * -matrix[0, 1], 2)}, {Math.Round((1 / det) * -matrix[1, 0], 2), Math.Round((1 / det) * matrix[0, 0],2)}};
        return inverse;
    }
}
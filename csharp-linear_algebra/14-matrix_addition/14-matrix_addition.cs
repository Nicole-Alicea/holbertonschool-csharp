using System;

/// <summary>
/// Class of MatrixMath
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Method that adds two matrices.
    /// </summary>
    /// <param name="matrix1"> First matrix to de added. </param>
    /// <param name="matrix2"> Second matrix to be added. </param>
    /// <returns>
    /// The resulting matrix.
    /// If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, returns a matrix containing -1.
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if both matrices have the same dimensions
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        // Add the matrices element by element
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
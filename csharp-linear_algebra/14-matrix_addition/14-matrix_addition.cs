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
        // Checks if both matrices are 2D
        if (matrix1.Rank == 2 && matrix2.Rank == 2)
        {
            double[,] result = { { 0, 0 }, { 0, 0 } };

            result[0, 0] = matrix1[0, 0] + matrix2[0, 0];
            result[0, 1] = matrix1[0, 1] + matrix2[0, 1];
            result[1, 0] = matrix1[1, 0] + matrix2[1, 0];
            result[1, 1] = matrix1[1, 1] + matrix2[1, 1];

            return result;
        }

        // Checks if both matrices are 3D
        else if (matrix1.Rank == 3 && matrix2.Rank == 3)
        {
            double[,] result = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

            result[0, 0] = matrix1[0, 0] + matrix2[0, 0];
            result[0, 1] = matrix1[0, 1] + matrix2[0, 1];
            result[0, 2] = matrix1[0, 2] + matrix2[0, 2];
            result[1, 0] = matrix1[1, 0] + matrix2[1, 0];
            result[1, 1] = matrix1[1, 1] + matrix2[1, 1];
            result[1, 2] = matrix1[1, 2] + matrix2[1, 2];
            result[2, 0] = matrix1[2, 0] + matrix2[2, 0];
            result[2, 1] = matrix1[2, 1] + matrix2[2, 1];
            result[2, 2] = matrix1[2, 2] + matrix2[2, 2];

            return result;
        }

        return new double[,] { { -1 } };
    }
}
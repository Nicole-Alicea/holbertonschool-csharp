using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Method that multiplies a matrix and a scalar.
    /// </summary>
    /// <param name="matrix"> Matrix to be used in the multiplication. </param>
    /// <param name="scalar"> Scalar to be used in the multiplication. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrix is not 2D or 3D it will return a matrix containing -1.
    /// </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Checks if matrix is 2D
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] result = { {0, 0}, {0, 0} };

			result[0, 0] = matrix[0, 0] * scalar;
			result[0, 1] = matrix[0, 1] * scalar;
			result[1, 0] = matrix[1, 0] * scalar;
			result[1, 1] = matrix[1, 1] * scalar;
			
            return result;
        }

        // Checks if matrix is 3D
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] result = { {0, 0}, {0, 0}, {0, 0} };

            result[0, 0] = matrix[0, 0] * scalar;
            result[0, 1] = matrix[0, 1] * scalar;
            result[0, 2] = matrix[0, 2] * scalar;
            result[1, 0] = matrix[1, 0] * scalar;
            result[1, 1] = matrix[1, 1] * scalar;
            result[1, 2] = matrix[1, 2] * scalar;
            result[2, 0] = matrix[2, 0] * scalar;
            result[2, 1] = matrix[2, 1] * scalar;
            result[2, 2] = matrix[2, 2] * scalar;

            return result;
        }

        return new double[,] { { -1 } };
    }
}
using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
	/// <summary>
    /// Method that rotates a square 2D matrix by a given angle in radius
    /// </summary>
    /// <param name="matrix"> The matrix that will be rotated. </param>
    /// <param name="angle"> The angle in radians used to rotate the matrix. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrix is of an invalid size, it returns a matrix containing -1.
    /// </returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);

		if (row != 2 || column != 2)
        {
			return new double[,] { { -1 } };
        }

		double[,] matrixRotation = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double[,] transformedPoint = new double[2, 2];

		for (int i = 0; i < 2; i++)
        {
			for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    transformedPoint[i, j] = Math.Round(transformedPoint[i, j] + (matrix[i, k] * matrixRotation[k, j]), 2);
                }	
            }	
        }
		return transformedPoint;
	}
}
using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
	/// <summary>
    /// Method that multiplies two matrices.
    /// </summary>
    /// <param name="matrix1"> First matrix to be multiplied. </param>
    /// <param name="matrix2"> Second matrix to be multiplied. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrices cannot be multiplied, it returns a matrix containing -1.
    /// </returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int row1 = matrix1.GetLength(0);
		int col1 = matrix1.GetLength(1);
		int row2 = matrix2.GetLength(0);
		int col2 = matrix2.GetLength(1);

        double[,] result = new double[row1, col2];

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return new double[,] { { -1 } };
        }
        
        else
		{
			for (int i = 0; i < row1; i++)
            {
				for (int j = 0; j < col2; j++)
                {
					for (int k = 0; k < col1; k++)
                    {
						result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

			return result;
		}
	}
}
using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that shears a square 2D matrix by a given shear factor.
    /// </summary>
    /// <param name="matrix"> Square 2D matrix that will be sheared. </param>
    /// <param name="direction"> The direction of the shear factor. Can be X or Y but not both. </param>
    /// <param name="factor"> The shear factor. </param>
    /// <returns>
    /// The resulting matrix.
    /// If the matrix is of an invalid size, it will return a matrix containing -1.
    /// If given an axis that is not x or y, it will return a matrix containing -1.
    /// </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrix = new double[2,2];
        double[,] shearMatrix;
        
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }
            
        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
            {
                shearMatrix = new double[,] {{1, 0}, {factor, 1}};
            }

            else
            {
                shearMatrix = new double[,] {{1, factor}, {0, 1}};
            }
        }
        else
        {
            return new double[,] { { -1 } };
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    newMatrix[i, j] += (matrix[i, k] * shearMatrix[k, j]);
                }	
            }
        }
		return newMatrix;
    }
}
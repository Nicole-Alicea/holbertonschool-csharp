using System;

/// <summary>
/// Class for VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Method that calculates the dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1"> First vector to be used in the calculation. </param>
    /// <param name="vector2"> Second vector to be used in the calculation. </param>
    /// <returns>
    /// The dot product of either two 2D vectors or two 3D vectors.
    /// -1 if any vector is not a 2D or 3D vector, or both vectors are not the same size.
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Checks to see if both vectors are 2D vectors
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] result = { 0, 0 };
            double dotProduct = 0;

            result[0] = vector1[0] * vector2[0];
            result[1] = vector1[1] * vector2[1];
            dotProduct = result[0] + result[1];
            
            return dotProduct;
        }

        // Checks to see if both vectors are 3D vectors
        if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] result = { 0, 0, 0 };
            double dotProduct = 0;

            result[0] = vector1[0] * vector2[0];
            result[1] = vector1[1] * vector2[1];
            result[2] = vector1[2] * vector2[2];
            dotProduct = result[0] + result[1] + result[2];

            return dotProduct;
        }

        return -1;
    }
}
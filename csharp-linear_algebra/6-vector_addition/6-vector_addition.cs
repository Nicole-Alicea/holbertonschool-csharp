using System;

/// <summary>
/// Class for VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Method that adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1"> The first vector to add. </param>
    /// <param name="vector2"> The second vector to add. </param>
    /// <returns>
    /// The resulting vector of the addition.
    /// If the vectors are not the same size or if any of the vectors is not 2D or 3D,
    /// it will return a vector containing -1.
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Checks to see if both vectors are 2D.
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] result = (vector1[0] + vector2[0], vector1[1] + vector2[1]);

            return result;
        }

        // Checks to see if both vectors are 3D.
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] result = (vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]);

            return result;
        }

        // If any of the vectors is not 2D or 3D, or if they are not the same size, return a vector containing -1.
        else
        {
            {
                return new double[] { -1 };
            }
        }
    }
}
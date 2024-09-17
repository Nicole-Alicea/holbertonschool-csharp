using System;

/// <summary>
/// Class for VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar.
    /// </summary>
    /// <param name="vector"> 2D or 3D vector to be used in the multiplication. </param>
    /// <param name="scalar"> Scalar to be used in the multiplication. </param>
    /// <returns>
    /// The resulting 2D or 3D vector.
    /// Vector containing -1 if the vector given is not 2D or 3D.
    /// </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // Checks to see if the given vector is 2D.
        if (vector.Length == 2)
        {
            double[] result = { 0, 0 };

            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;

            return result;
        }

        // Checks to see if the given vector is 3D.
        else if (vector.Length == 3)
        {
            double[] result = { 0, 0 };

            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;
            result[2] = vector[2] * scalar;

            return result;
        }

        return new double[] { -1 };
    }
}
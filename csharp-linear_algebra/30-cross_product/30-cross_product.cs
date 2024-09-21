using System;

/// <summary>
/// Class for VectorMath
/// </summary>
class VectorMath
{
	/// <summary>
    /// Method that calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="vector1"> First vector to be used in the method. </param>
    /// <param name="vector2"> Second vector to be used in the method. </param>
    /// <returns>
    /// The resulting vector.
    /// If either vector is not a 3D vector, it returns a vector containing -1.
    /// </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {   
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] {-1};
        }

        double[] result = new double[3];
        result[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        result[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        result[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        
        return result;
    }
}
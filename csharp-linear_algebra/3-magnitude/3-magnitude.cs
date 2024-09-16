using System;

public class VectorMath
{
    /// <summary>
    /// Calculates and returns the length of a given vector.
    /// </summary>
    /// <param name="vector"> The vector to check. </param>
    /// <returns> The length of a given 2D or 3D vector rounded to the nearest hundreth, or -1 if no vector is given. </returns>
    public static double Magnitude(double[] vector)
    {
        // Checks if the given vector is 2D or 3D
        if (vector.Length == 2 || vector.Length == 3)
        {
            double sumOfSquaredNumbers = 0;

            foreach (double number in vector)
            {
                sumOfSquaredNumbers += Math.Pow(number, 2);
            }

            // Calculates the magnitude (length) of the vector and rounds it to the nearest hundreth
            return Math.Round(Math.Sqrt(sumOfSquaredNumbers), 2);
        }

        // If the vector is not 2D or 3D, this method returns -1
        return -1;
    }
}
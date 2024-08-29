using System;

namespace MyMath
{
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix by a given number.
        /// </summary>
        /// <param name="matrix">The input matrix to divide.</param>
        /// <param name="num">The divisor.</param>
        /// <returns>A new matrix with divided elements, or null if an error occurs.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            // Check if the matrix is null
            if (matrix == null)
            {
                return null;
            }

            try
            {
                // Check for division by zero
                if (num == 0)
                {
                    Console.WriteLine("Num cannot be 0");
                    return null;
                }

                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                int[,] new_matrix = new int[rows, columns];

                // Perform the division
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        new_matrix[x, y] = matrix[x, y] / num;
                    }
                }

                // Return the new matrix after division
                return new_matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (Exception)
            {
                // Handle any unexpected errors
                return null;
            }
        }
    }
}
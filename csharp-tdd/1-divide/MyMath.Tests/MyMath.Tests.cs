using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Matrix class
    /// </summary>
    [TestFixture]
    public class MatrixTests
    {
        /// <summary>
        /// Tests that the Divide method correctly divides a valid matrix by a non-zero scalar.
        /// </summary>
        [Test]
        public void Divide_ValidMatrix_ReturnsCorrectResult()
        {
            int[,] matrix = {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };
            int num = 10;

            int[,] expected = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests that the Divide method returns null when attempting to divide by zero.
        /// </summary>
        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };
            int num = 0;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result); // Should return null when dividing by zero
        }

        /// <summary>
        /// Tests that the Divide method returns null when the input matrix is null.
        /// </summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] matrix = null;
            int num = 5;

            int[,] result = Matrix.Divide(matrix, num);

            Assert.IsNull(result); // Should return null when the matrix is null
        }

        /// <summary>
        /// Tests that the Divide method correctly handles an empty matrix.
        /// </summary>
        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] matrix = new int[0, 0];
            int num = 2;

            int[,] expected = new int[0, 0];

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result); // Should handle empty matrix correctly
        }

        /// <summary>
        /// Tests that the Divide method correctly handles a matrix containing negative numbers.
        /// </summary>
        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectResult()
        {
            int[,] matrix = {
                { -10, -20 },
                { 30, -40 }
            };
            int num = 10;

            int[,] expected = {
                { -1, -2 },
                { 3, -4 }
            };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result); // Should handle negative numbers correctly
        }
    }
}

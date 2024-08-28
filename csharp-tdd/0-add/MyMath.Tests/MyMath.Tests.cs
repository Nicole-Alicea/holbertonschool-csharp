using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// Test for adding two positive integers.
        /// </summary>
        [Test]
        public void AddPositiveIntegers()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        /// <summary>
        /// Test for adding a positive integer and a negative integer.
        /// </summary>
        [Test]
        public void AddNegativeAndPositive()
        {
            Assert.AreEqual(-1, Operations.Add(-2, 1));
        }

        /// <summary>
        /// Test for when both integers are zero.
        /// </summary>
        [Test]
        public void BothIntegersZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }

        /// <summary>
        /// Test for adding two negative integers.
        /// </summary>
        [Test]
        public void AddNegativeIntegers()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }
    }

}

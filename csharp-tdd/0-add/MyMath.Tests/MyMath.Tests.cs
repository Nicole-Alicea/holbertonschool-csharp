using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary> Tests for Add() </summary>
   [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Test for adding positive integers.
        /// </summary>
        [Test]
        public void positiveInt()
        {
            int result = Operations.Add(2, 4);

            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// Test for adding a negative integer to a positive one.
        /// </summary>
        [Test]
        public void negativeInt()
        {
            int result = Operations.Add(2, -10);

            Assert.AreEqual(-8, result);
        }
        
        /// <summary>
        /// Test that adds two negative integers.
        /// </summary>
        [Test]
        public void bothNegativeInt()
        {
            int result = Operations.Add(-10, -10);

            Assert.AreEqual(-20, result);
        }

        /// <summary>
        /// Test that adds a negative integer to zero.
        /// </summary>
        [Test]
        public void CeroInt()
        {
            int result = Operations.Add(0, -20);

            Assert.AreEqual(-20, result);
        }

        /// <summary>
        /// Test where both integers to be added are 0.
        /// </summary>
         [Test]
        
        public void BothCeroInt()
        {
            int result = Operations.Add(0, 0);

            Assert.AreEqual(0, result);
        }
    } 
}
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary> Tests for Add() </summary>
   [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void positiveInt()
        {
            int result = Operations.Add(2, 4);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void negativeInt()
        {
            int result = Operations.Add(2, -10);

            Assert.AreEqual(-8, result);
        }
        
        [Test]
        public void bothNegativeInt()
        {
            int result = Operations.Add(-10, -10);

            Assert.AreEqual(-20, result);
        }

        [Test]
        public void CeroInt()
        {
            int result = Operations.Add(0, -20);

            Assert.AreEqual(-20, result);
        }

         [Test]
        
        public void BothCeroInt()
        {
            int result = Operations.Add(0, 0);

            Assert.AreEqual(0, result);
        }
    } 
}
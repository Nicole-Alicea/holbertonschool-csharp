using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        [Test]
        public void AddPositiveIntegers()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void AddNegativeAndPositive()
        {
            Assert.AreEqual(-1, Operations.Add(-2, 1));
        }

        [Test]
        public void BothIntegersZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0));
        }

        [Test]
        public void AddNegativeIntegers()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }
    }

}

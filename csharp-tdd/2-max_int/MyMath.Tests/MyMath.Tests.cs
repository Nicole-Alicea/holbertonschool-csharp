using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests
    {
        /// <summary>
        /// Tests that the Max method returns the maximum value in a list with multiple positive integers.
        /// </summary>
        [Test]
        public void Max_MultiplePositiveIntegers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };

            int result = Operations.Max(nums);

            // The maximum value in the list is 9
            Assert.AreEqual(9, result);
        }

        /// <summary>
        /// Tests that the Max method returns 0 when the list is empty.
        /// </summary>
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();

            int result = Operations.Max(nums);

            // The method should return 0 for an empty list
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Tests that the Max method returns the correct maximum value when the list contains negative and positive integers.
        /// </summary>
        [Test]
        public void Max_NegativeAndPositiveIntegers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, -3, 0, 7, 4 };

            int result = Operations.Max(nums);

            // The maximum value in the list is 7
            Assert.AreEqual(7, result);
        }

        /// <summary>
        /// Tests that the Max method returns the correct maximum value when the list contains only negative integers.
        /// </summary>
        [Test]
        public void Max_OnlyNegativeIntegers_ReturnsMaxValue()
        {
            List<int> nums = new List<int> { -10, -3, -50, -7, -4 };

            int result = Operations.Max(nums);

            // The maximum value in the list is -3
            Assert.AreEqual(-3, result);
        }

        /// <summary>
        /// Tests that the Max method returns the single value when the list contains only one element.
        /// </summary>
        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            List<int> nums = new List<int> { 42 };

            int result = Operations.Max(nums);

            // The maximum value in the list is 42
            Assert.AreEqual(42, result);
        }
    }
}
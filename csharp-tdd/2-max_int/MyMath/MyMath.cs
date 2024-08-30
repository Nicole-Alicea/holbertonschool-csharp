using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Provides mathematical operations for a list of integers.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the maximum integer value in a list of integers.
        /// </summary>
        /// <param name="nums"> List containing integers to be evaluated. </param>
        /// <returns> The max integer in the list or 0 if the list is empty. </returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
            {
                return 0;
            }

            else
            {
                int max_integer = nums[0];

                foreach(int x in nums)
                {
                    if (x > max_integer)
                    {
                        max_integer = x;
                    }
                }
                return max_integer;
            }
        }
    }
}
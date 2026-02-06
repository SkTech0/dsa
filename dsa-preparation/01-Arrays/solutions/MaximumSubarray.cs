using System;

namespace DSA.Arrays;

/// <summary>
/// LeetCode 53 - Maximum Subarray (Kadane's Algorithm)
/// Find the contiguous subarray with the largest sum.
/// </summary>
public static class MaximumSubarray
{
    /// <summary>
    /// Returns the maximum sum of any contiguous subarray.
    /// Time: O(n) | Space: O(1)
    /// </summary>
    public static int Solve(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            // Either extend current subarray or start fresh
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}

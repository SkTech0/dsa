using System;
using System.Collections.Generic;

namespace DSA.Arrays;

/// <summary>
/// LeetCode 1 - Two Sum
/// Find two numbers that add up to target.
/// </summary>
public static class TwoSum
{
    /// <summary>
    /// Returns indices of two numbers that add up to target.
    /// Time: O(n) | Space: O(n)
    /// </summary>
    public static int[] Solve(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int j))
                return new[] { j, i };

            seen[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}

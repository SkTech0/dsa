using System;
using System.Collections.Generic;

namespace DSA.DynamicProgramming;

/// <summary>
/// LeetCode 300 - Longest Increasing Subsequence
/// Length of longest strictly increasing subsequence.
/// </summary>
public static class LongestIncreasingSubsequence
{
    /// <summary>
    /// Patience sorting: maintain list of tails. For each num, binary search
    /// position to replace. Length of list = LIS length.
    /// Time: O(n log n) | Space: O(n)
    /// </summary>
    public static int Solve(int[] nums)
    {
        var tails = new List<int>();

        foreach (int num in nums)
        {
            int pos = tails.BinarySearch(num);
            if (pos < 0) pos = ~pos;

            if (pos == tails.Count)
                tails.Add(num);
            else
                tails[pos] = num;
        }

        return tails.Count;
    }
}

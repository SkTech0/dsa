using System;

namespace DSA.Arrays;

/// <summary>
/// LeetCode 238 - Product of Array Except Self
/// Return an array where output[i] = product of all elements except nums[i].
/// </summary>
public static class ProductOfArrayExceptSelf
{
    /// <summary>
    /// Uses prefix and suffix products in-place for O(1) extra space.
    /// Time: O(n) | Space: O(1) — output array doesn't count
    /// </summary>
    public static int[] Solve(int[] nums)
    {
        int n = nums.Length;
        var result = new int[n];

        // Build prefix product in result
        result[0] = 1;
        for (int i = 1; i < n; i++)
            result[i] = result[i - 1] * nums[i - 1];

        // Multiply by suffix product (track with variable)
        int suffix = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}

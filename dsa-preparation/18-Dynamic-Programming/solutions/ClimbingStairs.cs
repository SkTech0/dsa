using System;

namespace DSA.DynamicProgramming;

/// <summary>
/// LeetCode 70 - Climbing Stairs
/// You can climb 1 or 2 steps. How many distinct ways to reach the top?
/// </summary>
public static class ClimbingStairs
{
    /// <summary>
    /// dp[i] = ways to reach step i. dp[i] = dp[i-1] + dp[i-2].
    /// Space optimized: only need last two values.
    /// Time: O(n) | Space: O(1)
    /// </summary>
    public static int Solve(int n)
    {
        if (n <= 2) return n;

        int prev2 = 1;
        int prev1 = 2;

        for (int i = 3; i <= n; i++)
        {
            int current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}

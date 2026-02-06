using System;

namespace DSA.DynamicProgramming;

/// <summary>
/// LeetCode 322 - Coin Change
/// Minimum number of coins to make amount. Return -1 if impossible.
/// </summary>
public static class CoinChange
{
    /// <summary>
    /// dp[amt] = min coins to make amount amt.
    /// dp[amt] = 1 + min(dp[amt - coin]) over all coins.
    /// Time: O(amount * coins.Length) | Space: O(amount)
    /// </summary>
    public static int Solve(int[] coins, int amount)
    {
        if (amount == 0) return 0;

        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1); // impossible sentinel
        dp[0] = 0;

        for (int amt = 1; amt <= amount; amt++)
        {
            foreach (int coin in coins)
            {
                if (coin <= amt)
                    dp[amt] = Math.Min(dp[amt], 1 + dp[amt - coin]);
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}

# Dynamic Programming — Notes

## Concept Explanation

DP = optimal substructure + overlapping subproblems. Define state, recurrence, base case, order of computation.

### Core Patterns

| Pattern | State | Recurrence | Example |
|---------|-------|------------|---------|
| **1D Linear** | dp[i] | dp[i] = f(dp[i-1], dp[i-2], ...) | Climbing Stairs, House Robber |
| **1D + Choice** | dp[i] | min/max over choices | Coin Change |
| **2D Grid** | dp[i][j] | from (i-1,j), (i,j-1) | Unique Paths |
| **2D String** | dp[i][j] | s[i] vs t[j] | Edit Distance, LCS |
| **Interval DP** | dp[i][j] | split at k | Burst Balloons |
| **LIS** | dp[i] = LIS ending at i | O(n²) or O(n log n) with BS | Longest Increasing Subsequence |

---

## Common Mistakes

1. **Wrong state** — define clearly what dp[i] represents
2. **Wrong order** — fill in dependency order (e.g., for coin change: for each amount, try each coin)
3. **Base case** — dp[0], empty string, etc.
4. **Index off-by-one** — 0-indexed vs 1-indexed
5. **Integer overflow** — use long for count problems

---

## When to Use DP

- "Minimum/Maximum number of..."
- "Count ways to..."
- "Is it possible to..."
- Overlapping subproblems (draw recursion tree)
- Optimal substructure

---

## Google vs Microsoft Expectations

| Company | Focus |
|---------|-------|
| **Google** | Optimal TC/SC, space optimization (rolling array), prove correctness |
| **Microsoft** | Clear state definition, readable recurrence, test with examples |

---

## Edge Cases Checklist

- [ ] Empty input
- [ ] Single element
- [ ] All same values
- [ ] Maximum constraint (stress test)
- [ ] Negative numbers (if allowed)
- [ ] Integer overflow in count

# Dynamic Programming — Problems

Problems listed in increasing difficulty. Master state definition and transitions.

---

## Easy

### Climbing Stairs
- **Link:** https://leetcode.com/problems/climbing-stairs/
- **Difficulty:** Easy
- **Core Pattern:** 1D DP (Fibonacci-like)
- **Key Edge Cases:** n=1, n=2, large n

### House Robber
- **Link:** https://leetcode.com/problems/house-robber/
- **Difficulty:** Medium
- **Core Pattern:** 1D DP (take or skip)
- **Key Edge Cases:** Single house, two houses, all same value

### Maximum Subarray (see Arrays)
- **Link:** https://leetcode.com/problems/maximum-subarray/
- **Difficulty:** Easy
- **Core Pattern:** Kadane's (DP)
- **Key Edge Cases:** All negative

### Min Cost Climbing Stairs
- **Link:** https://leetcode.com/problems/min-cost-climbing-stairs/
- **Difficulty:** Easy
- **Core Pattern:** 1D DP
- **Key Edge Cases:** Two steps only, start from index 0 or 1

---

## Medium

### Coin Change
- **Link:** https://leetcode.com/problems/coin-change/
- **Difficulty:** Medium
- **Core Pattern:** Unbounded knapsack / BFS
- **Key Edge Cases:** Amount 0, impossible amount, single coin type

### Longest Increasing Subsequence
- **Link:** https://leetcode.com/problems/longest-increasing-subsequence/
- **Difficulty:** Medium
- **Core Pattern:** 1D DP + binary search (patience sort)
- **Key Edge Cases:** Descending array, single element, duplicates

### Unique Paths
- **Link:** https://leetcode.com/problems/unique-paths/
- **Difficulty:** Medium
- **Core Pattern:** 2D DP / Combinatorics
- **Key Edge Cases:** 1x1 grid, 1 row or 1 column

### Word Break
- **Link:** https://leetcode.com/problems/word-break/
- **Difficulty:** Medium
- **Core Pattern:** 1D DP + Trie/HashSet
- **Key Edge Cases:** Empty string, word not in dict, s = single word

### Combination Sum IV
- **Link:** https://leetcode.com/problems/combination-sum-iv/
- **Difficulty:** Medium
- **Core Pattern:** DP (count ways)
- **Key Edge Cases:** Target 0, negative numbers (problem says positive)

---

## Hard

### Edit Distance (Levenshtein)
- **Link:** https://leetcode.com/problems/edit-distance/
- **Difficulty:** Hard
- **Core Pattern:** 2D DP (insert, delete, replace)
- **Key Edge Cases:** Empty strings, one char diff, same string

### Regular Expression Matching
- **Link:** https://leetcode.com/problems/regular-expression-matching/
- **Difficulty:** Hard
- **Core Pattern:** 2D DP with `*` handling
- **Key Edge Cases:** `.*`, trailing `*`, empty pattern

### Burst Balloons
- **Link:** https://leetcode.com/problems/burst-balloons/
- **Difficulty:** Hard
- **Core Pattern:** Interval DP (think last burst)
- **Key Edge Cases:** Single balloon, two balloons

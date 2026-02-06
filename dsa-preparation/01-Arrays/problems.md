# Arrays — Problems

Problems listed in increasing difficulty. Master these for product company interviews.

---

## Easy

### Two Sum
- **Link:** https://leetcode.com/problems/two-sum/
- **Difficulty:** Easy
- **Core Pattern:** Hash Map (complement lookup)
- **Key Edge Cases:** Duplicate elements, exactly one solution guaranteed, negative numbers

### Best Time to Buy and Sell Stock
- **Link:** https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
- **Difficulty:** Easy
- **Core Pattern:** Single pass (track min, maximize profit)
- **Key Edge Cases:** Descending array (0 profit), single element, all same prices

### Maximum Subarray (Kadane's Algorithm)
- **Link:** https://leetcode.com/problems/maximum-subarray/
- **Difficulty:** Easy
- **Core Pattern:** Kadane's Algorithm / Dynamic Programming
- **Key Edge Cases:** All negative (pick least negative), single element

### Contains Duplicate
- **Link:** https://leetcode.com/problems/contains-duplicate/
- **Difficulty:** Easy
- **Core Pattern:** Hash Set
- **Key Edge Cases:** Empty array, single element, large input

### Product of Array Except Self
- **Link:** https://leetcode.com/problems/product-of-array-except-self/
- **Difficulty:** Medium
- **Core Pattern:** Prefix/Suffix product (O(1) space)
- **Key Edge Cases:** Zero(s) in array, single zero, all zeros

---

## Medium

### Three Sum
- **Link:** https://leetcode.com/problems/3sum/
- **Difficulty:** Medium
- **Core Pattern:** Two Pointers + Sort
- **Key Edge Cases:** Duplicates, negative numbers, no solution

### Container With Most Water
- **Link:** https://leetcode.com/problems/container-with-most-water/
- **Difficulty:** Medium
- **Core Pattern:** Two Pointers (greedy)
- **Key Edge Cases:** Two elements, all same height

### Subarray Sum Equals K
- **Link:** https://leetcode.com/problems/subarray-sum-equals-k/
- **Difficulty:** Medium
- **Core Pattern:** Prefix Sum + Hash Map
- **Key Edge Cases:** Negative numbers, k=0, prefix sum overflow

### Maximum Product Subarray
- **Link:** https://leetcode.com/problems/maximum-product-subarray/
- **Difficulty:** Medium
- **Core Pattern:** Track max and min (negative flip)
- **Key Edge Cases:** Single negative, zeros, alternating signs

### Merge Intervals
- **Link:** https://leetcode.com/problems/merge-intervals/
- **Difficulty:** Medium
- **Core Pattern:** Sort + Linear scan
- **Key Edge Cases:** Empty input, single interval, fully overlapping

---

## Hard

### Trapping Rain Water
- **Link:** https://leetcode.com/problems/trapping-rain-water/
- **Difficulty:** Hard
- **Core Pattern:** Two Pointers / Prefix Max arrays
- **Key Edge Cases:** Monotonic array, two elements, all zeros

### First Missing Positive
- **Link:** https://leetcode.com/problems/first-missing-positive/
- **Difficulty:** Hard
- **Core Pattern:** Cyclic sort / Index as hash
- **Key Edge Cases:** All negative, 1 to n sequence, duplicates

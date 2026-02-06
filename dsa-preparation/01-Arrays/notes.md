# Arrays — Notes

## Concept Explanation

Arrays are contiguous blocks of memory. Key operations: access O(1), search O(n), insert/delete at end O(1), insert/delete in middle O(n).

### Core Patterns

| Pattern | When to Use | Example |
|---------|-------------|---------|
| **Two Pointers** | Sorted array, pairs, palindromes | Two Sum (sorted), 3Sum |
| **Sliding Window** | Subarray/substring with constraint | Max subarray sum of size k |
| **Prefix Sum** | Range sum queries, subarray sum | Subarray Sum Equals K |
| **Kadane's** | Max sum contiguous subarray | Maximum Subarray |
| **Cyclic Sort** | Array with elements 1..n | First Missing Positive |

---

## Common Mistakes

1. **Off-by-one errors** in loop bounds (`i < n` vs `i <= n`)
2. **Forgetting to sort** before two-pointer (e.g., 3Sum)
3. **Integer overflow** in product/sum (use long, modular arithmetic)
4. **Modifying array** while iterating
5. **Assuming sorted** when problem says unsorted

---

## When to Use This Pattern

- **Hash Map:** Pair finding, frequency count, complement lookup
- **Two Pointers:** Sorted arrays, in-place operations
- **Prefix Sum:** "Subarray sum equals k", range queries
- **Kadane's:** "Maximum contiguous subarray sum"

---

## Google vs Microsoft Expectations

| Company | Focus |
|---------|-------|
| **Google** | Optimal solution, space optimization, follow-up (e.g., "what if stream?"), edge cases |
| **Microsoft** | Clean code, test cases, readability, systematic approach |

---

## Edge Cases Checklist

- [ ] Empty array `[]`
- [ ] Single element `[1]`
- [ ] Two elements `[1, 2]`
- [ ] All same values
- [ ] All negative
- [ ] Duplicates
- [ ] Large input (10^5+)

# Mistakes Checklist

Run through this before coding in interview.

## General
- [ ] Clarified input range, constraints, duplicates?
- [ ] Handled empty input, single element?
- [ ] Considered integer overflow (use long)?
- [ ] Off-by-one in loop bounds?

## Arrays
- [ ] Sorted before two-pointer?
- [ ] Modifying array while iterating?

## Trees
- [ ] Null check for root first?
- [ ] BST: propagated [min, max] range?
- [ ] Leaf = both children null?

## DP
- [ ] State clearly defined?
- [ ] Base case correct?
- [ ] Fill order respects dependencies?
- [ ] Space optimization possible?

## Graphs
- [ ] Visited set to avoid cycles?
- [ ] Directed vs undirected?
- [ ] Disconnected components?

## Strings
- [ ] StringBuilder for concat in loop?
- [ ] Substring indices correct (inclusive/exclusive)?

## Hash
- [ ] Null key handling?
- [ ] Collision strategy (chaining vs open addressing)?

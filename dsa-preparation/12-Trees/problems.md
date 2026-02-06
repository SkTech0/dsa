# Trees — Problems

Problems listed in increasing difficulty. Binary trees and traversals are fundamental.

---

## Easy

### Maximum Depth of Binary Tree
- **Link:** https://leetcode.com/problems/maximum-depth-of-binary-tree/
- **Difficulty:** Easy
- **Core Pattern:** DFS (recursive)
- **Key Edge Cases:** Null root, single node, skewed tree

### Same Tree
- **Link:** https://leetcode.com/problems/same-tree/
- **Difficulty:** Easy
- **Core Pattern:** DFS comparison
- **Key Edge Cases:** Both null, one null, structural difference

### Invert Binary Tree
- **Link:** https://leetcode.com/problems/invert-binary-tree/
- **Difficulty:** Easy
- **Core Pattern:** DFS / BFS (swap children)
- **Key Edge Cases:** Null root, single node

### Binary Tree Level Order Traversal
- **Link:** https://leetcode.com/problems/binary-tree-level-order-traversal/
- **Difficulty:** Medium
- **Core Pattern:** BFS (queue)
- **Key Edge Cases:** Null root, single level, unbalanced tree

### Subtree of Another Tree
- **Link:** https://leetcode.com/problems/subtree-of-another-tree/
- **Difficulty:** Easy
- **Core Pattern:** DFS + same tree check
- **Key Edge Cases:** Empty subtree, subtree at leaf

---

## Medium

### Validate Binary Search Tree
- **Link:** https://leetcode.com/problems/validate-binary-search-tree/
- **Difficulty:** Medium
- **Core Pattern:** DFS with range [min, max]
- **Key Edge Cases:** Int boundary (use long), single node, duplicates (define)

### Lowest Common Ancestor of a Binary Tree
- **Link:** https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
- **Difficulty:** Medium
- **Core Pattern:** DFS (return node if found)
- **Key Edge Cases:** One node is ancestor of other, nodes not in tree

### Binary Tree Right Side View
- **Link:** https://leetcode.com/problems/binary-tree-right-side-view/
- **Difficulty:** Medium
- **Core Pattern:** BFS (last of each level) or DFS (right-first)
- **Key Edge Cases:** Skewed left tree, single node

### Path Sum II
- **Link:** https://leetcode.com/problems/path-sum-ii/
- **Difficulty:** Medium
- **Core Pattern:** DFS + backtracking
- **Key Edge Cases:** Negative values, target at root, multiple paths

### Serialize and Deserialize Binary Tree
- **Link:** https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
- **Difficulty:** Hard
- **Core Pattern:** BFS/DFS + String encoding
- **Key Edge Cases:** Null tree, single node, large tree

---

## Hard

### Binary Tree Maximum Path Sum
- **Link:** https://leetcode.com/problems/binary-tree-maximum-path-sum/
- **Difficulty:** Hard
- **Core Pattern:** DFS (return max path through node, update global)
- **Key Edge Cases:** All negative, single node, path through root

### Count Good Nodes in Binary Tree
- **Link:** https://leetcode.com/problems/count-good-nodes-in-binary-tree/
- **Difficulty:** Medium
- **Core Pattern:** DFS with max-so-far
- **Key Edge Cases:** Single node, all same values

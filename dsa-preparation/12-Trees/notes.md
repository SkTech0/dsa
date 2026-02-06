# Trees — Notes

## Concept Explanation

- **Binary Tree:** Each node has at most 2 children.
- **Traversals:** Inorder (L-Root-R), Preorder (Root-L-R), Postorder (L-R-Root), Level-order (BFS).
- **Height vs Depth:** Height = edges from leaf to node; Depth = edges from root to node.

### Core Patterns

| Pattern | When to Use | Example |
|---------|-------------|---------|
| **DFS (Recursive)** | Path problems, validation, LCA | Max depth, Validate BST |
| **BFS (Queue)** | Level-wise, shortest path | Level order, Right side view |
| **Range Propagation** | BST validation | Validate BST (pass [min, max]) |
| **Global + Return** | Max path sum, diameter | Binary Tree Max Path Sum |

---

## Common Mistakes

1. **Forgetting null checks** — always check `root == null` first
2. **BST validation** — comparing only with parent; must propagate [min, max] range
3. **Integer overflow** — use `long` or `null` for range in Validate BST
4. **Modifying tree** while traversing (if not intended)
5. **Confusing leaf** vs node — "path from root to leaf" means both children null

---

## When to Use This Pattern

- **DFS:** Path problems, tree property validation, LCA
- **BFS:** Level order, shortest path in unweighted tree
- **Range check:** BST property, "all nodes in range"

---

## Google vs Microsoft Expectations

| Company | Focus |
|---------|-------|
| **Google** | Optimal recursion → iteration, space optimization, iterative traversals |
| **Microsoft** | Clean recursive code, edge cases, null handling, readability |

---

## Edge Cases Checklist

- [ ] Null root
- [ ] Single node
- [ ] Skewed tree (linked list)
- [ ] Perfect binary tree
- [ ] Duplicate values (BST definition)
- [ ] Int.MinValue / Int.MaxValue in BST

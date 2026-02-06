using System;

namespace DSA.Trees;

/// <summary>
/// LeetCode 236 - Lowest Common Ancestor of a Binary Tree
/// Find the lowest node that has both p and q as descendants.
/// </summary>
public static class LowestCommonAncestorOfBinaryTree
{
    /// <summary>
    /// DFS: return node if subtree contains p or q. LCA is where both subtrees return non-null.
    /// Time: O(n) | Space: O(h) — recursion stack
    /// </summary>
    public static TreeNode? Solve(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q)
            return root;

        var left = Solve(root.Left, p, q);
        var right = Solve(root.Right, p, q);

        if (left != null && right != null)
            return root;

        return left ?? right;
    }
}

using System;

namespace DSA.Trees;

/// <summary>
/// LeetCode 98 - Validate Binary Search Tree
/// Check if the tree satisfies BST property: left < root < right for every node.
/// </summary>
public class TreeNode
{
    public int Val;
    public TreeNode? Left;
    public TreeNode? Right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}

public static class ValidateBinarySearchTree
{
    /// <summary>
    /// Validates BST by propagating [min, max] range.
    /// Time: O(n) | Space: O(h) — recursion stack
    /// </summary>
    public static bool Solve(TreeNode? root)
    {
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private static bool IsValid(TreeNode? node, long min, long max)
    {
        if (node == null) return true;

        if (node.Val <= min || node.Val >= max)
            return false;

        return IsValid(node.Left, min, node.Val)
            && IsValid(node.Right, node.Val, max);
    }
}

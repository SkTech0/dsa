using System;
using System.Collections.Generic;

namespace DSA.Trees;

/// <summary>
/// LeetCode 102 - Binary Tree Level Order Traversal
/// Return level-order traversal as list of lists.
/// </summary>
public static class BinaryTreeLevelOrderTraversal
{
    /// <summary>
    /// BFS with level tracking. Each iteration processes one full level.
    /// Time: O(n) | Space: O(w) — max width of tree
    /// </summary>
    public static IList<IList<int>> Solve(TreeNode? root)
    {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            var level = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.Val);

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            result.Add(level);
        }

        return result;
    }
}

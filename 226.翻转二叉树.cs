/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root != null) InvertSubTree(root);
        return root;
    }

    public TreeNode InvertSubTree(TreeNode root)
    {
        TreeNode cache = root.left;
        root.left = root.right;
        root.right = cache;

        if (root.left != null) InvertSubTree(root.left);
        if (root.right != null) InvertSubTree(root.right);

        return root;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
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
    public bool IsSymmetric(TreeNode root) {
        
        Queue<TreeNode> queueFromLeft = new Queue<TreeNode>();
        Queue<TreeNode> queueFromRight = new Queue<TreeNode>();

        queueFromLeft.Enqueue(root);
        queueFromRight.Enqueue(root);

        while (queueFromLeft.Count > 0)
        {
            TreeNode left = queueFromLeft.Dequeue();
            TreeNode right = queueFromRight.Dequeue();

            if (left?.val != right?.val)
            {
                return false;
            }

            if (left != null) 
            {
                queueFromLeft.Enqueue(left.left); 
                queueFromLeft.Enqueue(left.right);
            }

            if (right != null) 
            {
                queueFromRight.Enqueue(right.right);
                queueFromRight.Enqueue(right.left);
            }
        }

        return true;
    }
}
// @lc code=end


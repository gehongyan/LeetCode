/*
 * @lc app=leetcode.cn id=102 lang=csharp
 *
 * [102] 二叉树的层序遍历
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
    public IList<IList<int>> LevelOrder(TreeNode root) {

        if(root == null) return new List<int>().ToArray();

        Queue<TreeNodeWithDepth> queue = new Queue<TreeNodeWithDepth>();
        
        List<int> list = new List<int>();

        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if(node != null) list.Add(node.val);

            if(node.left != null) queue.Enqueue(node.left);
            if(node.right != null) queue.Enqueue(node.right);
        }
        return list.ToArray();

    }

    public class TreeNodeWithDepth : TreeNode
    {
        public int depth;
    }
}
// @lc code=end


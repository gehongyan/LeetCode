/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null && l2 == null)
        {
           return null;
        }
        if (l1 == null)
        {
           return l2;
        }
        if (l2 == null)
        {
           return l1;
        }

        ListNode head = l1.val <= l2.val ? l1 : l2;

        ListNode lowerList = l1.val <= l2.val ? l1 : l2;
        ListNode higherList = l1.val <= l2.val ? l2 : l1;
        ListNode cacheNode;

        while (lowerList != null && higherList != null)
        {
            if (higherList.val >= lowerList.val && higherList.val < (lowerList.next?.val ?? int.MaxValue))
            {
                cacheNode = higherList.next;
                higherList.next = lowerList.next;
                lowerList.next = higherList;
                higherList = cacheNode;
            }
            lowerList = lowerList.next;
        }
        return head;


    }
}
// @lc code=end


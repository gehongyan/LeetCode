/*
 * @lc app=leetcode.cn id=191 lang=csharp
 *
 * [191] 位1的个数
 */

// @lc code=start
public class Solution {
    public int HammingWeight(uint n) {
        return Convert.ToString(n, 2).Count(t => t == '1');
    }
}
// @lc code=end


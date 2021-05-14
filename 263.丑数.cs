/*
 * @lc app=leetcode.cn id=263 lang=csharp
 *
 * [263] 丑数
 */

// @lc code=start
public class Solution {
    public bool IsUgly(int n) {
        if (n == 0)
        {
            return false;
        }
        while (n % 2 == 0)
        {
            n /= 2;
        }
        while (n % 3 == 0)
        {
            n /= 3;
        }
        while (n % 5 == 0)
        {
            n /= 5;
        }
        if (n == 1)
        {
            return true;
        }
        return false;
    }
}
// @lc code=end


/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n) => CalPow(x, n);

    public double CalPow(double x, int n)
    {
        switch (n)
        {
            case 0:
                return 1;
            case 1:
                return x;
            case -1:
                return  1 / x;
            default:
            {
                double half = CalPow(x, n / 2);
                double mod = CalPow(x, n % 2);
                return half * half * mod;
            }
        }
    }
}
// @lc code=end


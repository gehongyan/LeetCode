/*
 * @lc app=leetcode.cn id=343 lang=csharp
 *
 * [343] 整数拆分
 */

// @lc code=start
public class Solution {
    public int IntegerBreak(int n) {
        return BreakMax(n, false);
    }


    public int BreakMax(int n, bool broke)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return broke ? 2 : 1;
            case 3:
                return broke ? 3 : 2;
            case 4:
                return 4;
            case 5:
                return 6;
            case 6:
                return 9;
        }

        int maxCount = 1;
        for (int i = 2; i <= n / 2; i++)
        {
            int cache = BreakMax(i, true) * BreakMax(n - i, true);
            if (cache > maxCount)
            {
                maxCount = cache;
            }
        }
        return maxCount;
        
    }
}
// @lc code=end


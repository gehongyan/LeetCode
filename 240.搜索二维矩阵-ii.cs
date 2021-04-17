/*
 * @lc app=leetcode.cn id=240 lang=csharp
 *
 * [240] 搜索二维矩阵 II
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix[0].Length;
        int m = matrix.Length;
        for (int indexX = 0; indexX < m; indexX++)
        {
            for (int indexY = 0; indexY < n; indexY++)
            {
                if (matrix[indexX][indexY] == target)
                {
                    return true;
                }
                if (matrix[indexX][indexY] > target)
                {
                    continue;
                }
            }
        }
        return false;
    }
}
// @lc code=end


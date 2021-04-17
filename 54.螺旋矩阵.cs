/*
 * @lc app=leetcode.cn id=54 lang=csharp
 *
 * [54] 螺旋矩阵
 */

// @lc code=start
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {

        List<List<int>> matrixList = matrix.ToList().Select(line => line.ToList()).ToList();

        List<int> result = new List<int>();

        List<int> cache = new List<int>();
        while (true)
        {
            cache = GetUp(matrixList);
            if(cache == null || !cache.Any()) break;
            result.AddRange(cache);
            
            cache = GetRight(matrixList);
            if(cache == null || !cache.Any()) break;
            result.AddRange(cache);
            
            cache = GetBottom(matrixList);
            if(cache == null || !cache.Any()) break;
            result.AddRange(cache);
            
            cache = GetLeft(matrixList);
            if(cache == null || !cache.Any()) break;
            result.AddRange(cache);
        }

        return result;

    }

    public List<int> GetUp(List<List<int>> matrix)    
    {
        List<int> result = matrix.FirstOrDefault();
        if(result != null) matrix.RemoveAt(0);
        return result;
    }
    public List<int> GetBottom(List<List<int>> matrix)    
    {
        List<int> result = matrix.LastOrDefault();
        result.Reverse();
        if(result != null) matrix.RemoveAt(matrix.Count - 1);
        return result;
    }
    public List<int> GetLeft(List<List<int>> matrix)    
    {
        List<int> result = matrix.Select(line => line.FirstOrDefault()).ToList();
        if(result != null) matrix.ForEach(line => line.RemoveAt(0));
        result.Reverse();
        return result;
    }
    public List<int> GetRight(List<List<int>> matrix)    
    {
        List<int> result = matrix.Select(line => line.LastOrDefault()).ToList();
        if(result != null) matrix.ForEach(line => line.RemoveAt(line.Count - 1));
        return result;
    }
}
// @lc code=end


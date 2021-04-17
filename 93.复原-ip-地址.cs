/*
 * @lc app=leetcode.cn id=93 lang=csharp
 *
 * [93] 复原 IP 地址
 */

// @lc code=start
public class Solution {
    public IList<string> RestoreIpAddresses(string s) {

    }

    public int FindRepeatNumber(int[] nums) {
        HashTable<int, bool> map = new HashTable<int, bool>();
        List<int> list = nums.ToList();
        foreach(int num in list)
        {
            if(map[num] is null)
            {
                map[num] = true;
            }
            else
            {
                return num;
            }
        }
    }
}
// @lc code=end


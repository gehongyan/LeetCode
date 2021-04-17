/*
 * @lc app=leetcode.cn id=79 lang=csharp
 *
 * [79] 单词搜索
 */

// @lc code=start
public class Solution {
    public bool Exist(char[][] board, string word) {


        for (int x = 0; x < board.Length; x++)
        {
            for (int y = 0; y < board[0].Length; y++)
            {
                if (board[x][y] == word[0])
                {
                    bool[][] visited = new bool[board.Length][];
                    for (int index = 0; index < board.Length; index++)
                    {
                        visited[index] = new bool[board[0].Length];
                    }
                    if (TrySearch(board, word, x, y, 0, visited)) return true;
                }
            }
        }
        return false;
    }

    public bool TrySearch(char[][] board, string word, int x, int y, int index, bool[][] visited)
    {
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length || board[x][y] != word[index] || visited[x][y])
        {
            return false;
        }

        if (index == word.Length - 1)
        {
            return true;
        }

        visited[x][y] = true;
        bool result = TrySearch(board, word, x + 1, y, index + 1, visited)
            || TrySearch(board, word, x - 1, y, index + 1, visited)
            || TrySearch(board, word, x, y + 1, index + 1, visited)
            || TrySearch(board, word, x, y - 1, index + 1, visited);
        return result;
    }

    
}
// @lc code=end


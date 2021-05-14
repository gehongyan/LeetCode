/*
 * @lc app=leetcode.cn id=433 lang=csharp
 *
 * [433] 最小基因变化
 */

// @lc code=start
public class Solution {
    public int MinMutation(string start, string end, string[] bank) {
        // Queue<string> queue = new Queue<string>();
        // queue.Enqueue(start);
        // int count = 0;
        // while (queue.Count > 0)
        // {
        //     count++;
        //     string gene = queue.Dequeue();
        //     foreach (string g in GetNearGenes(gene, bank))
        //     {
        //         if(g == end) return count;
        //         queue.Enqueue(g);
        //     }
        // }
        // return -1;
        return GetSpaceBetweenGenes(start, end, bank, 0);
    }

    public IEnumerable<string> GetNearGenes(string gene, string[] bank)
    {
        return bank.AsEnumerable().Where(g => AreNearGenes(gene, g)).AsEnumerable();
    }

    public bool AreNearGenes(string gene1, string gene2)
    {
        int differentCount = 0;
        for (int index = 0; index < 8; index++)
        {
            if (gene1[index] != gene2[index])
            {
                differentCount++;
                if (differentCount == 2)
                {
                    return false;
                }
            }
        }
        return differentCount == 1;
    }

    public int GetSpaceBetweenGenes(string gene, string target, string[] bank, int currentStep)
    {
        if (currentStep > bank.Length)
        {
            return -1;
        }

        if (gene == target)
        {
            return 0;
        }

        if (AreNearGenes(gene, target) && bank.ToList().Contains(target))
        {
            return 1;
        }

        IEnumerable<string> list = GetNearGenes(gene, bank);

        int minStep = int.MaxValue;

        foreach (string g in list)
        {
            if (true)
            {
                int space = GetSpaceBetweenGenes(g, target, bank, currentStep + 1);
                if (space > 0 && space < minStep)
                {
                    minStep = space;
                }
            }
        }
        
        if (minStep == int.MaxValue)
        {
            return -1;
        }
        return minStep;
    }
}
// @lc code=end


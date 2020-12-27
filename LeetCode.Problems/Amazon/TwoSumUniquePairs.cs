using System.Collections.Generic;

namespace LeetCode.Problems.Amazon
{
    public class TwoSumUniquePairs
    {
        public int StockPairs(IList<int> stockProfit, int target)
        {
            var temp = new HashSet<int>();
            var result = new HashSet<int>();

            for (int i = 0; i < stockProfit.Count; i++)
            {
                var complement = target - stockProfit[i];
                if (temp.Contains(complement))
                {
                    result.Add(complement);
                }
                else
                {
                    temp.Add(stockProfit[i]);
                }
            }

            return result.Count;
        }
    }
}

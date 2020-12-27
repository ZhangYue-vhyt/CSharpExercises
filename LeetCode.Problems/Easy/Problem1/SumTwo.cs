using System.Collections.Generic;

namespace LeetCode.Problems.Easy.Problem1
{
    public class SumTwo
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (result.ContainsKey(complement))
                {
                    return new int[] { i, result[complement] };
                }
                result.TryAdd(nums[i], i);
            }
            return new int[] { };
        }
    }
}

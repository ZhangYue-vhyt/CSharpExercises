using System;

namespace LeetCode.Problems.Easy.Problem35
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (nums[i] < target && nums[i + 1] > target)
                    {
                        return i + 1;
                    }
                    else if (nums[i] >= target)
                    {
                        return i;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
}

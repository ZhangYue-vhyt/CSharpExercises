using System.Collections.Generic;

namespace LeetCode.Problems.Easy.Problem38
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var result = "1";
            for (int i = 1; i < n; i++)
            {
                var temp = string.Empty;
                var count = 1;
                var ca = result.ToCharArray();

                for (int j = 0; j < ca.Length; j++)
                {
                    try
                    {
                        if (ca[j].Equals(ca[j + 1]))
                        {
                            count++;
                        }
                        else
                        {
                            temp += count.ToString() + ca[j];
                            count = 1;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        temp += count.ToString() + ca[j];
                    }
                }

                result = temp;
            }
            return result;
        }
    }
}

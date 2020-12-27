using System;
namespace LeetCode.Problems.Medium.Problem957
{
    public class CellComplete
    {
        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            var result = new int[cells.Length];

            for (int day = 0; day < N % 14; day++)
            {
                for (int i = 0; i < cells.Length; i++)
                {
                    try
                    {
                        if ((cells[i - 1] ^ cells[i + 1]) == 0)
                        {
                            result[i] = 1;
                        }
                        else
                        {
                            result[i] = 0;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        result[i] = 0;
                    }
                }
                result.CopyTo(cells, 0);
            }

            return result;
        }
    }
}

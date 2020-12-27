using System;

namespace LeetCode.Problems.Medium.Problem8
{
    public class StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            var startIndex = 0;
            var endIndex = s.Length;
            var symbol = 1;

            if (s.StartsWith('+'))
            {
                startIndex++;
            }
            else if (s.StartsWith('-'))
            {
                symbol = -1;
                startIndex++;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                if (!char.IsDigit(s, i))
                {
                    endIndex = i;
                    break;
                }
            }

            try
            {
                return symbol * Convert.ToInt32(s.Substring(startIndex, endIndex - startIndex));
            }
            catch (OverflowException)
            {
                if (symbol > 0)
                {
                    return int.MaxValue;
                }
                return int.MinValue;
            }
            catch (FormatException)
            {
                return 0;
            }
        }
    }
}
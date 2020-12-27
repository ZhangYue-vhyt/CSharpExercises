using Xunit;
using LeetCode.Problems.Medium.Problem8;

namespace LeetCode.Tests.Medium
{
    public class Problem8Test
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new StringToInteger();
            var s1 = "42";
            var s2 = "  -42";
            var s3 = "4193 with words";
            var s4 = "words and 987";
            var s5 = "-91283472332";

            //When

            //Then
            Assert.Equal(42, instance.MyAtoi(s1));
            Assert.Equal(-42, instance.MyAtoi(s2));
            Assert.Equal(4193, instance.MyAtoi(s3));
            Assert.Equal(0, instance.MyAtoi(s4));
            Assert.Equal(-2147483648, instance.MyAtoi(s5));
        }
    }
}
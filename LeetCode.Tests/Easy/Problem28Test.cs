using LeetCode.Problems.Easy.Problem28;

using Xunit;

namespace LeetCode.Tests.Easy
{
    public class Problem28Test
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new ImplementStrStr();
            var haystack1 = "hello";
            var needle1 = "ll";
            var haystack2 = "aaaaa";
            var needle2 = "bba";
            var haystack3 = "";
            var needle3 = "";

            //When

            //Then
            Assert.Equal(2, instance.StrStr(haystack1, needle1));
            Assert.Equal(-1, instance.StrStr(haystack2, needle2));
            Assert.Equal(0, instance.StrStr(haystack3, needle3));
        }
    }
}

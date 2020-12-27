using LeetCode.Problems.Easy.Problem38;

using Xunit;

namespace LeetCode.Tests.Easy
{
    public class Problem38Test
    {
        [Fact]
        public void TestName()
        {
            //Given
            var instance = new CountAndSaySolution();

            //When

            //Then
            Assert.Equal("1", instance.CountAndSay(1));
            Assert.Equal("11", instance.CountAndSay(2));
            Assert.Equal("21", instance.CountAndSay(3));
            Assert.Equal("1211", instance.CountAndSay(4));
            Assert.Equal("111221", instance.CountAndSay(5));
            Assert.Equal("312211", instance.CountAndSay(6));
        }
    }
}
